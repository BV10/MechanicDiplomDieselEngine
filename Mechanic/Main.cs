using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Math;


namespace Mechanic
{
    public partial class Main : Form
    {
        //totsl torque - сумарний обертальний момент
        //const
        private const int START_ANGLE_T1 = 0;
        private const int START_ANGLE_T2 = 120;
        private const int START_ANGLE_T3 = 600;
        private const int START_ANGLE_T4 = 240;
        private const int START_ANGLE_T5 = 480;
        private const int START_ANGLE_T6 = 360;

        private const int COUNT_CYLINDER_ENGINE = 6;
        private const int FIRST_CYLINDER = 0;
        private const int SECOND_CYLINDER = 1;
        private const int THIRD_CYLINDER = 2;
        private const int FOURTH_CYLINDER = 3;
        private const int FIFTH_CYLINDER = 4;
        private const int SIXTH_CYLINDER = 5;
        private const int SHIFT_ELEM_CONTROL = 50;
        private const int DEFAULT_SHIFT_OF_CONTROLS = 20;
        private const int INCREASED_VALUE_FOR_CORRECT_SHOW_LAST_GRID = 200;
        private const double DEFAULT_VALUE_N1 = 1.36;
        private const double DEFAULT_VALUE_N2 = 1.27;
        private const double DEFAULT_VALUE_LAMBDA = 1.5;

        private List<CalcSpecificForces> CalcSpecificForcesOfCylinders { get; set; } = new List<CalcSpecificForces>();
        private List<FormDiagramProcessOfCylinder> FormsDiagrOfCylinderProcesses { get; set; } = new List<FormDiagramProcessOfCylinder>();
        private List<double> TotalTorqueOfCylinders { get; set; } = new List<double>(); // обертальні моменти двигунів

        //max total torques
        private double maxTotalTorque = 0.0;
        //min total torques
        private double minTotalTorque = 0.0;
        // average total torque
        private double averageTotalTorque = 0.0;

        double[] IdealEngineTotalTorques =
        {
            -0.367, 4.167, 8.937, 14.127, 19.723, 21.924, 19.644, 17.233, 15.228, 13.812, 13.013, 12.777,
            12.843, 12.345, 11.794, 11.021, 9.894, 8.4, 6.526, 4.39, 2.267, 0.459, -0.655, -0.865, -0.367,
            4.167, 8.937, 14.127, 19.723, 21.924, 19.644, 17.233, 15.228, 13.812, 13.013, 12.777, 12.843,
            12.345, 11.794, 11.021, 9.894, 8.4, 6.526, 4.39, 2.267, 0.459, -0.655, -0.865, -0.367, 4.167,
            8.937, 14.127, 19.723, 21.924, 19.644, 17.233, 15.228, 13.812, 13.013, 12.777, 12.843, 12.345,
            11.794, 11.021, 9.894, 8.4, 6.526, 4.39, 2.267, 0.459, -0.655, -0.865, -0.367, 4.167, 8.937,
            14.127, 19.723, 21.924, 19.644, 17.233, 15.228, 13.812, 13.013, 12.777, 12.843, 12.345, 11.794,
            11.021, 9.894, 8.4, 6.526, 4.39, 2.267, 0.459, -0.655, -0.865, -0.367, 4.167, 8.937, 14.127,
            19.723, 21.924, 19.644, 17.233, 15.228, 13.812, 13.013, 12.777, 12.843, 12.345, 11.794, 11.021,
            9.894, 8.4, 6.526, 4.39, 2.267, 0.459, -0.655, -0.865, -0.367, 4.167, 8.937, 14.127, 19.723,
            21.924, 19.644, 17.233, 15.228, 13.812, 13.013, 12.777, 12.843, 12.345, 11.794, 11.021, 9.894,
            8.4, 6.526, 4.39, 2.267, 0.459, -0.655, -0.865
        };

