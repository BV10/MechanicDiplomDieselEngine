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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title7 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title8 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title9 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title10 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.labelDataForCreateDiagr = new System.Windows.Forms.Label();
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
            this.label_EtaV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Politrop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_IndicatorDiagram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CalcSpecifForces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOfSpecificForcesP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOfSpecificForces_KAndN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOfSpecificForces_TAndZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOfGasPressureOnPistonFromAngle)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDataForCreateDiagr
            // 
            this.labelDataForCreateDiagr.AutoSize = true;
            this.labelDataForCreateDiagr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDataForCreateDiagr.Location = new System.Drawing.Point(446, 9);
            this.labelDataForCreateDiagr.Name = "labelDataForCreateDiagr";
            this.labelDataForCreateDiagr.Size = new System.Drawing.Size(289, 24);
            this.labelDataForCreateDiagr.TabIndex = 3;
            this.labelDataForCreateDiagr.Text = "Дані для побудови діаграми";
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
            this.dataGridView_Politrop.Location = new System.Drawing.Point(108, 164);
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
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_Pc
            // 
            this.label_Pc.AutoSize = true;
            this.label_Pc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Pc.Location = new System.Drawing.Point(572, 47);
            this.label_Pc.Name = "label_Pc";
            this.label_Pc.Size = new System.Drawing.Size(37, 20);
            this.label_Pc.TabIndex = 14;
            this.label_Pc.Text = "pC: ";
            // 
            // label_PZ
            // 
            this.label_PZ.AutoSize = true;
            this.label_PZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_PZ.Location = new System.Drawing.Point(573, 81);
            this.label_PZ.Name = "label_PZ";
            this.label_PZ.Size = new System.Drawing.Size(36, 20);
            this.label_PZ.TabIndex = 15;
            this.label_PZ.Text = "pZ: ";
            // 
            // chart_IndicatorDiagram
            // 
            chartArea6.Name = "ChartArea1";
            this.chart_IndicatorDiagram.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart_IndicatorDiagram.Legends.Add(legend6);
            this.chart_IndicatorDiagram.Location = new System.Drawing.Point(65, 179);
            this.chart_IndicatorDiagram.Name = "chart_IndicatorDiagram";
            series12.BorderWidth = 3;
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series12.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Italic);
            series12.Legend = "Legend1";
            series12.LegendText = "Політропа стиснення";
            series12.MarkerBorderWidth = 3;
            series12.Name = "PolitropOfComprassion";
            series13.BorderWidth = 3;
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series13.Legend = "Legend1";
            series13.LegendText = "Політропа розширення";
            series13.MarkerBorderColor = System.Drawing.Color.Transparent;
            series13.MarkerBorderWidth = 3;
            series13.Name = "PolitropOfExpansion";
            this.chart_IndicatorDiagram.Series.Add(series12);
            this.chart_IndicatorDiagram.Series.Add(series13);
            this.chart_IndicatorDiagram.Size = new System.Drawing.Size(1044, 300);
            this.chart_IndicatorDiagram.TabIndex = 16;
            this.chart_IndicatorDiagram.Text = "chart1";
            title6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title6.Name = "indicateDiagram";
            title6.Text = "Індикаторна діаграма";
            this.chart_IndicatorDiagram.Titles.Add(title6);
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
            chartArea7.Name = "ChartArea1";
            this.chartOfSpecificForcesP.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chartOfSpecificForcesP.Legends.Add(legend7);
            this.chartOfSpecificForcesP.Location = new System.Drawing.Point(108, 275);
            this.chartOfSpecificForcesP.Name = "chartOfSpecificForcesP";
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series14.Legend = "Legend1";
            series14.LegendText = "Pr";
            series14.Name = "SeriesPr";
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series15.Legend = "Legend1";
            series15.LegendText = "Pj";
            series15.Name = "SeriesPj";
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series16.Legend = "Legend1";
            series16.LegendText = "PΣ";
            series16.Name = "SeriesPsum";
            this.chartOfSpecificForcesP.Series.Add(series14);
            this.chartOfSpecificForcesP.Series.Add(series15);
            this.chartOfSpecificForcesP.Series.Add(series16);
            this.chartOfSpecificForcesP.Size = new System.Drawing.Size(1044, 300);
            this.chartOfSpecificForcesP.TabIndex = 18;
            this.chartOfSpecificForcesP.Text = "chart1";
            title7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title7.Name = "Title1";
            title7.Text = "Залежність питомих сил Pr, Pj, PΣ від кута для чотирьохтактного двигуна";
            this.chartOfSpecificForcesP.Titles.Add(title7);
            this.chartOfSpecificForcesP.Move += new System.EventHandler(this.chartOfSpecificForcesP_Move);
            // 
            // chartOfSpecificForces_KAndN
            // 
            chartArea8.Name = "ChartArea1";
            this.chartOfSpecificForces_KAndN.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chartOfSpecificForces_KAndN.Legends.Add(legend8);
            this.chartOfSpecificForces_KAndN.Location = new System.Drawing.Point(108, 309);
            this.chartOfSpecificForces_KAndN.Name = "chartOfSpecificForces_KAndN";
            series17.ChartArea = "ChartArea1";
            series17.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series17.Legend = "Legend1";
            series17.LegendText = "K";
            series17.Name = "SeriesK";
            series18.ChartArea = "ChartArea1";
            series18.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series18.Legend = "Legend1";
            series18.LegendText = "N";
            series18.Name = "SeriesN";
            this.chartOfSpecificForces_KAndN.Series.Add(series17);
            this.chartOfSpecificForces_KAndN.Series.Add(series18);
            this.chartOfSpecificForces_KAndN.Size = new System.Drawing.Size(1044, 300);
            this.chartOfSpecificForces_KAndN.TabIndex = 19;
            this.chartOfSpecificForces_KAndN.Text = "chart1";
            title8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title8.Name = "Title1";
            title8.Text = "Залежність питомих сил K i N від кута для чотирьохтактного двигуна";
            this.chartOfSpecificForces_KAndN.Titles.Add(title8);
            this.chartOfSpecificForces_KAndN.Move += new System.EventHandler(this.chartOfSpecificForces_KAndN_Move);
            // 
            // chartOfSpecificForces_TAndZ
            // 
            chartArea9.Name = "ChartArea1";
            this.chartOfSpecificForces_TAndZ.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.chartOfSpecificForces_TAndZ.Legends.Add(legend9);
            this.chartOfSpecificForces_TAndZ.Location = new System.Drawing.Point(108, 475);
            this.chartOfSpecificForces_TAndZ.Name = "chartOfSpecificForces_TAndZ";
            series19.ChartArea = "ChartArea1";
            series19.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series19.Legend = "Legend1";
            series19.LegendText = "T";
            series19.Name = "SeriesT";
            series20.ChartArea = "ChartArea1";
            series20.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series20.Legend = "Legend1";
            series20.LegendText = "Z";
            series20.Name = "SeriesZ";
            this.chartOfSpecificForces_TAndZ.Series.Add(series19);
            this.chartOfSpecificForces_TAndZ.Series.Add(series20);
            this.chartOfSpecificForces_TAndZ.Size = new System.Drawing.Size(1044, 300);
            this.chartOfSpecificForces_TAndZ.TabIndex = 20;
            this.chartOfSpecificForces_TAndZ.Text = "chart1";
            title9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title9.Name = "Title1";
            title9.Text = "Залежність питомих сил T i Z від кута для чотирьохтактного двигуна";
            this.chartOfSpecificForces_TAndZ.Titles.Add(title9);
            // 
            // chartOfGasPressureOnPistonFromAngle
            // 
            chartArea10.Name = "ChartArea1";
            this.chartOfGasPressureOnPistonFromAngle.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.chartOfGasPressureOnPistonFromAngle.Legends.Add(legend10);
            this.chartOfGasPressureOnPistonFromAngle.Location = new System.Drawing.Point(108, 404);
            this.chartOfGasPressureOnPistonFromAngle.Name = "chartOfGasPressureOnPistonFromAngle";
            series21.ChartArea = "ChartArea1";
            series21.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series21.Legend = "Legend1";
            series21.LegendText = "P1";
            series21.Name = "SeriesEveryP";
            series22.ChartArea = "ChartArea1";
            series22.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series22.Legend = "Legend1";
            series22.LegendText = "P2";
            series22.Name = "SeriesPTo360";
            this.chartOfGasPressureOnPistonFromAngle.Series.Add(series21);
            this.chartOfGasPressureOnPistonFromAngle.Series.Add(series22);
            this.chartOfGasPressureOnPistonFromAngle.Size = new System.Drawing.Size(1044, 300);
            this.chartOfGasPressureOnPistonFromAngle.TabIndex = 21;
            this.chartOfGasPressureOnPistonFromAngle.Text = "chart1";
            title10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title10.Name = "Title1";
            title10.Text = "Діаграма сил згоряння газів";
            this.chartOfGasPressureOnPistonFromAngle.Titles.Add(title10);
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
            // label_EtaV
            // 
            this.label_EtaV.AutoSize = true;
            this.label_EtaV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_EtaV.Location = new System.Drawing.Point(395, 121);
            this.label_EtaV.Name = "label_EtaV";
            this.label_EtaV.Size = new System.Drawing.Size(214, 20);
            this.label_EtaV.TabIndex = 25;
            this.label_EtaV.Text = "Коефіцієнт наповнення ηᵥ :";
            // 
            // FormDiagramProcessOfCylinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1264, 813);
            this.Controls.Add(this.label_EtaV);
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
            this.Controls.Add(this.dataGridView_Politrop);
            this.Controls.Add(this.labelDataForCreateDiagr);
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
        private System.Windows.Forms.Label labelDataForCreateDiagr;
        private System.Windows.Forms.DataGridView dataGridView_Politrop;
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
        private Label label_EtaV;

        public Label LabelDataForCreateDiagr { get => labelDataForCreateDiagr; set => labelDataForCreateDiagr = value; }      
    }
}