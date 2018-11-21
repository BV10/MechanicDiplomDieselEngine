using System;
using System.Collections.Generic;
using System.Drawing;
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
        private const int START_ANGLE_T2 = 600;
        private const int START_ANGLE_T3 = 120;
        private const int START_ANGLE_T4 = 480;
        private const int START_ANGLE_T5 = 240;
        private const int START_ANGLE_T6 = 360;

        private const int COUNT_CYLINDER_ENGINE = 6;
        private const int FIRST_CYLINDER = 0;
        private const int SECOND_CYLINDER = 1;
        private const int THIRD_CYLINDER = 2;
        private const int FOURTH_CYLINDER = 3;
        private const int FIFTH_CYLINDER = 4;
        private const int SIXTH_CYLINDER = 5;
        private const int SHIFT_ELEM_CONTROL = 50;

        private List<CalcSpecificForces> CalcSpecificForcesOfCylinders { get; set; } = new List<CalcSpecificForces>();
        private List<FormDiagramProcessOfCylinder> FormsCylinderProcesses { get; set; } = new List<FormDiagramProcessOfCylinder>();
        private List<double> TotalTorqueOfCylinders { get; set; } = new List<double>(); // обертальні моменти двигунів

        public Main()
        {
            InitializeComponent();
            this.btnDrawDiagram.Select();
            this.chartTotalToque.ChartAreas[0].AxisX.Title = "\u03c6";
            this.chartTotalToque.ChartAreas[0].AxisY.Title = "M";
        }

        private void btnDrawDiagram_Click(object sender, EventArgs e)
        {
            //закрываем и очищаем предыдущие окна рассчетов
            ResetOldCalcFormProcess();

            for (int i = 0; i < COUNT_CYLINDER_ENGINE; i++)
            {
                FormDiagramProcessOfCylinder formCreateDiagramProcess = new FormDiagramProcessOfCylinder();
                
                FormsCylinderProcesses.Add(formCreateDiagramProcess);
                formCreateDiagramProcess.Text += " " + (i + 1);
                formCreateDiagramProcess.LabelDataForCreateDiagr.Text += " " + (i + 1) + "-го " + "циліндра.";
                CalcSpecificForcesOfCylinders.Add(formCreateDiagramProcess.CalcSpecificForces);
                formCreateDiagramProcess.Show();
            }
        }

        private void ResetOldCalcFormProcess()
        {
            if(FormsCylinderProcesses.Count > 0)
            {
                FormsCylinderProcesses.ForEach(form => form.Close());
            }
            FormsCylinderProcesses.Clear();
        }

        private void btnTotalTorqueEngine_Click(object sender, EventArgs e)
        {
            //checked calculation data for cylinder
            if(CalcSpecificForcesOfCylinders.Count == 0)
            {
                MessageBox.Show("Дані для циліндрів не були розраховані.");
                return;
            }
            //minimize other windows
            foreach (var formCylinderProc in FormsCylinderProcesses)
            {
                if(formCylinderProc != null)
                {
                    formCylinderProc.WindowState = FormWindowState.Minimized;
                }
            } 

            //check - are calculated data for all cylinders
            for (int i = 0; i < CalcSpecificForcesOfCylinders.Count; i++)
            {
                if (CalcSpecificForcesOfCylinders[i] == null || CalcSpecificForcesOfCylinders[i].DataSpecificForces == null || //данные существуют
                    (FormsCylinderProcesses[i].TaskCalcSpecificForces != null && !FormsCylinderProcesses[i].TaskCalcSpecificForces.IsCompleted)) //данные вычислены полностью
                {
                    DialogResult dialogResult = MessageBox.Show("Дані для циліндра " + (i + 1) + " не були розраховані.");
                    if(dialogResult == DialogResult.OK)
                    {
                        this.WindowState = FormWindowState.Minimized;
                        if (FormsCylinderProcesses[i] != null)
                        {
                            FormsCylinderProcesses[i].WindowState = FormWindowState.Normal;
                        }                        
                    }
                    return;
                }
            }
            //очистити таблицю выд старих питомі сили циліндрів та сумарний обертальний момент двигуна
            FormDiagramProcessOfCylinder.ClearGridView(dataGridView_TiAndMi);
            //показати питомі сили циліндрів та сумарний обертальний момент двигуна
            ShowSpecificForcesAndTorqueEngineOnGridView(dataGridView_TiAndMi);
            //очистити графік залежності обертального моменту від кута 
            FormDiagramProcessOfCylinder.ClearChart(chartTotalToque);
            //побудувати графік залежності обертального моменту від кута
            BuildChartTotalToque(chartTotalToque);
        }

        private void BuildChartTotalToque(Chart chartTotalToque)
        {
            for (int angle = CalcSpecificForces.START_ANGLE, iterTotalTorque=0; 
                angle <= CalcSpecificForces.END_ANGLE && iterTotalTorque < TotalTorqueOfCylinders.Count;
                angle += FormsCylinderProcesses[FIRST_CYLINDER].DeltaAngle, iterTotalTorque++)
            {
                chartTotalToque.Series[0].Points.AddXY(angle, TotalTorqueOfCylinders[iterTotalTorque]);
            }
        }

        private void ShowSpecificForcesAndTorqueEngineOnGridView(DataGridView dataGridView)
        {
            // remove records in calculations of data specific forces with first angle == 360, and left next record with 360(left record with pressure expansion)
            CalcSpecificForcesOfCylinders.ForEach(calcSpecForces =>
            {
                int indexRecordWith360Degree = calcSpecForces.DataSpecificForces.Angles.BinarySearch(360);
                if(calcSpecForces.DataSpecificForces.Angles[indexRecordWith360Degree]+1 == 360) // data for 360 degree was remmoved
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
            for (int iterT = 0; iterT < lengthInternalObjectsInDataSpecForces; iterT++) // go along DataSpecificForces for get T of differentcylinder
            {
                double T1 = CalcSpecificForcesOfCylinders[FIRST_CYLINDER].DataSpecificForces.T[bearingIndexT1];
                double T2 = CalcSpecificForcesOfCylinders[SECOND_CYLINDER].DataSpecificForces.T[bearingIndexT2];
                double T3 = CalcSpecificForcesOfCylinders[THIRD_CYLINDER].DataSpecificForces.T[bearingIndexT3];
                double T4 = CalcSpecificForcesOfCylinders[FOURTH_CYLINDER].DataSpecificForces.T[bearingIndexT4];
                double T5 = CalcSpecificForcesOfCylinders[FIFTH_CYLINDER].DataSpecificForces.T[bearingIndexT5];
                double T6 = CalcSpecificForcesOfCylinders[SIXTH_CYLINDER].DataSpecificForces.T[bearingIndexT6];
                double Tsum = Round(T1 + T2 + T3 + T4 + T5 + T6, 3);
                //Mi = 1000 * TSum * Fn * R
                double totalTorque = Round(1000 * Tsum * FormsCylinderProcesses[FIRST_CYLINDER].CalcPolitrops.Fn * CalcPolitrops.R, 3);
                TotalTorqueOfCylinders.Add(totalTorque);

                dataGridView.Rows.Add(T1, T2, T3, T4, T5, T6, Tsum, totalTorque);
                //increase index
                bearingIndexT1++;
                bearingIndexT2++;
                bearingIndexT3++;
                bearingIndexT4++;
                bearingIndexT5++;
                bearingIndexT6++;

                if (bearingIndexT1 == lengthInternalObjectsInDataSpecForces) //index in end - go from start
                {
                    bearingIndexT1 = 0;
                }

                if (bearingIndexT2 == lengthInternalObjectsInDataSpecForces) //index in end - go from start
                {
                    bearingIndexT2 = 0;
                }

                if (bearingIndexT3 == lengthInternalObjectsInDataSpecForces) //index in end - go from start
                {
                    bearingIndexT3 = 0;
                }

                if (bearingIndexT4 == lengthInternalObjectsInDataSpecForces) //index in end - go from start
                {
                    bearingIndexT4 = 0;
                }

                if (bearingIndexT5 == lengthInternalObjectsInDataSpecForces) //index in end - go from start
                {
                    bearingIndexT5 = 0;
                }

                if (bearingIndexT6 == lengthInternalObjectsInDataSpecForces) //index in end - go from start
                {
                    bearingIndexT6 = 0;
                }
            }
            FormDiagramProcessOfCylinder.AutosizeGridView(dataGridView);
        }

        private void dataGridView_TiAndMi_Resize(object sender, EventArgs e)
        {
            chartTotalToque.Top = dataGridView_TiAndMi.Bottom + SHIFT_ELEM_CONTROL;
        }
    }
}