        public Main()
        {
            InitializeComponent();
            InitializeGridViewDataForDiagram();            
            chartTotalToque.Top = btnTotalTorqueEngine.Bottom + DEFAULT_SHIFT_OF_CONTROLS;
            dataGridView_TiAndMi.Top = chartTotalToque.Bottom + DEFAULT_SHIFT_OF_CONTROLS;
            dataGridView_TorqueUniformity.Top = dataGridView_TiAndMi.Bottom + DEFAULT_SHIFT_OF_CONTROLS + 20;
            //dataGridView_TorqueUniformity.Bottom += 20;
            this.btnDrawDiagram.Select();
            this.chartTotalToque.ChartAreas[0].AxisX.Title = "\u03c6";
            this.chartTotalToque.ChartAreas[0].AxisY.Title = "M";
            DrawChartIdealWorkingOfEngineTotalToque(chartTotalToque);

            this.MaximizeBox = false;

        }

        private void DrawChartIdealWorkingOfEngineTotalToque(Chart chart)
        {
            //create new seties
            Series series = new Series();
            series.ChartArea = "ChartArea1";
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series.IsVisibleInLegend = false;
            this.chartTotalToque.Series.Add(series);

            //customize grid line
            chartTotalToque.ChartAreas[0].AxisX.MajorTickMark.Enabled = false;
            chartTotalToque.ChartAreas[0].AxisX.MajorGrid.Interval = 120;

            chartTotalToque.ChartAreas[0].AxisX.Minimum = 0;
            chartTotalToque.ChartAreas[0].AxisX.Maximum = 720;

            for (int angle = CalcSpecificForces.START_ANGLE, iterTotalTorque = 0;
                angle <= CalcSpecificForces.END_ANGLE && iterTotalTorque < IdealEngineTotalTorques.Length;
                angle += FormDiagramProcessOfCylinder.DELTA_ANGLE, iterTotalTorque++)
            {
                series.Points.AddXY(angle, IdealEngineTotalTorques[iterTotalTorque]);
                series.Points[iterTotalTorque].Color = Color.Black;

            }
        }

        private void InitializeGridViewDataForDiagram()
        {
            for (int i = 0; i < COUNT_CYLINDER_ENGINE; i++)
            {
                this.dataGridView_DataForDiagram.Rows.Add(
                    i + 1, DEFAULT_VALUE_N1, DEFAULT_VALUE_N2, DEFAULT_VALUE_LAMBDA, String.Empty,
                    String.Empty, String.Empty, String.Empty, String.Empty
                );
            }
            FormDiagramProcessOfCylinder.AutosizeGridView(dataGridView_DataForDiagram);
        }

        private void btnDrawDiagram_Click(object sender, EventArgs e)
        {
            //закрываем и очищаем предыдущие окна рассчетов и рассчеты
            ResetOldCalcFormProcess();
            CalcSpecificForcesOfCylinders.Clear();

            double pk = 0.0;
            try
            {
                pk = double.Parse(textBox_Pk.Text);
            }
            catch
            {
                MessageBox.Show("Неверный формат данных для Pk.");
                return;
            }

            for (int i = 0; i < COUNT_CYLINDER_ENGINE; i++)
            {
                FormDiagramProcessOfCylinder formCreateDiagramProcess = new FormDiagramProcessOfCylinder(pk);
                formCreateDiagramProcess.Main = this;
                FormsDiagrOfCylinderProcesses.Add(formCreateDiagramProcess);
                formCreateDiagramProcess.NumberCylinder = i + 1;
                formCreateDiagramProcess.Text += " " + (i + 1);
                formCreateDiagramProcess.LabelDataForCreateDiagr.Text += " " + (i + 1) + "-го " + "циліндра.";
                CalcSpecificForcesOfCylinders.Add(formCreateDiagramProcess.CalcSpecificForces);

                // add setted data for calc politron
                string n1OfCylind = this.dataGridView_DataForDiagram.Rows[i].Cells[1].Value.ToString();
                string n2OfCylind = this.dataGridView_DataForDiagram.Rows[i].Cells[2].Value.ToString();
                string lambdaOfCylind = this.dataGridView_DataForDiagram.Rows[i].Cells[3].Value.ToString();

                formCreateDiagramProcess.TextBox_N1_IndicPolitrCompres.Text = n1OfCylind;
                formCreateDiagramProcess.TextBox_N2_IndicPolitrExpansion.Text = n2OfCylind;
                formCreateDiagramProcess.TextBox_Lambda_DegreeOfPressureIncrease.Text = lambdaOfCylind;
                formCreateDiagramProcess.Show();
                formCreateDiagramProcess.BtnCalcAndBuildDiagr.PerformClick();
            }
            this.TopMost = true;
            this.TopMost = false;
        }

