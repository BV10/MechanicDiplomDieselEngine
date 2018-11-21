using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Mechanic
{
    public partial class FormDiagramProcessOfCylinder : Form
    {
        private const int WAITING_EXECUTE_CALCULATING = 10; // wait on execute calc data in milisec
        public const int SHIFT_OF_ELEM = 100;
        private CalcPolitrops calcPolitrops = new CalcPolitrops(
            new DataPolitropsOfComprassionAndExpansion());
        private CalcSpecificForces calcSpecificForces;
        private bool isShowCalcDataPolitr;
        private int deltaAngle; // кут введений з клавіатури

        private Task TaskCalcPolitropData { get; set; } = null;
        public Task TaskCalcSpecificForces { get; set; } = null;
        
        internal CalcSpecificForces CalcSpecificForces { get => calcSpecificForces; set => calcSpecificForces = value; }
        internal CalcPolitrops CalcPolitrops { get => calcPolitrops; set => calcPolitrops = value; }
        public int DeltaAngle { get => deltaAngle; set => deltaAngle = value; }

        public FormDiagramProcessOfCylinder()
        {
            InitializeComponent();
            CalcSpecificForces = new CalcSpecificForces();
            timer.Interval = WAITING_EXECUTE_CALCULATING;
            this.label_Pc.Text = "Pc:  " + CalcPolitrops.PC.ToString();
            this.chartOfSpecificForcesP.Top = this.dataGridView_CalcSpecifForces.Bottom + SHIFT_OF_ELEM;
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
        }

        private void btnCalcAndBuildDiagr_Click(object sender, EventArgs e)
        {     
            //отменяем предыдущий расчет
            if (TaskCalcPolitropData != null && !TaskCalcPolitropData.IsCompleted && CalcPolitrops.CancellationTokenSource != null)
            {
                timer.Stop();
                CalcPolitrops.CancellationTokenSource.Cancel();
                TaskCalcPolitropData = null;                             
            }
            else if(TaskCalcSpecificForces != null && !TaskCalcSpecificForces.IsCompleted && CalcSpecificForces.CancellationTokenSource != null)
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Помилка в заданому значенні", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double lambdaDegreeIncreasePressure = double.Parse(textBox_Lambda_DegreeOfPressureIncrease.Text);
            try
            {
                CalcPolitrops.LambdaDegreeIncreasePressure = lambdaDegreeIncreasePressure;
                label_PZ.Text = "Pz:  " + Math.Round(CalcPolitrops.PZ, 3).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Помилка в заданому значенні", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DeltaAngle = int.Parse(textBox_DeltaAngle.Text);

            TaskCalcPolitropData = CalcPolitrops.CalcPolitropsDataAsync(DeltaAngle);
            
            isShowCalcDataPolitr = false;
            //isShowCalcSpecificForces = false;
            timer.Start(); // begin calculation

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
                isShowCalcDataPolitr = true;
                CalcSpecificForces.CalcPolitrops = CalcPolitrops;
                TaskCalcSpecificForces = CalcSpecificForces.CalcDataOfSpecificForcesAsync(this.DeltaAngle);
            }

            if(TaskCalcSpecificForces != null && TaskCalcSpecificForces.IsCompleted)
            {
                ShowDataSpecificForces();
                timer.Stop();
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

        }

        private void dataGridView_CalcSpecifForces_Resize(object sender, EventArgs e)
        {
            this.chartOfSpecificForcesP.Top = this.dataGridView_CalcSpecifForces.Bottom + SHIFT_OF_ELEM;
        }

        private void chartOfSpecificForcesP_Move(object sender, EventArgs e)
        {
            this.chartOfSpecificForces_KAndN.Top = this.chartOfSpecificForcesP.Bottom + SHIFT_OF_ELEM;
        }

        private void chartOfSpecificForces_KAndN_Move(object sender, EventArgs e)
        {
            this.chartOfSpecificForces_TAndZ.Top = this.chartOfSpecificForces_KAndN.Bottom + SHIFT_OF_ELEM;
        }
    }
}
