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
            chartArea1.Name = "ChartArea1";
            this.chart_IndicatorDiagram.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_IndicatorDiagram.Legends.Add(legend1);
            this.chart_IndicatorDiagram.Location = new System.Drawing.Point(12, 164);
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
            this.chart_IndicatorDiagram.Size = new System.Drawing.Size(1223, 476);
            this.chart_IndicatorDiagram.TabIndex = 16;
            this.chart_IndicatorDiagram.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.Name = "indicateDiagram";
            title1.Text = "Індикаторна діаграма";
            this.chart_IndicatorDiagram.Titles.Add(title1);
            this.chart_IndicatorDiagram.Customize += new System.EventHandler(this.chart_IndicatorDiagram_Customize);
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
            this.chartOfSpecificForcesP.Location = new System.Drawing.Point(108, 262);
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
            this.chartOfSpecificForcesP.Customize += new System.EventHandler(this.chartOfSpecificForcesP_Customize);
            this.chartOfSpecificForcesP.Move += new System.EventHandler(this.chartOfSpecificForcesP_Move);
            // 
            // chartOfSpecificForces_KAndN
            // 
            chartArea3.Name = "ChartArea1";
            this.chartOfSpecificForces_KAndN.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartOfSpecificForces_KAndN.Legends.Add(legend3);
            this.chartOfSpecificForces_KAndN.Location = new System.Drawing.Point(108, 370);
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
            this.chartOfSpecificForces_KAndN.Customize += new System.EventHandler(this.chartOfSpecificForces_KAndN_Customize);
            this.chartOfSpecificForces_KAndN.Move += new System.EventHandler(this.chartOfSpecificForces_KAndN_Move);
            // 
            // chartOfSpecificForces_TAndZ
            // 
            chartArea4.Name = "ChartArea1";
            this.chartOfSpecificForces_TAndZ.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartOfSpecificForces_TAndZ.Legends.Add(legend4);
            this.chartOfSpecificForces_TAndZ.Location = new System.Drawing.Point(108, 262);
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
            this.chartOfSpecificForces_TAndZ.Customize += new System.EventHandler(this.chartOfSpecificForces_TAndZ_Customize);
            // 
            // chartOfGasPressureOnPistonFromAngle
            // 
            chartArea5.Name = "ChartArea1";
            this.chartOfGasPressureOnPistonFromAngle.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartOfGasPressureOnPistonFromAngle.Legends.Add(legend5);
            this.chartOfGasPressureOnPistonFromAngle.Location = new System.Drawing.Point(108, 81);
            this.chartOfGasPressureOnPistonFromAngle.Name = "chartOfGasPressureOnPistonFromAngle";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series10.Legend = "Legend1";
            series10.LegendText = "Стиснення";
            series10.Name = "SeriesEveryP";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series11.Legend = "Legend1";
            series11.LegendText = "Розширення";
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
            this.chartOfGasPressureOnPistonFromAngle.Customize += new System.EventHandler(this.chartOfGasPressureOnPistonFromAngle_Customize);
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