        private void ResetOldCalcFormProcess()
        {
            if (FormsDiagrOfCylinderProcesses.Count > 0)
            {
                FormsDiagrOfCylinderProcesses.ForEach(form => form.Close());
            }
            FormsDiagrOfCylinderProcesses.Clear();
        }

        private void btnTotalTorqueEngine_Click(object sender, EventArgs e)
        {
            //checked calculation data for cylinder
            if (CalcSpecificForcesOfCylinders.Count == 0)
            {
                MessageBox.Show("Дані для циліндрів не були розраховані.");
                return;
            }
            //minimize other windows
            //foreach (var formCylinderProc in FormsCylinderProcesses)
            //{
            //    if (formCylinderProc != null)
            //    {
            //        formCylinderProc.WindowState = FormWindowState.Minimized;
            //    }
            //}

            //check - are calculated data for all cylinders
            for (int i = 0; i < CalcSpecificForcesOfCylinders.Count; i++)
            {
                if (CalcSpecificForcesOfCylinders[i] == null || CalcSpecificForcesOfCylinders[i].DataSpecificForces == null || //данные существуют
                    (FormsDiagrOfCylinderProcesses[i].TaskCalcSpecificForces != null && !FormsDiagrOfCylinderProcesses[i].TaskCalcSpecificForces.IsCompleted)) //данные вычислены полностью
                {
                    DialogResult dialogResult = MessageBox.Show("Дані для циліндра " + (i + 1) + " не були розраховані.");
                    //if (dialogResult == DialogResult.OK)
                    //{
                    //    //this.WindowState = FormWindowState.Minimized;
                    //    if (FormsCylinderProcesses[i] != null)
                    //    {
                    //        FormsCylinderProcesses[i].WindowState = FormWindowState.Normal;
                    //    }
                    //}
                    return;
                }
            }

            // add calculating data to datagrid view
            for (int i = 0; i < COUNT_CYLINDER_ENGINE; i++)
            {
                //Calc Ni - індикаторна потужність двигуна
                double ni = Round(FormsDiagrOfCylinderProcesses[i].CalcPolitrops.CalcNi(), 3);
                this.dataGridView_DataForDiagram.Rows[i].Cells[4].Value = ni;
                //Calc etaI - індикаторний КПД
                double etaI = Round(FormsDiagrOfCylinderProcesses[i].CalcPolitrops.CalcEtaI(), 3);
                this.dataGridView_DataForDiagram.Rows[i].Cells[5].Value = etaI;
                //calc Ne - ефективна потужність
                this.dataGridView_DataForDiagram.Rows[i].Cells[6].Value = Round(ni * 0.84, 3);
                //calc etaE - ефективна КПД
                this.dataGridView_DataForDiagram.Rows[i].Cells[7].Value = Round(etaI * 0.84, 3);
                //calc be - ефективна питома витрата палива
                this.dataGridView_DataForDiagram.Rows[i].Cells[8].Value = Round((3600 / (etaI * 41500)) / 0.84, 3);
            }

            //очистити таблицю від старих питомі сили циліндрів та сумарний обертальний момент двигуна
            FormDiagramProcessOfCylinder.ClearGridView(dataGridView_TiAndMi);
            //показати питомі сили циліндрів та сумарний обертальний момент двигуна
            ShowSpecificForcesAndTorqueEngineOnGridView(dataGridView_TiAndMi);
            //очистити графік залежності обертального моменту від кута 
            //FormDiagramProcessOfCylinder.ClearChart(chartTotalToque);
            //побудувати графік залежності обертального моменту від кута
            BuildChartTotalToque(chartTotalToque);
            ////очистити таблицю від старих оэффициентов неравномерности крутящего момента для всех цилиндров
            FormDiagramProcessOfCylinder.ClearGridView(dataGridView_TorqueUniformity);
            // показати табцицю коэффициентов неравномерности крутящего момента для всех цилиндров
            ShowTorqueUniformities(CalcTorqueUniformities(TotalTorqueOfCylinders), dataGridView_TorqueUniformity);
        }


