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
    public partial class Main : Form
    {       

        public Main()
        {
            InitializeComponent();
            this.btnDrawDiagram.Select();
        }       

        private void btnDrawDiagram_Click(object sender, EventArgs e)
        {
            int quantOfCylinder = int.Parse(comboBoxQuantCylinder.Text);

            for (int i = 0; i < quantOfCylinder; i++)
            {
                FormCreateDiagramProcess formCreateDiagramProcess = new FormCreateDiagramProcess();
                formCreateDiagramProcess.NumberOfCylinder = i + 1;
                formCreateDiagramProcess.Show();
            }            
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
