﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mechanic
{
    public partial class FormCreateDiagramProcess : Form
    {
        private const int WAITING_EXECUTE_CALCULATING = 10; // wait on execute calc data in milisec
        private const int SHIFT_OF_ELEM = 100;
        private CalcPolitrops calcPolitrops = new CalcPolitrops(
            new DataPolitropsOfComprassionAndExpansion());
        private Task TaskCalcPolitropData { get; set; } = null;

        public int NumberOfCylinder { get; set; } = 0;


        public FormCreateDiagramProcess()
        {
            InitializeComponent();
            timer.Interval = WAITING_EXECUTE_CALCULATING;
            this.label_Pc.Text = "Pc:  " + calcPolitrops.PC.ToString();
        }

        private void btnCalcAndBuildDiagr_Click(object sender, EventArgs e)
        {
            // clear data in grid view
            ClearGridView(this.dataGridView_Politrop);

            if (calcPolitrops.CancellationTokenSource != null)
            {
                calcPolitrops.CancellationTokenSource.Cancel();
            }

            double n1 = double.Parse(textBox_N1_IndicPolitrCompres.Text);
            try
            {
                calcPolitrops.N1 = n1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Помилка в заданому значенні", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            double n2 = double.Parse(textBox_N2_IndicPolitrExpansion.Text); ;
            try
            {
                calcPolitrops.N2 = n2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Помилка в заданому значенні", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double lambdaDegreeIncreasePressure = double.Parse(textBox_Lambda_DegreeOfPressureIncrease.Text);
            try
            {
                calcPolitrops.LambdaDegreeIncreasePressure = lambdaDegreeIncreasePressure;
                label_PZ.Text = "Pz:  " + Math.Round(calcPolitrops.PZ, 3).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Помилка в заданому значенні", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int deltaAngle = int.Parse(textBox_DeltaAngle.Text);

            TaskCalcPolitropData = calcPolitrops.CalcPolitropsDataAsync(deltaAngle);
            timer.Start(); // begin calculation

        }

        private void ClearGridView(DataGridView dataGridView)
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
            if (TaskCalcPolitropData.IsCompleted)
            {
                timer.Stop();
                ShowDataPolitropOnDataGridView();
            }
        }

        private void ShowDataPolitropOnDataGridView()
        {
            // очистка старого графіка
            chart_IndicatorDiagram.Series["PolitropOfComprassion"].Points.Clear();
            chart_IndicatorDiagram.Series["PolitropOfExpansion"].Points.Clear();


            for (int iterInternalPolitrData = 0;
                 iterInternalPolitrData < calcPolitrops.DataPolitrops.LengthInternalObject;
                 iterInternalPolitrData++
                )
            {
                DataPolitropsOfComprassionAndExpansion dataPolitrop = calcPolitrops.DataPolitrops;
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

        private void AutosizeGridView(DataGridView dataGridView)
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

        private void chart_IndicatorDiagram_Resize(object sender, EventArgs e)
        {
            //placement datagridview of calc specif forcews after resize chartIndicDiagr
            this.dataGridView_CalcSpecifForces.Top = this.chart_IndicatorDiagram.Bottom + SHIFT_OF_ELEM;

        }
    }
}