        private void BuildChartTotalToque(Chart chartTotalToque)
        {
            //create new seties
            Series series = new Series();
            series.ChartArea = "ChartArea1";
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series.IsVisibleInLegend = false;
            this.chartTotalToque.Series.Add(series);

            //customize grid line
            chartTotalToque.ChartAreas[0].AxisX.MajorTickMark.Enabled = false;
            chartTotalToque.ChartAreas[0].AxisX.MajorGrid.Interval = 120;

            chartTotalToque.ChartAreas[0].AxisX.Minimum = 0;
            chartTotalToque.ChartAreas[0].AxisX.Maximum = 720;

            for (int angle = CalcSpecificForces.START_ANGLE, iterTotalTorque = 0;
                angle <= CalcSpecificForces.END_ANGLE && iterTotalTorque < TotalTorqueOfCylinders.Count;
                angle += FormDiagramProcessOfCylinder.DELTA_ANGLE, iterTotalTorque++)
            {

                series.Points.AddXY(angle, TotalTorqueOfCylinders[iterTotalTorque]);

                //changle color of points on ecery 120 degrees
                if (angle <= 120)
                {
                    series.Points[iterTotalTorque].Color = Color.Blue;
                }
                else if (angle <= 240)
                {
                    series.Points[iterTotalTorque].Color = Color.Green;
                }
                else if (angle <= 360)
                {
                    series.Points[iterTotalTorque].Color = Color.Aqua;
                }
                else if (angle <= 480)
                {
                    series.Points[iterTotalTorque].Color = Color.Red;
                }
                else if (angle <= 600)
                {
                    series.Points[iterTotalTorque].Color = Color.Violet;
                }
                else if (angle <= 720)
                {
                    series.Points[iterTotalTorque].Color = Color.Brown;
                }
            }

            //chartTotalToque.
            //int i = 0;
        }

