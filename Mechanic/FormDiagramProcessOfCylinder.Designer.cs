using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Mechanic
{
    partial class FormDiagramProcessOfCylinder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalcAndBuildDiagr = new System.Windows.Forms.Button();
            this.textBox_N1_IndicPolitrCompres = new System.Windows.Forms.TextBox();
            this.labelDataForCreateDiagr = new System.Windows.Forms.Label();
            this.textBox_N2_IndicPolitrExpansion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Lambda_DegreeOfPressureIncrease = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView_Politrop = new System.Windows.Forms.DataGridView();
            this.degree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pistonMovement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.multiplyMovementAndF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volumeOfCylinder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attitudeVolumesVaToV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attitudeVolumeVaToVInPower = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pressureOnLineCompression = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attitudeVolumeVToVz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attitudeVolumeInPowerVToVz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pressureOnLineExpansion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label_Pc = new System.Windows.Forms.Label();
            this.label_PZ = new System.Windows.Forms.Label();
            this.chart_IndicatorDiagram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView_CalcSpecifForces = new System.Windows.Forms.DataGridView();
            this.angle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pressureOnPiston_P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specificPressureOnPiston_Pr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accelerationOfPiston_J = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgBeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cosBeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinPhiOnCosBeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.T = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cosPhiPlusBetaOnCosBeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Z = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartOfSpecificForcesP = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartOfSpecificForces_KAndN = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartOfSpecificForces_TAndZ = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartOfGasPressureOnPistonFromAngle = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label_AnalyticPip = new System.Windows.Forms.Label();
            this.label_GraphicPip = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Politrop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_IndicatorDiagram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CalcSpecifForces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOfSpecificForcesP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOfSpecificForces_KAndN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOfSpecificForces_TAndZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOfGasPressureOnPistonFromAngle)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(157, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Середній показник політропи стиснення (n1 = 1.36...1.38) :\r\n";
            // 
            // btnCalcAndBuildDiagr
            // 
            this.btnCalcAndBuildDiagr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCalcAndBuildDiagr.Location = new System.Drawing.Point(749, 77);
            this.btnCalcAndBuildDiagr.Name = "btnCalcAndBuildDiagr";
            this.btnCalcAndBuildDiagr.Size = new System.Drawing.Size(204, 45);
            this.btnCalcAndBuildDiagr.TabIndex = 1;
            this.btnCalcAndBuildDiagr.Text = "Розрахувати та побудувати діаграму";
            this.btnCalcAndBuildDiagr.UseVisualStyleBackColor = true;
            this.btnCalcAndBuildDiagr.Click += new System.EventHandler(this.btnCalcAndBuildDiagr_Click);
            // 
            // textBox_N1_IndicPolitrCompres
            // 
            this.textBox_N1_IndicPolitrCompres.Location = new System.Drawing.Point(550, 68);
            this.textBox_N1_IndicPolitrCompres.Name = "textBox_N1_IndicPolitrCompres";
            this.textBox_N1_IndicPolitrCompres.Size = new System.Drawing.Size(90, 20);
            this.textBox_N1_IndicPolitrCompres.TabIndex = 2;
            this.textBox_N1_IndicPolitrCompres.Text = "1,37";
            // 
            // labelDataForCreateDiagr
            // 
            this.labelDataForCreateDiagr.AutoSize = true;
            this.labelDataForCreateDiagr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDataForCreateDiagr.Location = new System.Drawing.Point(285, 22);
            this.labelDataForCreateDiagr.Name = "labelDataForCreateDiagr";
            this.labelDataForCreateDiagr.Size = new System.Drawing.Size(289, 24);
            this.labelDataForCreateDiagr.TabIndex = 3;
            this.labelDataForCreateDiagr.Text = "Дані для побудови діаграми";
            // 
            // textBox_N2_IndicPolitrExpansion
            // 
            this.textBox_N2_IndicPolitrExpansion.Location = new System.Drawing.Point(550, 105);
            this.textBox_N2_IndicPolitrExpansion.Name = "textBox_N2_IndicPolitrExpansion";
            this.textBox_N2_IndicPolitrExpansion.Size = new System.Drawing.Size(90, 20);
            this.textBox_N2_IndicPolitrExpansion.TabIndex = 7;
            this.textBox_N2_IndicPolitrExpansion.Text = "1,27";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(157, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(386, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Середній показник політропи розширення (n2 = 1.26...1.28) :\r\n";
            // 
            // textBox_Lambda_DegreeOfPressureIncrease
            // 
            this.textBox_Lambda_DegreeOfPressureIncrease.Location = new System.Drawing.Point(550, 139);
            this.textBox_Lambda_DegreeOfPressureIncrease.Name = "textBox_Lambda_DegreeOfPressureIncrease";
            this.textBox_Lambda_DegreeOfPressureIncrease.Size = new System.Drawing.Size(90, 20);
            this.textBox_Lambda_DegreeOfPressureIncrease.TabIndex = 9;
            this.textBox_Lambda_DegreeOfPressureIncrease.Text = "1,5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(157, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ступінь підвищення тиску(λ) :\r\n";
            // 
            // dataGridView_Politrop
            // 
            this.dataGridView_Politrop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Politrop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.degree,
            this.pistonMovement,
            this.multiplyMovementAndF,
            this.volumeOfCylinder,
            this.attitudeVolumesVaToV,
            this.attitudeVolumeVaToVInPower,
            this.pressureOnLineCompression,
            this.attitudeVolumeVToVz,
            this.attitudeVolumeInPowerVToVz,
            this.pressureOnLineExpansion});
            this.dataGridView_Politrop.Location = new System.Drawing.Point(108, 205);
            this.dataGridView_Politrop.Name = "dataGridView_Politrop";
            this.dataGridView_Politrop.Size = new System.Drawing.Size(1044, 47);
            this.dataGridView_Politrop.TabIndex = 10;
            this.dataGridView_Politrop.Resize += new System.EventHandler(this.dataGridView_Politrop_Resize);
            // 
            // degree
            // 
            this.degree.HeaderText = "φ";
            this.degree.Name = "degree";
            this.degree.ReadOnly = true;
            // 
            // pistonMovement
            // 
            this.pistonMovement.HeaderText = "S, м";
            this.pistonMovement.Name = "pistonMovement";
            this.pistonMovement.ReadOnly = true;
            // 
            // multiplyMovementAndF
            // 
            this.multiplyMovementAndF.HeaderText = "FпS, м³";
            this.multiplyMovementAndF.Name = "multiplyMovementAndF";
            this.multiplyMovementAndF.ReadOnly = true;
            // 
            // volumeOfCylinder
            // 
            this.volumeOfCylinder.HeaderText = "V, м³";
            this.volumeOfCylinder.Name = "volumeOfCylinder";
            this.volumeOfCylinder.ReadOnly = true;
            // 
            // attitudeVolumesVaToV
            // 
            this.attitudeVolumesVaToV.HeaderText = "Va/V";
            this.attitudeVolumesVaToV.Name = "attitudeVolumesVaToV";
            this.attitudeVolumesVaToV.ReadOnly = true;
            // 
            // attitudeVolumeVaToVInPower
            // 
            this.attitudeVolumeVaToVInPower.HeaderText = "(Va/V)ⁿ¹";
            this.attitudeVolumeVaToVInPower.Name = "attitudeVolumeVaToVInPower";
            this.attitudeVolumeVaToVInPower.ReadOnly = true;
            // 
            // pressureOnLineCompression
            // 
            this.pressureOnLineCompression.HeaderText = "p, МПа";
            this.pressureOnLineCompression.Name = "pressureOnLineCompression";
            this.pressureOnLineCompression.ReadOnly = true;
            // 
            // attitudeVolumeVToVz
            // 
            this.attitudeVolumeVToVz.HeaderText = "V/Vz";
            this.attitudeVolumeVToVz.Name = "attitudeVolumeVToVz";
            this.attitudeVolumeVToVz.ReadOnly = true;
            // 
            // attitudeVolumeInPowerVToVz
            // 
            this.attitudeVolumeInPowerVToVz.HeaderText = "(V/Vz)ⁿ²";
            this.attitudeVolumeInPowerVToVz.Name = "attitudeVolumeInPowerVToVz";
            this.attitudeVolumeInPowerVToVz.ReadOnly = true;
            // 
            // pressureOnLineExpansion
            // 
            this.pressureOnLineExpansion.HeaderText = "p, МПа";
            this.pressureOnLineExpansion.Name = "pressureOnLineExpansion";
            this.pressureOnLineExpansion.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(158, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(291, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Крок кута повороту колінчастого валу(Δφ):\r\n";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_Pc
            // 
            this.label_Pc.AutoSize = true;
            this.label_Pc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Pc.Location = new System.Drawing.Point(746, 146);
            this.label_Pc.Name = "label_Pc";
            this.label_Pc.Size = new System.Drawing.Size(31, 16);
            this.label_Pc.TabIndex = 14;
            this.label_Pc.Text = "pC: ";
            // 
            // label_PZ
            // 
            this.label_PZ.AutoSize = true;
            this.label_PZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_PZ.Location = new System.Drawing.Point(746, 173);
            this.label_PZ.Name = "label_PZ";
            this.label_PZ.Size = new System.Drawing.Size(30, 16);
            this.label_PZ.TabIndex = 15;
            this.label_PZ.Text = "pZ: ";
            // 
            // chart_IndicatorDiagram
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_IndicatorDiagram.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_IndicatorDiagram.Legends.Add(legend1);
            this.chart_IndicatorDiagram.Location = new System.Drawing.Point(65, 247);
            this.chart_IndicatorDiagram.Name = "chart_IndicatorDiagram";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Italic);
            series1.Legend = "Legend1";
            series1.LegendText = "Політропа стиснення";
            series1.MarkerBorderWidth = 3;
            series1.Name = "PolitropOfComprassion";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.LegendText = "Політропа розширення";
            series2.MarkerBorderColor = System.Drawing.Color.Transparent;
            series2.MarkerBorderWidth = 3;
            series2.Name = "PolitropOfExpansion";
            this.chart_IndicatorDiagram.Series.Add(series1);
            this.chart_IndicatorDiagram.Series.Add(series2);
            this.chart_IndicatorDiagram.Size = new System.Drawing.Size(1044, 300);
            this.chart_IndicatorDiagram.TabIndex = 16;
            this.chart_IndicatorDiagram.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.Name = "indicateDiagram";
            title1.Text = "Індикаторна діаграма";
            this.chart_IndicatorDiagram.Titles.Add(title1);
            this.chart_IndicatorDiagram.Move += new System.EventHandler(this.chart_IndicatorDiagram_Move);
            // 
            // dataGridView_CalcSpecifForces
            // 
            this.dataGridView_CalcSpecifForces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_CalcSpecifForces.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.angle,
            this.pressureOnPiston_P,
            this.specificPressureOnPiston_Pr,
            this.accelerationOfPiston_J,
            this.pJ,
            this.pSum,
            this.tgBeta,
            this.N,
            this.cosBeta,
            this.K,
            this.sinPhiOnCosBeta,
            this.T,
            this.cosPhiPlusBetaOnCosBeta,
            this.Z});
            this.dataGridView_CalcSpecifForces.Location = new System.Drawing.Point(47, 625);
            this.dataGridView_CalcSpecifForces.Name = "dataGridView_CalcSpecifForces";
            this.dataGridView_CalcSpecifForces.Size = new System.Drawing.Size(1163, 150);
            this.dataGridView_CalcSpecifForces.TabIndex = 17;
            this.dataGridView_CalcSpecifForces.Resize += new System.EventHandler(this.dataGridView_CalcSpecifForces_Resize);
            // 
            // angle
            // 
            this.angle.HeaderText = "φ";
            this.angle.Name = "angle";
            this.angle.Width = 60;
            // 
            // pressureOnPiston_P
            // 
            this.pressureOnPiston_P.HeaderText = "p, МПа";
            this.pressureOnPiston_P.Name = "pressureOnPiston_P";
            this.pressureOnPiston_P.Width = 60;
            // 
            // specificPressureOnPiston_Pr
            // 
            this.specificPressureOnPiston_Pr.HeaderText = "Pr, МПа";
            this.specificPressureOnPiston_Pr.Name = "specificPressureOnPiston_Pr";
            this.specificPressureOnPiston_Pr.Width = 60;
            // 
            // accelerationOfPiston_J
            // 
            this.accelerationOfPiston_J.HeaderText = "j, м/c²";
            this.accelerationOfPiston_J.Name = "accelerationOfPiston_J";
            this.accelerationOfPiston_J.Width = 60;
            // 
            // pJ
            // 
            this.pJ.HeaderText = "Pj, МПа";
            this.pJ.Name = "pJ";
            this.pJ.Width = 60;
            // 
            // pSum
            // 
            this.pSum.HeaderText = "PΣ, МПа";
            this.pSum.Name = "pSum";
            this.pSum.Width = 60;
            // 
            // tgBeta
            // 
            this.tgBeta.HeaderText = "tgβ";
            this.tgBeta.Name = "tgBeta";
            this.tgBeta.Width = 60;
            // 
            // N
            // 
            this.N.HeaderText = "N, МПа";
            this.N.Name = "N";
            // 
            // cosBeta
            // 
            this.cosBeta.HeaderText = "cosβ";
            this.cosBeta.Name = "cosBeta";
            // 
            // K
            // 
            this.K.HeaderText = "K, МПа";
            this.K.Name = "K";
            // 
            // sinPhiOnCosBeta
            // 
            this.sinPhiOnCosBeta.HeaderText = "sin(φ+β)/cosβ";
            this.sinPhiOnCosBeta.Name = "sinPhiOnCosBeta";
            // 
            // T
            // 
            this.T.HeaderText = "T, МПа";
            this.T.Name = "T";
            // 
            // cosPhiPlusBetaOnCosBeta
            // 
            this.cosPhiPlusBetaOnCosBeta.HeaderText = "cos(φ+β)/cosβ";
            this.cosPhiPlusBetaOnCosBeta.Name = "cosPhiPlusBetaOnCosBeta";
            // 
            // Z
            // 
            this.Z.HeaderText = "Z, МПа";
            this.Z.Name = "Z";
            // 
            // chartOfSpecificForcesP
            // 
            chartArea2.Name = "ChartArea1";
            this.chartOfSpecificForcesP.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartOfSpecificForcesP.Legends.Add(legend2);
            this.chartOfSpecificForcesP.Location = new System.Drawing.Point(24, 308);
            this.chartOfSpecificForcesP.Name = "chartOfSpecificForcesP";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.LegendText = "Pr";
            series3.Name = "SeriesPr";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.LegendText = "Pj";
            series4.Name = "SeriesPj";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.LegendText = "PΣ";
            series5.Name = "SeriesPsum";
            this.chartOfSpecificForcesP.Series.Add(series3);
            this.chartOfSpecificForcesP.Series.Add(series4);
            this.chartOfSpecificForcesP.Series.Add(series5);
            this.chartOfSpecificForcesP.Size = new System.Drawing.Size(1044, 300);
            this.chartOfSpecificForcesP.TabIndex = 18;
            this.chartOfSpecificForcesP.Text = "chart1";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title2.Name = "Title1";
            title2.Text = "Залежність питомих сил Pr, Pj, PΣ від кута для чотирьохтактного двигуна";
            this.chartOfSpecificForcesP.Titles.Add(title2);
            this.chartOfSpecificForcesP.Move += new System.EventHandler(this.chartOfSpecificForcesP_Move);
            // 
            // chartOfSpecificForces_KAndN
            // 
            chartArea3.Name = "ChartArea1";
            this.chartOfSpecificForces_KAndN.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartOfSpecificForces_KAndN.Legends.Add(legend3);
            this.chartOfSpecificForces_KAndN.Location = new System.Drawing.Point(91, 330);
            this.chartOfSpecificForces_KAndN.Name = "chartOfSpecificForces_KAndN";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Legend = "Legend1";
            series6.LegendText = "K";
            series6.Name = "SeriesK";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Legend = "Legend1";
            series7.LegendText = "N";
            series7.Name = "SeriesN";
            this.chartOfSpecificForces_KAndN.Series.Add(series6);
            this.chartOfSpecificForces_KAndN.Series.Add(series7);
            this.chartOfSpecificForces_KAndN.Size = new System.Drawing.Size(1044, 300);
            this.chartOfSpecificForces_KAndN.TabIndex = 19;
            this.chartOfSpecificForces_KAndN.Text = "chart1";
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title3.Name = "Title1";
            title3.Text = "Залежність питомих сил K i N від кута для чотирьохтактного двигуна";
            this.chartOfSpecificForces_KAndN.Titles.Add(title3);
            this.chartOfSpecificForces_KAndN.Move += new System.EventHandler(this.chartOfSpecificForces_KAndN_Move);
            // 
            // chartOfSpecificForces_TAndZ
            // 
            chartArea4.Name = "ChartArea1";
            this.chartOfSpecificForces_TAndZ.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartOfSpecificForces_TAndZ.Legends.Add(legend4);
            this.chartOfSpecificForces_TAndZ.Location = new System.Drawing.Point(91, 475);
            this.chartOfSpecificForces_TAndZ.Name = "chartOfSpecificForces_TAndZ";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.Legend = "Legend1";
            series8.LegendText = "T";
            series8.Name = "SeriesT";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series9.Legend = "Legend1";
            series9.LegendText = "Z";
            series9.Name = "SeriesZ";
            this.chartOfSpecificForces_TAndZ.Series.Add(series8);
            this.chartOfSpecificForces_TAndZ.Series.Add(series9);
            this.chartOfSpecificForces_TAndZ.Size = new System.Drawing.Size(1044, 300);
            this.chartOfSpecificForces_TAndZ.TabIndex = 20;
            this.chartOfSpecificForces_TAndZ.Text = "chart1";
            title4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title4.Name = "Title1";
            title4.Text = "Залежність питомих сил T i Z від кута для чотирьохтактного двигуна";
            this.chartOfSpecificForces_TAndZ.Titles.Add(title4);
            // 
            // chartOfGasPressureOnPistonFromAngle
            // 
            chartArea5.Name = "ChartArea1";
            this.chartOfGasPressureOnPistonFromAngle.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartOfGasPressureOnPistonFromAngle.Legends.Add(legend5);
            this.chartOfGasPressureOnPistonFromAngle.Location = new System.Drawing.Point(108, 407);
            this.chartOfGasPressureOnPistonFromAngle.Name = "chartOfGasPressureOnPistonFromAngle";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series10.Legend = "Legend1";
            series10.LegendText = "P1";
            series10.Name = "SeriesEveryP";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series11.Legend = "Legend1";
            series11.LegendText = "P2";
            series11.Name = "SeriesPTo360";
            this.chartOfGasPressureOnPistonFromAngle.Series.Add(series10);
            this.chartOfGasPressureOnPistonFromAngle.Series.Add(series11);
            this.chartOfGasPressureOnPistonFromAngle.Size = new System.Drawing.Size(1044, 300);
            this.chartOfGasPressureOnPistonFromAngle.TabIndex = 21;
            this.chartOfGasPressureOnPistonFromAngle.Text = "chart1";
            title5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title5.Name = "Title1";
            title5.Text = "Діаграма сил згоряння газів";
            this.chartOfGasPressureOnPistonFromAngle.Titles.Add(title5);
            this.chartOfGasPressureOnPistonFromAngle.Move += new System.EventHandler(this.chartOfGasPressureOnPistonFromAngle_Move);
            // 
            // label_AnalyticPip
            // 
            this.label_AnalyticPip.AutoSize = true;
            this.label_AnalyticPip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_AnalyticPip.Location = new System.Drawing.Point(994, 91);
            this.label_AnalyticPip.Name = "label_AnalyticPip";
            this.label_AnalyticPip.Size = new System.Drawing.Size(115, 16);
            this.label_AnalyticPip.TabIndex = 22;
            this.label_AnalyticPip.Text = "Аналітичне Pᵢₚ = ";
            this.label_AnalyticPip.Move += new System.EventHandler(this.label_AnalyticPip_Move);
            // 
            // label_GraphicPip
            // 
            this.label_GraphicPip.AutoSize = true;
            this.label_GraphicPip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_GraphicPip.Location = new System.Drawing.Point(994, 125);
            this.label_GraphicPip.Name = "label_GraphicPip";
            this.label_GraphicPip.Size = new System.Drawing.Size(101, 16);
            this.label_GraphicPip.TabIndex = 23;
            this.label_GraphicPip.Text = "Графічне Pᵢₚ = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(547, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "5";
            // 
            // FormDiagramProcessOfCylinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1264, 813);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_GraphicPip);
            this.Controls.Add(this.label_AnalyticPip);
            this.Controls.Add(this.chartOfGasPressureOnPistonFromAngle);
            this.Controls.Add(this.chartOfSpecificForces_TAndZ);
            this.Controls.Add(this.chartOfSpecificForces_KAndN);
            this.Controls.Add(this.chartOfSpecificForcesP);
            this.Controls.Add(this.dataGridView_CalcSpecifForces);
            this.Controls.Add(this.chart_IndicatorDiagram);
            this.Controls.Add(this.label_PZ);
            this.Controls.Add(this.label_Pc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView_Politrop);
            this.Controls.Add(this.textBox_Lambda_DegreeOfPressureIncrease);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_N2_IndicPolitrExpansion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelDataForCreateDiagr);
            this.Controls.Add(this.textBox_N1_IndicPolitrCompres);
            this.Controls.Add(this.btnCalcAndBuildDiagr);
            this.Controls.Add(this.label1);
            this.Name = "FormDiagramProcessOfCylinder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Діаграма робочого процесу для циліндра";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Politrop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_IndicatorDiagram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CalcSpecifForces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOfSpecificForcesP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOfSpecificForces_KAndN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOfSpecificForces_TAndZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOfGasPressureOnPistonFromAngle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalcAndBuildDiagr;
        private System.Windows.Forms.TextBox textBox_N1_IndicPolitrCompres;
        private System.Windows.Forms.Label labelDataForCreateDiagr;
        private System.Windows.Forms.TextBox textBox_N2_IndicPolitrExpansion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Lambda_DegreeOfPressureIncrease;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView_Politrop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label_Pc;
        private System.Windows.Forms.Label label_PZ;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_IndicatorDiagram;
        private System.Windows.Forms.DataGridView dataGridView_CalcSpecifForces;
        private Chart chartOfSpecificForcesP;
        private System.Windows.Forms.DataGridViewTextBoxColumn degree;
        private System.Windows.Forms.DataGridViewTextBoxColumn pistonMovement;
        private System.Windows.Forms.DataGridViewTextBoxColumn multiplyMovementAndF;
        private System.Windows.Forms.DataGridViewTextBoxColumn volumeOfCylinder;
        private System.Windows.Forms.DataGridViewTextBoxColumn attitudeVolumesVaToV;
        private System.Windows.Forms.DataGridViewTextBoxColumn attitudeVolumeVaToVInPower;
        private System.Windows.Forms.DataGridViewTextBoxColumn pressureOnLineCompression;
        private System.Windows.Forms.DataGridViewTextBoxColumn attitudeVolumeVToVz;
        private System.Windows.Forms.DataGridViewTextBoxColumn attitudeVolumeInPowerVToVz;
        private System.Windows.Forms.DataGridViewTextBoxColumn pressureOnLineExpansion;
        private System.Windows.Forms.DataGridViewTextBoxColumn angle;
        private System.Windows.Forms.DataGridViewTextBoxColumn pressureOnPiston_P;
        private System.Windows.Forms.DataGridViewTextBoxColumn specificPressureOnPiston_Pr;
        private System.Windows.Forms.DataGridViewTextBoxColumn accelerationOfPiston_J;
        private System.Windows.Forms.DataGridViewTextBoxColumn pJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn pSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgBeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn N;
        private System.Windows.Forms.DataGridViewTextBoxColumn cosBeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn K;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinPhiOnCosBeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn T;
        private System.Windows.Forms.DataGridViewTextBoxColumn cosPhiPlusBetaOnCosBeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Z;
        private Chart chartOfSpecificForces_KAndN;
        private Chart chartOfSpecificForces_TAndZ;
        private Chart chartOfGasPressureOnPistonFromAngle;
        private Label label_AnalyticPip;
        private Label label_GraphicPip;
        private Label label2;

        public Label LabelDataForCreateDiagr { get => labelDataForCreateDiagr; set => labelDataForCreateDiagr = value; }
        public TextBox TextBox_N1_IndicPolitrCompres { get => textBox_N1_IndicPolitrCompres; set => textBox_N1_IndicPolitrCompres = value; }
        public TextBox TextBox_N2_IndicPolitrExpansion { get => textBox_N2_IndicPolitrExpansion; set => textBox_N2_IndicPolitrExpansion = value; }
        public TextBox TextBox_Lambda_DegreeOfPressureIncrease { get => textBox_Lambda_DegreeOfPressureIncrease; set => textBox_Lambda_DegreeOfPressureIncrease = value; }
        public Button BtnCalcAndBuildDiagr { get => btnCalcAndBuildDiagr; set => btnCalcAndBuildDiagr = value; }
    }
}