using System.Drawing;
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title9 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title10 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series25 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title11 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series26 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series27 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title12 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalcAndBuildDiagr = new System.Windows.Forms.Button();
            this.textBox_N1_IndicPolitrCompres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.textBox_DeltaAngle = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Politrop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_IndicatorDiagram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CalcSpecifForces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOfSpecificForcesP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOfSpecificForces_KAndN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOfSpecificForces_TAndZ)).BeginInit();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(285, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Дані для побудови діаграми";
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
            // textBox_DeltaAngle
            // 
            this.textBox_DeltaAngle.Location = new System.Drawing.Point(551, 173);
            this.textBox_DeltaAngle.Name = "textBox_DeltaAngle";
            this.textBox_DeltaAngle.Size = new System.Drawing.Size(90, 20);
            this.textBox_DeltaAngle.TabIndex = 12;
            this.textBox_DeltaAngle.Text = "5";
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
            chartArea9.Name = "ChartArea1";
            this.chart_IndicatorDiagram.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.chart_IndicatorDiagram.Legends.Add(legend9);
            this.chart_IndicatorDiagram.Location = new System.Drawing.Point(108, 284);
            this.chart_IndicatorDiagram.Name = "chart_IndicatorDiagram";
            series19.BorderWidth = 3;
            series19.ChartArea = "ChartArea1";
            series19.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series19.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Italic);
            series19.Legend = "Legend1";
            series19.LegendText = "Політропа стиснення";
            series19.MarkerBorderWidth = 3;
            series19.Name = "PolitropOfComprassion";
            series20.BorderWidth = 3;
            series20.ChartArea = "ChartArea1";
            series20.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series20.Legend = "Legend1";
            series20.LegendText = "Політропа розширення";
            series20.MarkerBorderColor = System.Drawing.Color.Transparent;
            series20.MarkerBorderWidth = 3;
            series20.Name = "PolitropOfExpansion";
            this.chart_IndicatorDiagram.Series.Add(series19);
            this.chart_IndicatorDiagram.Series.Add(series20);
            this.chart_IndicatorDiagram.Size = new System.Drawing.Size(1044, 300);
            this.chart_IndicatorDiagram.TabIndex = 16;
            this.chart_IndicatorDiagram.Text = "chart1";
            title9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title9.Name = "indicateDiagram";
            title9.Text = "Індикаторна діаграма";
            this.chart_IndicatorDiagram.Titles.Add(title9);
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
            chartArea10.Name = "ChartArea1";
            this.chartOfSpecificForcesP.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.chartOfSpecificForcesP.Legends.Add(legend10);
            this.chartOfSpecificForcesP.Location = new System.Drawing.Point(108, 345);
            this.chartOfSpecificForcesP.Name = "chartOfSpecificForcesP";
            series21.ChartArea = "ChartArea1";
            series21.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series21.Legend = "Legend1";
            series21.LegendText = "Pr";
            series21.Name = "SeriesPr";
            series22.ChartArea = "ChartArea1";
            series22.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series22.Legend = "Legend1";
            series22.LegendText = "Pj";
            series22.Name = "SeriesPj";
            series23.ChartArea = "ChartArea1";
            series23.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series23.Legend = "Legend1";
            series23.LegendText = "PΣ";
            series23.Name = "SeriesPsum";
            this.chartOfSpecificForcesP.Series.Add(series21);
            this.chartOfSpecificForcesP.Series.Add(series22);
            this.chartOfSpecificForcesP.Series.Add(series23);
            this.chartOfSpecificForcesP.Size = new System.Drawing.Size(1044, 300);
            this.chartOfSpecificForcesP.TabIndex = 18;
            this.chartOfSpecificForcesP.Text = "chart1";
            title10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title10.Name = "Title1";
            title10.Text = "Залежність питомих сил Pr, Pj, PΣ від кута для чотирьохтактного двигуна";
            this.chartOfSpecificForcesP.Titles.Add(title10);
            this.chartOfSpecificForcesP.Move += new System.EventHandler(this.chartOfSpecificForcesP_Move);
            // 
            // chartOfSpecificForces_KAndN
            // 
            chartArea11.Name = "ChartArea1";
            this.chartOfSpecificForces_KAndN.ChartAreas.Add(chartArea11);
            legend11.Name = "Legend1";
            this.chartOfSpecificForces_KAndN.Legends.Add(legend11);
            this.chartOfSpecificForces_KAndN.Location = new System.Drawing.Point(108, 408);
            this.chartOfSpecificForces_KAndN.Name = "chartOfSpecificForces_KAndN";
            series24.ChartArea = "ChartArea1";
            series24.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series24.Legend = "Legend1";
            series24.LegendText = "K";
            series24.Name = "SeriesK";
            series25.ChartArea = "ChartArea1";
            series25.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series25.Legend = "Legend1";
            series25.LegendText = "N";
            series25.Name = "SeriesN";
            this.chartOfSpecificForces_KAndN.Series.Add(series24);
            this.chartOfSpecificForces_KAndN.Series.Add(series25);
            this.chartOfSpecificForces_KAndN.Size = new System.Drawing.Size(1044, 300);
            this.chartOfSpecificForces_KAndN.TabIndex = 19;
            this.chartOfSpecificForces_KAndN.Text = "chart1";
            title11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title11.Name = "Title1";
            title11.Text = "Залежність питомих сил K i N від кута для чотирьохтактного двигуна";
            this.chartOfSpecificForces_KAndN.Titles.Add(title11);
            this.chartOfSpecificForces_KAndN.Move += new System.EventHandler(this.chartOfSpecificForces_KAndN_Move);
            // 
            // chartOfSpecificForces_TAndZ
            // 
            chartArea12.Name = "ChartArea1";
            this.chartOfSpecificForces_TAndZ.ChartAreas.Add(chartArea12);
            legend12.Name = "Legend1";
            this.chartOfSpecificForces_TAndZ.Legends.Add(legend12);
            this.chartOfSpecificForces_TAndZ.Location = new System.Drawing.Point(108, 475);
            this.chartOfSpecificForces_TAndZ.Name = "chartOfSpecificForces_TAndZ";
            series26.ChartArea = "ChartArea1";
            series26.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series26.Legend = "Legend1";
            series26.LegendText = "T";
            series26.Name = "SeriesT";
            series27.ChartArea = "ChartArea1";
            series27.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series27.Legend = "Legend1";
            series27.LegendText = "Z";
            series27.Name = "SeriesZ";
            this.chartOfSpecificForces_TAndZ.Series.Add(series26);
            this.chartOfSpecificForces_TAndZ.Series.Add(series27);
            this.chartOfSpecificForces_TAndZ.Size = new System.Drawing.Size(1044, 300);
            this.chartOfSpecificForces_TAndZ.TabIndex = 20;
            this.chartOfSpecificForces_TAndZ.Text = "chart1";
            title12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title12.Name = "Title1";
            title12.Text = "Залежність питомих сил T i Z від кута для чотирьохтактного двигуна";
            this.chartOfSpecificForces_TAndZ.Titles.Add(title12);
            // 
            // FormDiagramProcessOfCylinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1264, 813);
            this.Controls.Add(this.chartOfSpecificForces_TAndZ);
            this.Controls.Add(this.chartOfSpecificForces_KAndN);
            this.Controls.Add(this.chartOfSpecificForcesP);
            this.Controls.Add(this.dataGridView_CalcSpecifForces);
            this.Controls.Add(this.chart_IndicatorDiagram);
            this.Controls.Add(this.label_PZ);
            this.Controls.Add(this.label_Pc);
            this.Controls.Add(this.textBox_DeltaAngle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView_Politrop);
            this.Controls.Add(this.textBox_Lambda_DegreeOfPressureIncrease);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_N2_IndicPolitrExpansion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalcAndBuildDiagr;
        private System.Windows.Forms.TextBox textBox_N1_IndicPolitrCompres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_N2_IndicPolitrExpansion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Lambda_DegreeOfPressureIncrease;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView_Politrop;
        private System.Windows.Forms.TextBox textBox_DeltaAngle;
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
    }
}