        private void ShowSpecificForcesAndTorqueEngineOnGridView(DataGridView dataGridView)
        {
            // remove records in calculations of data specific forces with first angle == 360, and left next record with 360(left record with pressure expansion)
            CalcSpecificForcesOfCylinders.ForEach(calcSpecForces =>
            {
                int indexRecordWith360Degree = calcSpecForces.DataSpecificForces.Angles.BinarySearch(360);
                if (calcSpecForces.DataSpecificForces.Angles[indexRecordWith360Degree + 1] == 360) // data for 360 degree was remmoved
                {
                    calcSpecForces.DataSpecificForces.Angles.RemoveAt(indexRecordWith360Degree);
                    calcSpecForces.DataSpecificForces.T.RemoveAt(indexRecordWith360Degree);
                }
            });

            //CalcSpecificForcesOfCylinders[FIRST_CYLINDER].
            //reset total torque
            TotalTorqueOfCylinders = new List<double>();
            //create bearing index of T in 6 cylinder for going along T in data specif forces
            int bearingIndexT1 = CalcSpecificForcesOfCylinders[FIRST_CYLINDER].DataSpecificForces.Angles.BinarySearch(START_ANGLE_T1);
            int bearingIndexT2 = CalcSpecificForcesOfCylinders[SECOND_CYLINDER].DataSpecificForces.Angles.BinarySearch(START_ANGLE_T2);
            int bearingIndexT3 = CalcSpecificForcesOfCylinders[THIRD_CYLINDER].DataSpecificForces.Angles.BinarySearch(START_ANGLE_T3);
            int bearingIndexT4 = CalcSpecificForcesOfCylinders[FOURTH_CYLINDER].DataSpecificForces.Angles.BinarySearch(START_ANGLE_T4);
            int bearingIndexT5 = CalcSpecificForcesOfCylinders[FIFTH_CYLINDER].DataSpecificForces.Angles.BinarySearch(START_ANGLE_T5);
            int bearingIndexT6 = CalcSpecificForcesOfCylinders[SIXTH_CYLINDER].DataSpecificForces.Angles.BinarySearch(START_ANGLE_T6);

            int lengthInternalObjectsInDataSpecForces = CalcSpecificForcesOfCylinders[FIRST_CYLINDER].DataSpecificForces.LengthInternalObject;


            for (int iterT = 0; iterT < lengthInternalObjectsInDataSpecForces - 1; iterT++) // go along DataSpecificForces for get T of differentcylinder
            {
                double T1 = CalcSpecificForcesOfCylinders[FIRST_CYLINDER].DataSpecificForces.T[bearingIndexT1];
                double T2 = CalcSpecificForcesOfCylinders[SECOND_CYLINDER].DataSpecificForces.T[bearingIndexT2];
                double T3 = CalcSpecificForcesOfCylinders[THIRD_CYLINDER].DataSpecificForces.T[bearingIndexT3];
                double T4 = CalcSpecificForcesOfCylinders[FOURTH_CYLINDER].DataSpecificForces.T[bearingIndexT4];
                double T5 = CalcSpecificForcesOfCylinders[FIFTH_CYLINDER].DataSpecificForces.T[bearingIndexT5];
                double T6 = CalcSpecificForcesOfCylinders[SIXTH_CYLINDER].DataSpecificForces.T[bearingIndexT6];
                double Tsum = Round(T1 + T2 + T3 + T4 + T5 + T6, 3);
                //Mi = 1000 * TSum * Fn * R
                double totalTorque = Round(1000 * Tsum * FormsDiagrOfCylinderProcesses[FIRST_CYLINDER].CalcPolitrops.Fn * CalcPolitrops.R, 3);
                TotalTorqueOfCylinders.Add(totalTorque);

                //save max totalTorque and min totalTorque  
                if (iterT == 0)
                {
                    this.maxTotalTorque = totalTorque;
                    this.minTotalTorque = totalTorque;
                }
                else
                {
                    if (totalTorque > maxTotalTorque)
                    {
                        this.maxTotalTorque = totalTorque;
                    }
                    if (totalTorque < minTotalTorque)
                    {
                        this.minTotalTorque = totalTorque;
                    }
                }

                dataGridView.Rows.Add(CalcSpecificForcesOfCylinders[FIRST_CYLINDER].DataSpecificForces.Angles[iterT], T1, T2, T3, T4, T5, T6, Tsum, totalTorque);
                //increase index
                bearingIndexT1++;
                bearingIndexT2++;
                bearingIndexT3++;
                bearingIndexT4++;
                bearingIndexT5++;
                bearingIndexT6++;
                //lengthInternalObjectsInDataSpecForces-1 cause value in 720 degree is the same as 0 degree
                if (bearingIndexT1 == lengthInternalObjectsInDataSpecForces - 1) //index in end - go from start, 
                {
                    bearingIndexT1 = 0;
                }

                if (bearingIndexT2 == lengthInternalObjectsInDataSpecForces - 1) //index in end - go from start
                {
                    bearingIndexT2 = 0;
                }

                if (bearingIndexT3 == lengthInternalObjectsInDataSpecForces - 1) //index in end - go from start
                {
                    bearingIndexT3 = 0;
                }

                if (bearingIndexT4 == lengthInternalObjectsInDataSpecForces - 1) //index in end - go from start
                {
                    bearingIndexT4 = 0;
                }

                if (bearingIndexT5 == lengthInternalObjectsInDataSpecForces - 1) //index in end - go from start
                {
                    bearingIndexT5 = 0;
                }

                if (bearingIndexT6 == lengthInternalObjectsInDataSpecForces - 1) //index in end - go from start
                {
                    bearingIndexT6 = 0;
                }
            }

            //save average total torque
            this.averageTotalTorque = (this.maxTotalTorque + this.minTotalTorque) / 2;
            FormDiagramProcessOfCylinder.AutosizeGridView(dataGridView);
        }

