﻿namespace Mechanic
{
    partial class FormCreateDiagramProcess
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
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Politrop)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(112, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Середній показник політропи стиснення (n1 = 1.36...1.38) :\r\n";
            // 
            // btnCalcAndBuildDiagr
            // 
            this.btnCalcAndBuildDiagr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCalcAndBuildDiagr.Location = new System.Drawing.Point(701, 92);
            this.btnCalcAndBuildDiagr.Name = "btnCalcAndBuildDiagr";
            this.btnCalcAndBuildDiagr.Size = new System.Drawing.Size(204, 45);
            this.btnCalcAndBuildDiagr.TabIndex = 1;
            this.btnCalcAndBuildDiagr.Text = "Розрахувати та побудувати діаграму";
            this.btnCalcAndBuildDiagr.UseVisualStyleBackColor = true;
            this.btnCalcAndBuildDiagr.Click += new System.EventHandler(this.btnCalcAndBuildDiagr_Click);
            // 
            // textBox_N1_IndicPolitrCompres
            // 
            this.textBox_N1_IndicPolitrCompres.Location = new System.Drawing.Point(505, 68);
            this.textBox_N1_IndicPolitrCompres.Name = "textBox_N1_IndicPolitrCompres";
            this.textBox_N1_IndicPolitrCompres.Size = new System.Drawing.Size(90, 20);
            this.textBox_N1_IndicPolitrCompres.TabIndex = 2;
            this.textBox_N1_IndicPolitrCompres.Text = "1,37";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(240, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Дані для побудови діаграми";
            // 
            // textBox_N2_IndicPolitrExpansion
            // 
            this.textBox_N2_IndicPolitrExpansion.Location = new System.Drawing.Point(505, 105);
            this.textBox_N2_IndicPolitrExpansion.Name = "textBox_N2_IndicPolitrExpansion";
            this.textBox_N2_IndicPolitrExpansion.Size = new System.Drawing.Size(90, 20);
            this.textBox_N2_IndicPolitrExpansion.TabIndex = 7;
            this.textBox_N2_IndicPolitrExpansion.Text = "1,27";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(112, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(386, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Середній показник політропи розширення (n2 = 1.26...1.28) :\r\n";
            // 
            // textBox_Lambda_DegreeOfPressureIncrease
            // 
            this.textBox_Lambda_DegreeOfPressureIncrease.Location = new System.Drawing.Point(505, 139);
            this.textBox_Lambda_DegreeOfPressureIncrease.Name = "textBox_Lambda_DegreeOfPressureIncrease";
            this.textBox_Lambda_DegreeOfPressureIncrease.Size = new System.Drawing.Size(90, 20);
            this.textBox_Lambda_DegreeOfPressureIncrease.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(112, 137);
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
            this.dataGridView_Politrop.Location = new System.Drawing.Point(63, 205);
            this.dataGridView_Politrop.Name = "dataGridView_Politrop";
            this.dataGridView_Politrop.Size = new System.Drawing.Size(1044, 47);
            this.dataGridView_Politrop.TabIndex = 10;
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
            this.multiplyMovementAndF.HeaderText = "FпS, м^3";
            this.multiplyMovementAndF.Name = "multiplyMovementAndF";
            this.multiplyMovementAndF.ReadOnly = true;
            // 
            // volumeOfCylinder
            // 
            this.volumeOfCylinder.HeaderText = "V, м^3";
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
            this.attitudeVolumeVaToVInPower.HeaderText = "(Va/V)^n1";
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
            this.attitudeVolumeInPowerVToVz.HeaderText = "(V/Vz)^n2";
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
            this.textBox_DeltaAngle.Location = new System.Drawing.Point(506, 173);
            this.textBox_DeltaAngle.Name = "textBox_DeltaAngle";
            this.textBox_DeltaAngle.Size = new System.Drawing.Size(90, 20);
            this.textBox_DeltaAngle.TabIndex = 12;
            this.textBox_DeltaAngle.Text = "3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(113, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(291, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Крок кута повороту колінчастого валу(Δφ):\r\n";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(316, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "НЕ ИСПОЛЬЗ!!!!!!!\r\n";
            // 
            // FormCreateDiagramProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1174, 637);
            this.Controls.Add(this.label6);
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
            this.Name = "FormCreateDiagramProcess";
            this.Text = "Діаграма робочого процесу для цилінндра";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Politrop)).EndInit();
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
        private System.Windows.Forms.TextBox textBox_DeltaAngle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label6;
    }
}