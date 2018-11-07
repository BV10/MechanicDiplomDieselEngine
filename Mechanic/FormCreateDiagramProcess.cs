using System;
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

        private CalcPolitropsOfComprassionAndExpansion calcPolitrops = new CalcPolitropsOfComprassionAndExpansion(
            new DataPolitropsOfComprassionAndExpansion());
        private Task TaskCalcPolitropData { get; set; } = null;

        public int NumberOfCylinder { get; set; } = 0;


        public FormCreateDiagramProcess()
        {
            InitializeComponent();
            timer.Interval = WAITING_EXECUTE_CALCULATING;
        }

        private void btnCalcAndBuildDiagr_Click(object sender, EventArgs e)
        {
            // clear data in grid view
            if (dataGridView_Politrop.RowCount > 1)
            {
                for (int i = dataGridView_Politrop.RowCount - 2; i >= 0; i--)
                {
                    dataGridView_Politrop.Rows.RemoveAt(i);
                }
                dataGridView_Politrop.Refresh();
            }

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
            
            int deltaAngle = int.Parse(textBox_DeltaAngle.Text);

            TaskCalcPolitropData = calcPolitrops.CalcPolitropsDataAsync(deltaAngle);
            timer.Start(); // begin calculation

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
                    dataPolitrop.RatioVzToV[iterInternalPolitrData],
                    dataPolitrop.RatioVzToVInDegreeN2[iterInternalPolitrData],
                    dataPolitrop.PressureOnLineExpansion[iterInternalPolitrData]
                    );
            }

            // autosize height
            var height = 40;
            foreach (DataGridViewRow dr in dataGridView_Politrop.Rows)
            {
                height += dr.Height;
            }

            dataGridView_Politrop.Height = height;
        }
    }
}