        private List<TorqueUniformity> CalcTorqueUniformities(List<double> totalTorque)
        {
            List<TorqueUniformity> torqueUniformities = new List<TorqueUniformity>();

            double totalTorqueMaxOnRange = totalTorque[0];
            double totalTorqueMinRange = totalTorque[0];
            for (int angle = CalcSpecificForces.START_ANGLE, iterTotalTorque = 1;
               angle <= CalcSpecificForces.END_ANGLE && iterTotalTorque < totalTorque.Count;
               angle += FormDiagramProcessOfCylinder.DELTA_ANGLE, iterTotalTorque++)
            {
                if (totalTorqueMaxOnRange < totalTorque[iterTotalTorque])
                {
                    totalTorqueMaxOnRange = totalTorque[iterTotalTorque];
                }
                if (totalTorqueMinRange > totalTorque[iterTotalTorque])
                {
                    totalTorqueMinRange = totalTorque[iterTotalTorque];
                }

                //save Mmax and Mmin, Mu on ranges
                if (angle == 120 || angle == 240 || angle == 360 || angle == 480
                    || angle == 600
                    )
                {
                    torqueUniformities.Add(new TorqueUniformity(totalTorqueMaxOnRange, totalTorqueMinRange, (totalTorqueMaxOnRange - totalTorqueMinRange) / this.averageTotalTorque));

                    // for seek next max and min on ranges
                    totalTorqueMaxOnRange = totalTorque[iterTotalTorque + 1];
                    totalTorqueMinRange = totalTorque[iterTotalTorque + 1];
                }
                else if (iterTotalTorque == totalTorque.Count - 1)
                {
                    torqueUniformities.Add(new TorqueUniformity(totalTorqueMaxOnRange, totalTorqueMinRange, (totalTorqueMaxOnRange - totalTorqueMinRange) / this.averageTotalTorque));
                    break;
                }
            }
            //change order of cylinder for process
            List<TorqueUniformity> torqueUniformitiesResult = new List<TorqueUniformity>();
            torqueUniformitiesResult.Add(torqueUniformities[3]);
            torqueUniformitiesResult.Add(torqueUniformities[2]);
            torqueUniformitiesResult.Add(torqueUniformities[4]);
            torqueUniformitiesResult.Add(torqueUniformities[1]);
            torqueUniformitiesResult.Add(torqueUniformities[5]);
            torqueUniformitiesResult.Add(torqueUniformities[0]);

            return torqueUniformitiesResult;
        }

        static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }

        private void ShowTorqueUniformities(List<TorqueUniformity> torqueUniformities, DataGridView dataGridView)
        {
            int iter = 0;
            torqueUniformities.ForEach(torqueUniformity =>
            {
                dataGridView.Rows.Add(iter + 1, Round(torqueUniformity.Mmax, 3), Round(torqueUniformity.Mmin, 3), Round(torqueUniformity.Mu, 3));
                iter++;
            });
            FormDiagramProcessOfCylinder.AutosizeGridView(dataGridView);
        }

        //customize labels of angles on chart
        private void chartTotalToque_Customize(object sender, EventArgs e)
        {
            chartTotalToque.ChartAreas[0].AxisX.CustomLabels.Clear();

            chartTotalToque.ChartAreas[0].AxisX.CustomLabels.Add(new CustomLabel(-20, 20, "0", 0, LabelMarkStyle.None));
            chartTotalToque.ChartAreas[0].AxisX.CustomLabels.Add(new CustomLabel(100, 140, "120", 0, LabelMarkStyle.None));
            chartTotalToque.ChartAreas[0].AxisX.CustomLabels.Add(new CustomLabel(220, 260, "240", 0, LabelMarkStyle.None));
            chartTotalToque.ChartAreas[0].AxisX.CustomLabels.Add(new CustomLabel(340, 380, "360", 0, LabelMarkStyle.None));
            chartTotalToque.ChartAreas[0].AxisX.CustomLabels.Add(new CustomLabel(460, 500, "480", 0, LabelMarkStyle.None));
            chartTotalToque.ChartAreas[0].AxisX.CustomLabels.Add(new CustomLabel(580, 620, "600", 0, LabelMarkStyle.None));
            chartTotalToque.ChartAreas[0].AxisX.CustomLabels.Add(new CustomLabel(700, 740, "720", 0, LabelMarkStyle.None));
        }

        private void dataGridView_TiAndMi_Resize(object sender, EventArgs e)
        {
            dataGridView_TorqueUniformity.Top = dataGridView_TiAndMi.Bottom + SHIFT_ELEM_CONTROL;
        }
    }
}
