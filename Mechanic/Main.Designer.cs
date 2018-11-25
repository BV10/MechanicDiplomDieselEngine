using System.Windows.Forms;

namespace Mechanic
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem1 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.LegendCell legendCell1 = new System.Windows.Forms.DataVisualization.Charting.LegendCell();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem2 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.LegendCell legendCell2 = new System.Windows.Forms.DataVisualization.Charting.LegendCell();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem3 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.LegendCell legendCell3 = new System.Windows.Forms.DataVisualization.Charting.LegendCell();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem4 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.LegendCell legendCell4 = new System.Windows.Forms.DataVisualization.Charting.LegendCell();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem5 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.LegendCell legendCell5 = new System.Windows.Forms.DataVisualization.Charting.LegendCell();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem6 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.LegendCell legendCell6 = new System.Windows.Forms.DataVisualization.Charting.LegendCell();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem7 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.LegendCell legendCell7 = new System.Windows.Forms.DataVisualization.Charting.LegendCell();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDrawDiagram = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTotalTorqueEngine = new System.Windows.Forms.Button();
            this.dataGridView_TiAndMi = new System.Windows.Forms.DataGridView();
            this.Phi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.T1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.T2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.T3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.T4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.T5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.T6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tsum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chartTotalToque = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView_TorqueUniformity = new System.Windows.Forms.DataGridView();
            this.numberOfCylinder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Pk = new System.Windows.Forms.TextBox();
            this.label_N1OfCylind1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.dataGridView_DataForDiagram = new System.Windows.Forms.DataGridView();
            this.numbCylinder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lambda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etaI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etaE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TiAndMi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTotalToque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TorqueUniformity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DataForDiagram)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(301, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(667, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Побудова індикаторної діаграми робочого процесу двигуна ";
            // 
            // btnDrawDiagram
            // 
            this.btnDrawDiagram.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDrawDiagram.Location = new System.Drawing.Point(472, 560);
            this.btnDrawDiagram.Name = "btnDrawDiagram";
            this.btnDrawDiagram.Size = new System.Drawing.Size(194, 52);
            this.btnDrawDiagram.TabIndex = 3;
            this.btnDrawDiagram.Text = "Побудувати діаграми та розрахувати дані";
            this.btnDrawDiagram.UseVisualStyleBackColor = true;
            this.btnDrawDiagram.Click += new System.EventHandler(this.btnDrawDiagram_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(208, 633);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(709, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Дані для визначення сумарного обертального моменту двигуна";
            // 
            // btnTotalTorqueEngine
            // 
            this.btnTotalTorqueEngine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTotalTorqueEngine.Location = new System.Drawing.Point(466, 688);
            this.btnTotalTorqueEngine.Name = "btnTotalTorqueEngine";
            this.btnTotalTorqueEngine.Size = new System.Drawing.Size(205, 52);
            this.btnTotalTorqueEngine.TabIndex = 5;
            this.btnTotalTorqueEngine.Text = "Розрахувати дані та побудувати графік";
            this.btnTotalTorqueEngine.UseVisualStyleBackColor = true;
            this.btnTotalTorqueEngine.Click += new System.EventHandler(this.btnTotalTorqueEngine_Click);
            // 
            // dataGridView_TiAndMi
            // 
            this.dataGridView_TiAndMi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_TiAndMi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Phi,
            this.T1,
            this.T2,
            this.T3,
            this.T4,
            this.T5,
            this.T6,
            this.Tsum,
            this.Mi});
            this.dataGridView_TiAndMi.Location = new System.Drawing.Point(185, 751);
            this.dataGridView_TiAndMi.Name = "dataGridView_TiAndMi";
            this.dataGridView_TiAndMi.Size = new System.Drawing.Size(783, 44);
            this.dataGridView_TiAndMi.TabIndex = 6;
            this.dataGridView_TiAndMi.Resize += new System.EventHandler(this.dataGridView_TiAndMi_Resize);
            // 
            // Phi
            // 
            this.Phi.HeaderText = "φ";
            this.Phi.Name = "Phi";
            // 
            // T1
            // 
            this.T1.HeaderText = "T1";
            this.T1.Name = "T1";
            this.T1.Width = 80;
            // 
            // T2
            // 
            this.T2.HeaderText = "T2";
            this.T2.Name = "T2";
            this.T2.Width = 80;
            // 
            // T3
            // 
            this.T3.HeaderText = "T3";
            this.T3.Name = "T3";
            this.T3.Width = 80;
            // 
            // T4
            // 
            this.T4.HeaderText = "T4";
            this.T4.Name = "T4";
            this.T4.Width = 80;
            // 
            // T5
            // 
            this.T5.HeaderText = "T5";
            this.T5.Name = "T5";
            this.T5.Width = 80;
            // 
            // T6
            // 
            this.T6.HeaderText = "T6";
            this.T6.Name = "T6";
            this.T6.Width = 80;
            // 
            // Tsum
            // 
            this.Tsum.HeaderText = "ΣT";
            this.Tsum.Name = "Tsum";
            this.Tsum.Width = 80;
            // 
            // Mi
            // 
            this.Mi.HeaderText = "Mᵢ";
            this.Mi.Name = "Mi";
            this.Mi.Width = 80;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(443, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Кількість циліндрів двигуна:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(676, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "6";
            // 
            // chartTotalToque
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTotalToque.ChartAreas.Add(chartArea1);
            legendCell1.BackColor = System.Drawing.Color.Transparent;
            legendCell1.ForeColor = System.Drawing.Color.Red;
            legendCell1.Name = "Cell1";
            legendCell1.Text = "1-ий циліндр";
            legendItem1.Cells.Add(legendCell1);
            legendCell2.ForeColor = System.Drawing.Color.Aqua;
            legendCell2.Name = "Cell1";
            legendCell2.Text = "2-ий циліндр";
            legendItem2.Cells.Add(legendCell2);
            legendCell3.ForeColor = System.Drawing.Color.Violet;
            legendCell3.Name = "Cell1";
            legendCell3.Text = "3-ій циліндр";
            legendItem3.Cells.Add(legendCell3);
            legendCell4.ForeColor = System.Drawing.Color.Green;
            legendCell4.Name = "Cell1";
            legendCell4.Text = "4-ий циліндр";
            legendItem4.Cells.Add(legendCell4);
            legendCell5.ForeColor = System.Drawing.Color.Brown;
            legendCell5.Name = "Cell1";
            legendCell5.Text = "5-ий циліндр";
            legendItem5.Cells.Add(legendCell5);
            legendCell6.ForeColor = System.Drawing.Color.Blue;
            legendCell6.Name = "Cell1";
            legendCell6.Text = "6-ий циліндр";
            legendItem6.Cells.Add(legendCell6);
            legendCell7.ForeColor = System.Drawing.Color.Black;
            legendCell7.Name = "Cell1";
            legendCell7.Text = "Ідеальна робота двигуна";
            legendItem7.Cells.Add(legendCell7);
            legend1.CustomItems.Add(legendItem1);
            legend1.CustomItems.Add(legendItem2);
            legend1.CustomItems.Add(legendItem3);
            legend1.CustomItems.Add(legendItem4);
            legend1.CustomItems.Add(legendItem5);
            legend1.CustomItems.Add(legendItem6);
            legend1.CustomItems.Add(legendItem7);
            legend1.Name = "Legend1";
            this.chartTotalToque.Legends.Add(legend1);
            this.chartTotalToque.Location = new System.Drawing.Point(84, 746);
            this.chartTotalToque.Name = "chartTotalToque";
            this.chartTotalToque.Size = new System.Drawing.Size(946, 296);
            this.chartTotalToque.TabIndex = 9;
            this.chartTotalToque.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.Name = "Title1";
            title1.Text = "Сумарний обертальний момент дизеля";
            this.chartTotalToque.Titles.Add(title1);
            this.chartTotalToque.Customize += new System.EventHandler(this.chartTotalToque_Customize);
            // 
            // dataGridView_TorqueUniformity
            // 
            this.dataGridView_TorqueUniformity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_TorqueUniformity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberOfCylinder,
            this.mMax,
            this.mMin,
            this.Mu});
            this.dataGridView_TorqueUniformity.Location = new System.Drawing.Point(383, 813);
            this.dataGridView_TorqueUniformity.Name = "dataGridView_TorqueUniformity";
            this.dataGridView_TorqueUniformity.Size = new System.Drawing.Size(323, 45);
            this.dataGridView_TorqueUniformity.TabIndex = 10;
            // 
            // numberOfCylinder
            // 
            this.numberOfCylinder.HeaderText = "№ циліндра";
            this.numberOfCylinder.Name = "numberOfCylinder";
            // 
            // mMax
            // 
            this.mMax.HeaderText = "Mₘₐₓ";
            this.mMax.Name = "mMax";
            this.mMax.Width = 60;
            // 
            // mMin
            // 
            this.mMin.HeaderText = "Mₘᵢₙ";
            this.mMin.Name = "mMin";
            this.mMin.Width = 60;
            // 
            // Mu
            // 
            this.Mu.HeaderText = "μ";
            this.Mu.Name = "Mu";
            this.Mu.Width = 60;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(516, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Pk :";
            // 
            // textBox_Pk
            // 
            this.textBox_Pk.Location = new System.Drawing.Point(558, 92);
            this.textBox_Pk.Name = "textBox_Pk";
            this.textBox_Pk.Size = new System.Drawing.Size(74, 20);
            this.textBox_Pk.TabIndex = 12;
            this.textBox_Pk.Text = "0,142";
            // 
            // label_N1OfCylind1
            // 
            this.label_N1OfCylind1.AutoSize = true;
            this.label_N1OfCylind1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_N1OfCylind1.Location = new System.Drawing.Point(443, 129);
            this.label_N1OfCylind1.Name = "label_N1OfCylind1";
            this.label_N1OfCylind1.Size = new System.Drawing.Size(366, 16);
            this.label_N1OfCylind1.TabIndex = 13;
            this.label_N1OfCylind1.Text = "середній показник політропи стиснення (n1 = 1.36...1.38)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(443, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(190, 16);
            this.label10.TabIndex = 31;
            this.label10.Text = "ступінь підвищення тиску(λ)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(443, 156);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(378, 16);
            this.label15.TabIndex = 36;
            this.label15.Text = "середній показник політропи розширення (n2 = 1.26...1.28)";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label25.Location = new System.Drawing.Point(409, 129);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(28, 16);
            this.label25.TabIndex = 55;
            this.label25.Text = "n1:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label26.Location = new System.Drawing.Point(409, 156);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(28, 16);
            this.label26.TabIndex = 56;
            this.label26.Text = "n2:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label28.Location = new System.Drawing.Point(409, 210);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(26, 16);
            this.label28.TabIndex = 58;
            this.label28.Text = "Nᵢ:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label29.Location = new System.Drawing.Point(409, 184);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(21, 16);
            this.label29.TabIndex = 59;
            this.label29.Text = "λ:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label30.Location = new System.Drawing.Point(409, 237);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(23, 16);
            this.label30.TabIndex = 60;
            this.label30.Text = "ηᵢ:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label31.Location = new System.Drawing.Point(406, 289);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(30, 16);
            this.label31.TabIndex = 62;
            this.label31.Text = " ηₑ:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label32.Location = new System.Drawing.Point(409, 264);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(29, 16);
            this.label32.TabIndex = 61;
            this.label32.Text = "Nₑ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(410, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 16);
            this.label6.TabIndex = 63;
            this.label6.Text = "bₑ:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(443, 210);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(228, 16);
            this.label11.TabIndex = 64;
            this.label11.Text = "індиккаторна потужність двигуна";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(443, 237);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 16);
            this.label12.TabIndex = 65;
            this.label12.Text = "індикаторний КПД";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label33.Location = new System.Drawing.Point(443, 264);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(156, 16);
            this.label33.TabIndex = 66;
            this.label33.Text = "ефективна потужність";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label34.Location = new System.Drawing.Point(443, 314);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(243, 16);
            this.label34.TabIndex = 67;
            this.label34.Text = "ефективна питома витрата палива ";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label35.Location = new System.Drawing.Point(443, 289);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(119, 16);
            this.label35.TabIndex = 68;
            this.label35.Text = "ефективний КПД";
            // 
            // dataGridView_DataForDiagram
            // 
            this.dataGridView_DataForDiagram.AllowUserToAddRows = false;
            this.dataGridView_DataForDiagram.AllowUserToDeleteRows = false;
            this.dataGridView_DataForDiagram.AllowUserToResizeColumns = false;
            this.dataGridView_DataForDiagram.AllowUserToResizeRows = false;
            this.dataGridView_DataForDiagram.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DataForDiagram.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numbCylinder,
            this.n1,
            this.n2,
            this.lambda,
            this.Ni,
            this.etaI,
            this.Ne,
            this.etaE,
            this.bE});
            this.dataGridView_DataForDiagram.Location = new System.Drawing.Point(103, 358);
            this.dataGridView_DataForDiagram.Name = "dataGridView_DataForDiagram";
            this.dataGridView_DataForDiagram.Size = new System.Drawing.Size(873, 47);
            this.dataGridView_DataForDiagram.TabIndex = 69;
            // 
            // numbCylinder
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.numbCylinder.DefaultCellStyle = dataGridViewCellStyle1;
            this.numbCylinder.HeaderText = "№";
            this.numbCylinder.Name = "numbCylinder";
            this.numbCylinder.ReadOnly = true;
            this.numbCylinder.Width = 30;
            // 
            // n1
            // 
            this.n1.HeaderText = "n1";
            this.n1.Name = "n1";
            // 
            // n2
            // 
            this.n2.HeaderText = "n2";
            this.n2.Name = "n2";
            // 
            // lambda
            // 
            this.lambda.HeaderText = "λ";
            this.lambda.Name = "lambda";
            // 
            // Ni
            // 
            this.Ni.HeaderText = "Nᵢ";
            this.Ni.Name = "Ni";
            this.Ni.ReadOnly = true;
            // 
            // etaI
            // 
            this.etaI.HeaderText = "ηᵢ";
            this.etaI.Name = "etaI";
            this.etaI.ReadOnly = true;
            // 
            // Ne
            // 
            this.Ne.HeaderText = "Nₑ";
            this.Ne.Name = "Ne";
            this.Ne.ReadOnly = true;
            // 
            // etaE
            // 
            this.etaE.HeaderText = "ηₑ";
            this.etaE.Name = "etaE";
            this.etaE.ReadOnly = true;
            // 
            // bE
            // 
            this.bE.HeaderText = "bₑ";
            this.bE.Name = "bE";
            this.bE.ReadOnly = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1184, 881);
            this.Controls.Add(this.dataGridView_DataForDiagram);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label_N1OfCylind1);
            this.Controls.Add(this.textBox_Pk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView_TorqueUniformity);
            this.Controls.Add(this.chartTotalToque);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView_TiAndMi);
            this.Controls.Add(this.btnTotalTorqueEngine);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDrawDiagram);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Двигуни внутрішнього згоряння";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TiAndMi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTotalToque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TorqueUniformity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DataForDiagram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDrawDiagram;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTotalTorqueEngine;
        private System.Windows.Forms.DataGridView dataGridView_TiAndMi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTotalToque;
        private System.Windows.Forms.DataGridView dataGridView_TorqueUniformity;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfCylinder;
        private System.Windows.Forms.DataGridViewTextBoxColumn mMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn mMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phi;
        private System.Windows.Forms.DataGridViewTextBoxColumn T1;
        private System.Windows.Forms.DataGridViewTextBoxColumn T2;
        private System.Windows.Forms.DataGridViewTextBoxColumn T3;
        private System.Windows.Forms.DataGridViewTextBoxColumn T4;
        private System.Windows.Forms.DataGridViewTextBoxColumn T5;
        private System.Windows.Forms.DataGridViewTextBoxColumn T6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tsum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Pk;
        private System.Windows.Forms.Label label_N1OfCylind1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.DataGridView dataGridView_DataForDiagram;
        private System.Windows.Forms.DataGridViewTextBoxColumn numbCylinder;
        private System.Windows.Forms.DataGridViewTextBoxColumn n1;
        private System.Windows.Forms.DataGridViewTextBoxColumn n2;
        private System.Windows.Forms.DataGridViewTextBoxColumn lambda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ni;
        private System.Windows.Forms.DataGridViewTextBoxColumn etaI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ne;
        private System.Windows.Forms.DataGridViewTextBoxColumn etaE;
        private System.Windows.Forms.DataGridViewTextBoxColumn bE;

        public DataGridView DataGridView_DataForDiagram { get => dataGridView_DataForDiagram; set => dataGridView_DataForDiagram = value; }
    }
}

