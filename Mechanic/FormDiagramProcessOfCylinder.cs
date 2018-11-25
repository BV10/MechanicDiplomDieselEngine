using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Math;
using System.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Mechanic
{
    public partial class FormDiagramProcessOfCylinder : Form
    {
        private Main main;

        private const int WAITING_EXECUTE_CALCULATING = 10; // wait on execute calc data in milisec
        public const int SHIFT_OF_ELEM = 100;
        private const int SHIFT_ELEM_OF_GRAPHIC_Pi = 30;
        private CalcPolitrops calcPolitrops;
        private CalcSpecificForces calcSpecificForces;
        private bool isShowCalcDataPolitr;        
        private double lambdaDegreeIncreasePressureFromTextBox;
        public const int DELTA_ANGLE = 5;
        public int NumberCylinder { get; set; }

        private Task TaskCalcPolitropData { get; set; } = null;
        public Task TaskCalcSpecificForces { get; set; } = null;

        internal CalcSpecificForces CalcSpecificForces { get => calcSpecificForces; set => calcSpecificForces = value; }
        internal CalcPolitrops CalcPolitrops { get => calcPolitrops; set => calcPolitrops = value; }
        public Main Main { get => main; set => main = value; }

        // тиск повітря у надувному колекторі  для кожного циліндра
        public FormDiagramProcessOfCylinder(double Pk)
        {
            InitializeComponent();

            this.MaximizeBox = false;

            CalcSpecificForces = new CalcSpecificForces();
            CalcPolitrops = new CalcPolitrops(Pk, new DataPolitropsOfComprassionAndExpansion());
            timer.Interval = WAITING_EXECUTE_CALCULATING;
            this.label_Pc.Text = "Pc:  " + CalcPolitrops.PC.ToString();
            this.chart_IndicatorDiagram.Top = dataGridView_Politrop.Bottom + SHIFT_OF_ELEM;
            this.chartOfGasPressureOnPistonFromAngle.Top = this.dataGridView_CalcSpecifForces.Bottom + SHIFT_OF_ELEM;
            this.chartOfSpecificForcesP.Top = this.chartOfGasPressureOnPistonFromAngle.Bottom + SHIFT_OF_ELEM;
            this.chartOfSpecificForces_KAndN.Top = this.chartOfSpecificForcesP.Bottom + SHIFT_OF_ELEM;
            this.chartOfSpecificForces_TAndZ.Top = this.chartOfSpecificForces_KAndN.Bottom + SHIFT_OF_ELEM;


            this.chart_IndicatorDiagram.ChartAreas[0].AxisX.Title = "V";
            this.chart_IndicatorDiagram.ChartAreas[0].AxisY.Title = "p";


            this.chartOfSpecificForcesP.ChartAreas[0].AxisX.Title = "\u03c6";
            this.chartOfSpecificForcesP.ChartAreas[0].AxisY.Title = "Pr, Pj, P\u2A0A";//sum unicode

            this.chartOfSpecificForces_KAndN.ChartAreas[0].AxisX.Title = "\u03c6";
            this.chartOfSpecificForces_KAndN.ChartAreas[0].AxisY.Title = "K, N, МПа";


            this.chartOfSpecificForces_TAndZ.ChartAreas[0].AxisX.Title = "\u03c6";//phi unicode
            this.chartOfSpecificForces_TAndZ.ChartAreas[0].AxisY.Title = "T, Z, МПа";

            this.chartOfGasPressureOnPistonFromAngle.ChartAreas[0].AxisX.Title = "Кут повороту колінчатого валу, град";//phi unicode
            this.chartOfGasPressureOnPistonFromAngle.ChartAreas[0].AxisY.Title = "Тиск газів, МПа";

            this.label_AnalyticPip.Top = this.chart_IndicatorDiagram.Bottom + 50;
            this.label_AnalyticPip.Left = this.chart_IndicatorDiagram.Size.Width / 2 + this.chart_IndicatorDiagram.Left - (this.label_AnalyticPip.Size.Width / 2);


            this.label_GraphicPip.Top = this.label_AnalyticPip.Top;
            this.label_GraphicPip.Left = this.label_AnalyticPip.Left + this.label_AnalyticPip.Size.Width + SHIFT_ELEM_OF_GRAPHIC_Pi;
        }

        public void btnCalcAndBuildDiagr_Click(object sender, EventArgs e)
        {
            //отменяем предыдущий расчет
            if (TaskCalcPolitropData != null && !TaskCalcPolitropData.IsCompleted && CalcPolitrops.CancellationTokenSource != null)
            {
                timer.Stop();
                CalcPolitrops.CancellationTokenSource.Cancel();
                TaskCalcPolitropData = null;
            }
            else if (TaskCalcSpecificForces != null && !TaskCalcSpecificForces.IsCompleted && CalcSpecificForces.CancellationTokenSource != null)
            {
                timer.Stop();
                CalcSpecificForces.CancellationTokenSource.Cancel();
                TaskCalcSpecificForces = null;
            }
            // clear data in grid view
            ClearGridView(this.dataGridView_Politrop);
            ClearGridView(this.dataGridView_CalcSpecifForces);

            double n1 = double.Parse(textBox_N1_IndicPolitrCompres.Text);
            try
            {
                CalcPolitrops.N1 = n1;
                //change data on main window
                Main.Controls["textBox_N1OfCylind" + NumberCylinder].Text = n1.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Помилка в заданому значенні", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            double n2 = double.Parse(textBox_N2_IndicPolitrExpansion.Text); ;
            try
            {
                CalcPolitrops.N2 = n2;
                Main.Controls["textBox_N2OfCylind" + NumberCylinder].Text = n2.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Помилка в заданому значенні", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lambdaDegreeIncreasePressureFromTextBox = double.Parse(textBox_Lambda_DegreeOfPressureIncrease.Text);
            try
            {
                CalcPolitrops.LambdaDegreeIncreasePressure = lambdaDegreeIncreasePressureFromTextBox;
                Main.Controls["textBox_LambdaOfCylind" + NumberCylinder].Text = lambdaDegreeIncreasePressureFromTextBox.ToString();
                label_PZ.Text = "Pz:  " + Math.Round(CalcPolitrops.PZ, 3).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Помилка в заданому значенні", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TaskCalcPolitropData = CalcPolitrops.CalcPolitropsDataAsync(FormDiagramProcessOfCylinder.DELTA_ANGLE);

            isShowCalcDataPolitr = false;
            timer.Start(); // begin calculation

            //change Pc
            this.label_Pc.Text = "Pc:  " + CalcPolitrops.PC.ToString();
        }

        public static void ClearGridView(DataGridView dataGridView)
        {
            if (dataGridView.RowCount > 1)
            {
                for (int i = dataGridView.RowCount - 2; i >= 0; i--)
                {
                    dataGridView.Rows.RemoveAt(i);
                }
                dataGridView.Refresh();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (TaskCalcPolitropData.IsCompleted && !isShowCalcDataPolitr)
            {
                ShowDataPolitrop();
                //show Pip розрахунковий середній індикаторний тиск
                this.label_AnalyticPip.Text = "Аналітичне P\u1D62\u209A = " + Round(CalcAnalyticPip(CalcPolitrops), 3);
                this.label_GraphicPip.Text = "Графічне P\u1D62\u209A = " + Round(CalcGraphicPip(CalcPolitrops), 3);
                isShowCalcDataPolitr = true;
                CalcSpecificForces.CalcPolitrops = CalcPolitrops;
                TaskCalcSpecificForces = CalcSpecificForces.CalcDataOfSpecificForcesAsync(FormDiagramProcessOfCylinder.DELTA_ANGLE, this.lambdaDegreeIncreasePressureFromTextBox);
            }

            if (TaskCalcSpecificForces != null && TaskCalcSpecificForces.IsCompleted)
            {
                ShowDataSpecificForces();
                ClearChart(chartOfGasPressureOnPistonFromAngle);
                BuildChartOfGasPressureOnPistonFromAngle(chartOfGasPressureOnPistonFromAngle, CalcSpecificForces.DataSpecificForces);
                timer.Stop();
            }
        }

        // визначення Pip - графічний розрахунковий середній індикаторний тиск
        //Pip = sumF / Vh
        private double CalcGraphicPip(CalcPolitrops calcPolitrops)
        {
            DataPolitropsOfComprassionAndExpansion dataPolitrops = calcPolitrops.DataPolitrops;
            double sumF = 0.0;
            for (int i = 0; i < dataPolitrops.LengthInternalObject - 1; i++)
            {
                sumF += (dataPolitrops.V[i + 1] - dataPolitrops.V[i]) *
                    ((dataPolitrops.PressureOnLineExpansion[i] + dataPolitrops.PressureOnLineExpansion[i + 1]) / 2 -
                    (dataPolitrops.PressureOnLineCompression[i] + dataPolitrops.PressureOnLineCompression[i + 1]) / 2);
            }

            return sumF / calcPolitrops.Vh;
        }

        // визначення Pip - аналітичний розрахунковий середній індикаторний тиск
        private double CalcAnalyticPip(CalcPolitrops calcPolitrops)
        {
            double valOfFormula1 = calcPolitrops.PC / (calcPolitrops.Epsilon - 1);
            double valOfFormula2 = calcPolitrops.LambdaDegreeIncreasePressure * (calcPolitrops.RO - 1);
            double valOfFormula3 = ((calcPolitrops.LambdaDegreeIncreasePressure * calcPolitrops.RO) / (calcPolitrops.N2 - 1)) *
                (1 - 1 / (Pow(calcPolitrops.Epsilon / calcPolitrops.RO, calcPolitrops.N2 - 1)));
            double valOfFormula4 = (1 / (calcPolitrops.N1 - 1)) *
                (1 - 1 / (Pow(calcPolitrops.Epsilon, calcPolitrops.N1 - 1)));

            return valOfFormula1 * (valOfFormula2 + valOfFormula3 - valOfFormula4);
        }

        private void BuildChartOfGasPressureOnPistonFromAngle(Chart chart, DataOfCalculationSpecificForces dataSpecificForces)
        {
            int iterInternalSpecficForcesData = 0;
            for (iterInternalSpecficForcesData = 0;
                 iterInternalSpecficForcesData < dataSpecificForces.LengthInternalObject;
                 iterInternalSpecficForcesData++
                )
            {
                //первая линия графика - вся P для всех углов угла
                chart.Series[0].Points.AddXY(dataSpecificForces.Angles[iterInternalSpecficForcesData], dataSpecificForces.P[iterInternalSpecficForcesData]);
            }

            //вторая линия графика - P до 360 градусів і назад до нуля
            for (iterInternalSpecficForcesData = 0;
                 iterInternalSpecficForcesData < dataSpecificForces.LengthInternalObject && dataSpecificForces.Angles[iterInternalSpecficForcesData] != 360; // до 360 градусов
                 iterInternalSpecficForcesData++
                )
            {

                chart.Series[1].Points.AddXY(dataSpecificForces.Angles[iterInternalSpecficForcesData], dataSpecificForces.P[iterInternalSpecficForcesData]);
            }

            int iterBackInInternalSpecficForcesData = 0; // для прохода назад
            for (iterBackInInternalSpecficForcesData = iterInternalSpecficForcesData;
                 iterBackInInternalSpecficForcesData > -1 && iterInternalSpecficForcesData < dataSpecificForces.LengthInternalObject; // от 360 и назад для P, углы дальше до 720
                 iterBackInInternalSpecficForcesData--, iterInternalSpecficForcesData++
                )
            {

                chart.Series[1].Points.AddXY(dataSpecificForces.Angles[iterInternalSpecficForcesData], dataSpecificForces.P[iterBackInInternalSpecficForcesData]);
            }
        }

        public static void ClearChart(Chart chart)
        {
            for (int i = 0; i < chart.Series.Count; i++)
            {
                chart.Series[i].Points.Clear();
            }
        }

        private void ShowDataSpecificForces()
        {
            // очистка старых графіков            
            ClearChart(chartOfSpecificForcesP);
            ClearChart(chartOfSpecificForces_KAndN);
            ClearChart(chartOfSpecificForces_TAndZ);


            for (int iterInternalSpecficForcesData = 0;
                 iterInternalSpecficForcesData < CalcSpecificForces.DataSpecificForces.LengthInternalObject;
                 iterInternalSpecficForcesData++
                )
            {
                DataOfCalculationSpecificForces dataOfSpecificForces = CalcSpecificForces.DataSpecificForces;
                dataGridView_CalcSpecifForces.Rows.Add(
                    dataOfSpecificForces.Angles[iterInternalSpecficForcesData],
                    dataOfSpecificForces.P[iterInternalSpecficForcesData],
                    dataOfSpecificForces.Pr[iterInternalSpecficForcesData],
                    dataOfSpecificForces.J[iterInternalSpecficForcesData],
                    dataOfSpecificForces.Pj[iterInternalSpecficForcesData],
                    dataOfSpecificForces.Psum[iterInternalSpecficForcesData],
                    dataOfSpecificForces.TgBeta[iterInternalSpecficForcesData],
                    dataOfSpecificForces.N[iterInternalSpecficForcesData],
                    dataOfSpecificForces.CosBeta[iterInternalSpecficForcesData],
                    dataOfSpecificForces.K[iterInternalSpecficForcesData],
                    dataOfSpecificForces.SinPhiPlBetaOnCosBeta[iterInternalSpecficForcesData],
                    dataOfSpecificForces.T[iterInternalSpecficForcesData],
                    dataOfSpecificForces.CosPhiPlBetaOnCosBeta[iterInternalSpecficForcesData],
                    dataOfSpecificForces.Z[iterInternalSpecficForcesData]
                    );

                // будувати графік по точкам Pr, Pj, Psum
                chartOfSpecificForcesP.Series["SeriesPr"].Points.
                AddXY(dataOfSpecificForces.Angles[iterInternalSpecficForcesData], // V
                    dataOfSpecificForces.Pr[iterInternalSpecficForcesData] // p compression
                    );

                chartOfSpecificForcesP.Series["SeriesPj"].Points.
               AddXY(dataOfSpecificForces.Angles[iterInternalSpecficForcesData], // V
                   dataOfSpecificForces.Pj[iterInternalSpecficForcesData] // p expansion
                   );

                chartOfSpecificForcesP.Series["SeriesPsum"].Points.
               AddXY(dataOfSpecificForces.Angles[iterInternalSpecficForcesData], // V
                   dataOfSpecificForces.Psum[iterInternalSpecficForcesData] // p expansion
                   );
                // K, N
                chartOfSpecificForces_KAndN.Series["SeriesK"].Points.
                    AddXY(dataOfSpecificForces.Angles[iterInternalSpecficForcesData],
                    dataOfSpecificForces.K[iterInternalSpecficForcesData]);

                chartOfSpecificForces_KAndN.Series["SeriesN"].Points.
                    AddXY(dataOfSpecificForces.Angles[iterInternalSpecficForcesData],
                    dataOfSpecificForces.N[iterInternalSpecficForcesData]);

                //T, Z
                chartOfSpecificForces_TAndZ.Series["SeriesT"].Points.
                    AddXY(dataOfSpecificForces.Angles[iterInternalSpecficForcesData],
                    dataOfSpecificForces.T[iterInternalSpecficForcesData]);

                chartOfSpecificForces_TAndZ.Series["SeriesZ"].Points.
                    AddXY(dataOfSpecificForces.Angles[iterInternalSpecficForcesData],
                    dataOfSpecificForces.Z[iterInternalSpecficForcesData]);
            }

            AutosizeGridView(this.dataGridView_CalcSpecifForces);
        }

        private void ShowDataPolitrop()
        {
            // очистка старого графіка
            ClearChart(chart_IndicatorDiagram);


            for (int iterInternalPolitrData = 0;
                 iterInternalPolitrData < CalcPolitrops.DataPolitrops.LengthInternalObject;
                 iterInternalPolitrData++
                )
            {
                DataPolitropsOfComprassionAndExpansion dataPolitrop = CalcPolitrops.DataPolitrops;
                dataGridView_Politrop.Rows.Add(
                    dataPolitrop.Angles[iterInternalPolitrData],
                    dataPolitrop.S[iterInternalPolitrData],
                    dataPolitrop.MultiplesFnAndS[iterInternalPolitrData],
                    dataPolitrop.V[iterInternalPolitrData],
                    dataPolitrop.RatioVaToV[iterInternalPolitrData],
                    dataPolitrop.RatioVaToVInDegreeN1[iterInternalPolitrData],
                    dataPolitrop.PressureOnLineCompression[iterInternalPolitrData],
                    dataPolitrop.RatioVToVz[iterInternalPolitrData],
                    dataPolitrop.RatioVzToVInDegreeN2[iterInternalPolitrData],
                    dataPolitrop.PressureOnLineExpansion[iterInternalPolitrData]
                    );

                // будувати графік по точкам
                CustomizeAxisYLabelOfChartIndicatorDiagram(chart_IndicatorDiagram, dataPolitrop);            

                chart_IndicatorDiagram.Series["PolitropOfComprassion"].Points.
                AddXY(dataPolitrop.V[iterInternalPolitrData], // V
                    dataPolitrop.PressureOnLineCompression[iterInternalPolitrData] // p compression
                    );

                chart_IndicatorDiagram.Series["PolitropOfExpansion"].Points.
               AddXY(dataPolitrop.V[iterInternalPolitrData], // V
                   dataPolitrop.PressureOnLineExpansion[iterInternalPolitrData] // p expansion
                   );

                
            }

            // autosize height
            AutosizeGridView(this.dataGridView_Politrop);
        }

        private void CustomizeAxisYLabelOfChartIndicatorDiagram(Chart chart_IndicatorDiagram, DataPolitropsOfComprassionAndExpansion dataPolitrop)
        {
            chart_IndicatorDiagram.ChartAreas[0].AxisY.CustomLabels.Clear();
            
            double pMinOnLineCompress = dataPolitrop.PressureOnLineCompression.Min();
            double pMinOnLineExpansion = dataPolitrop.PressureOnLineExpansion.Min();
            double minP = pMinOnLineCompress <= pMinOnLineExpansion ? pMinOnLineCompress : pMinOnLineExpansion;

            double pMaxOnLineCompress = dataPolitrop.PressureOnLineCompression.Max();
            double pMaxOnLineExpansion = dataPolitrop.PressureOnLineExpansion.Max();
            double maxP = pMaxOnLineCompress >= pMaxOnLineExpansion ? pMaxOnLineCompress : pMaxOnLineExpansion;

            double deltaP = 0.5;
            while(minP < maxP)
            {
                chart_IndicatorDiagram.ChartAreas[0].AxisY.CustomLabels.Add(new CustomLabel(minP - 15, minP + 15, minP.ToString(), 0, LabelMarkStyle.None));
                minP += deltaP;
            }
        }

        public static void AutosizeGridView(DataGridView dataGridView)
        {
            var height = 40;
            foreach (DataGridViewRow dr in dataGridView.Rows)
            {
                height += dr.Height;
            }
            dataGridView.Height = height;
        }

        private void dataGridView_Politrop_Resize(object sender, EventArgs e)
        {
            //placement chart after resize datagrid
            this.chart_IndicatorDiagram.Top = dataGridView_Politrop.Bottom + SHIFT_OF_ELEM;
        }

        private void chart_IndicatorDiagram_Move(object sender, EventArgs e)
        {
            //placement datagridview of calc specif forcews after movement chartIndicDiagr
            this.dataGridView_CalcSpecifForces.Top = this.chart_IndicatorDiagram.Bottom + SHIFT_OF_ELEM;
            //Pip under chart
            this.label_AnalyticPip.Top = this.chart_IndicatorDiagram.Bottom + 50;
            this.label_AnalyticPip.Left = this.chart_IndicatorDiagram.Size.Width / 2 + this.chart_IndicatorDiagram.Left - (this.label_AnalyticPip.Size.Width / 2);
        }

        private void dataGridView_CalcSpecifForces_Resize(object sender, EventArgs e)
        {
            this.chartOfGasPressureOnPistonFromAngle.Top = this.dataGridView_CalcSpecifForces.Bottom + SHIFT_OF_ELEM;
        }

        private void chartOfSpecificForcesP_Move(object sender, EventArgs e)
        {
            this.chartOfSpecificForces_KAndN.Top = this.chartOfSpecificForcesP.Bottom + SHIFT_OF_ELEM;
        }

        private void chartOfSpecificForces_KAndN_Move(object sender, EventArgs e)
        {
            this.chartOfSpecificForces_TAndZ.Top = this.chartOfSpecificForces_KAndN.Bottom + SHIFT_OF_ELEM;
        }

        private void chartOfGasPressureOnPistonFromAngle_Move(object sender, EventArgs e)
        {
            this.chartOfSpecificForcesP.Top = this.chartOfGasPressureOnPistonFromAngle.Bottom + SHIFT_OF_ELEM;
        }

        private void label_AnalyticPip_Move(object sender, EventArgs e)
        {
            this.label_GraphicPip.Top = this.label_AnalyticPip.Top;
            this.label_GraphicPip.Left = this.label_AnalyticPip.Left + this.label_AnalyticPip.Size.Width + SHIFT_ELEM_OF_GRAPHIC_Pi;
        }
    }
}
