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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDrawDiagram = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTotalTorqueEngine = new System.Windows.Forms.Button();
            this.dataGridView_TiAndMi = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TiAndMi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTotalToque)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(55, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(667, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Побудова індикаторної діаграми робочого процесу двигуна ";
            // 
            // btnDrawDiagram
            // 
            this.btnDrawDiagram.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDrawDiagram.Location = new System.Drawing.Point(264, 97);
            this.btnDrawDiagram.Name = "btnDrawDiagram";
            this.btnDrawDiagram.Size = new System.Drawing.Size(194, 39);
            this.btnDrawDiagram.TabIndex = 3;
            this.btnDrawDiagram.Text = "Побудувати діаграми ";
            this.btnDrawDiagram.UseVisualStyleBackColor = true;
            this.btnDrawDiagram.Click += new System.EventHandler(this.btnDrawDiagram_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(29, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(709, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Дані для визначення сумарного обертального моменту двигуна";
            // 
            // btnTotalTorqueEngine
            // 
            this.btnTotalTorqueEngine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTotalTorqueEngine.Location = new System.Drawing.Point(260, 228);
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
            this.T1,
            this.T2,
            this.T3,
            this.T4,
            this.T5,
            this.T6,
            this.Tsum,
            this.Mi});
            this.dataGridView_TiAndMi.Location = new System.Drawing.Point(37, 306);
            this.dataGridView_TiAndMi.Name = "dataGridView_TiAndMi";
            this.dataGridView_TiAndMi.Size = new System.Drawing.Size(683, 44);
            this.dataGridView_TiAndMi.TabIndex = 6;
            this.dataGridView_TiAndMi.Resize += new System.EventHandler(this.dataGridView_TiAndMi_Resize);
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
            this.label4.Location = new System.Drawing.Point(224, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Кількість циліндрів двигуна:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(450, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "6";
            // 
            // chartTotalToque
            // 
            chartArea2.Name = "ChartArea1";
            this.chartTotalToque.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartTotalToque.Legends.Add(legend2);
            this.chartTotalToque.Location = new System.Drawing.Point(37, 367);
            this.chartTotalToque.Name = "chartTotalToque";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.LegendText = "M";
            series2.Name = "SeriesM";
            this.chartTotalToque.Series.Add(series2);
            this.chartTotalToque.Size = new System.Drawing.Size(685, 296);
            this.chartTotalToque.TabIndex = 9;
            this.chartTotalToque.Text = "chart1";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title2.Name = "Title1";
            title2.Text = "Сумарний обертальний момент дизеля";
            this.chartTotalToque.Titles.Add(title2);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(786, 675);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn T1;
        private System.Windows.Forms.DataGridViewTextBoxColumn T2;
        private System.Windows.Forms.DataGridViewTextBoxColumn T3;
        private System.Windows.Forms.DataGridViewTextBoxColumn T4;
        private System.Windows.Forms.DataGridViewTextBoxColumn T5;
        private System.Windows.Forms.DataGridViewTextBoxColumn T6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tsum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mi;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTotalToque;
    }
}

