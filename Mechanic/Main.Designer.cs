﻿namespace Mechanic
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDrawDiagram = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTotalTorqueEngine = new System.Windows.Forms.Button();
            this.dataGridView_TiAndMi = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chartTotalToque = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView_TorqueUniformity = new System.Windows.Forms.DataGridView();
            this.numberOfCylinder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.T1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.T2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.T3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.T4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.T5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.T6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tsum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TiAndMi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTotalToque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TorqueUniformity)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(171, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(667, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Побудова індикаторної діаграми робочого процесу двигуна ";
            // 
            // btnDrawDiagram
            // 
            this.btnDrawDiagram.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDrawDiagram.Location = new System.Drawing.Point(380, 101);
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
            this.label3.Location = new System.Drawing.Point(145, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(709, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Дані для визначення сумарного обертального моменту двигуна";
            // 
            // btnTotalTorqueEngine
            // 
            this.btnTotalTorqueEngine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTotalTorqueEngine.Location = new System.Drawing.Point(376, 232);
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
            this.dataGridView_TiAndMi.Location = new System.Drawing.Point(153, 310);
            this.dataGridView_TiAndMi.Name = "dataGridView_TiAndMi";
            this.dataGridView_TiAndMi.Size = new System.Drawing.Size(783, 44);
            this.dataGridView_TiAndMi.TabIndex = 6;
            this.dataGridView_TiAndMi.Resize += new System.EventHandler(this.dataGridView_TiAndMi_Resize);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(340, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Кількість циліндрів двигуна:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(566, 62);
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
            legendCell1.ForeColor = System.Drawing.Color.Blue;
            legendCell1.Name = "Cell1";
            legendCell1.Text = "1-ий циліндр";
            legendItem1.Cells.Add(legendCell1);
            legendCell2.ForeColor = System.Drawing.Color.Green;
            legendCell2.Name = "Cell1";
            legendCell2.Text = "2-ий циліндр";
            legendItem2.Cells.Add(legendCell2);
            legendCell3.ForeColor = System.Drawing.Color.Aqua;
            legendCell3.Name = "Cell1";
            legendCell3.Text = "3-ій циліндр";
            legendItem3.Cells.Add(legendCell3);
            legendCell4.ForeColor = System.Drawing.Color.Red;
            legendCell4.Name = "Cell1";
            legendCell4.Text = "4-ий циліндр";
            legendItem4.Cells.Add(legendCell4);
            legendCell5.ForeColor = System.Drawing.Color.Violet;
            legendCell5.Name = "Cell1";
            legendCell5.Text = "5-ий циліндр";
            legendItem5.Cells.Add(legendCell5);
            legendCell6.ForeColor = System.Drawing.Color.Brown;
            legendCell6.Name = "Cell1";
            legendCell6.Text = "6-ий циліндр";
            legendItem6.Cells.Add(legendCell6);
            legend1.CustomItems.Add(legendItem1);
            legend1.CustomItems.Add(legendItem2);
            legend1.CustomItems.Add(legendItem3);
            legend1.CustomItems.Add(legendItem4);
            legend1.CustomItems.Add(legendItem5);
            legend1.CustomItems.Add(legendItem6);
            legend1.Name = "Legend1";
            this.chartTotalToque.Legends.Add(legend1);
            this.chartTotalToque.Location = new System.Drawing.Point(36, 371);
            this.chartTotalToque.Name = "chartTotalToque";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.LegendText = "M";
            series1.Name = "SeriesM";
            this.chartTotalToque.Series.Add(series1);
            this.chartTotalToque.Size = new System.Drawing.Size(946, 296);
            this.chartTotalToque.TabIndex = 9;
            this.chartTotalToque.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.Name = "Title1";
            title1.Text = "Сумарний обертальний момент дизеля";
            this.chartTotalToque.Titles.Add(title1);
            this.chartTotalToque.Customize += new System.EventHandler(this.chartTotalToque_Customize);
            this.chartTotalToque.Move += new System.EventHandler(this.chartTotalToque_Move);
            // 
            // dataGridView_TorqueUniformity
            // 
            this.dataGridView_TorqueUniformity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_TorqueUniformity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberOfCylinder,
            this.mMax,
            this.mMin,
            this.Mu});
            this.dataGridView_TorqueUniformity.Location = new System.Drawing.Point(326, 694);
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1006, 747);
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
    }
}

