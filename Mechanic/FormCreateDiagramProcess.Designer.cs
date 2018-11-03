namespace Mechanic
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(701, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Розрахувати та побудувати діаграму";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(505, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(90, 20);
            this.textBox1.TabIndex = 2;
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
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(505, 105);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(90, 20);
            this.textBox3.TabIndex = 7;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(505, 139);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(90, 20);
            this.textBox2.TabIndex = 9;
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridView1.Location = new System.Drawing.Point(63, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1044, 45);
            this.dataGridView1.TabIndex = 10;
            // 
            // degree
            // 
            this.degree.HeaderText = "φ";
            this.degree.Name = "degree";
            // 
            // pistonMovement
            // 
            this.pistonMovement.HeaderText = "S, м";
            this.pistonMovement.Name = "pistonMovement";
            // 
            // multiplyMovementAndF
            // 
            this.multiplyMovementAndF.HeaderText = "FпS, м^3";
            this.multiplyMovementAndF.Name = "multiplyMovementAndF";
            // 
            // volumeOfCylinder
            // 
            this.volumeOfCylinder.HeaderText = "V, м^3";
            this.volumeOfCylinder.Name = "volumeOfCylinder";
            // 
            // attitudeVolumesVaToV
            // 
            this.attitudeVolumesVaToV.HeaderText = "Va/V";
            this.attitudeVolumesVaToV.Name = "attitudeVolumesVaToV";
            // 
            // attitudeVolumeVaToVInPower
            // 
            this.attitudeVolumeVaToVInPower.HeaderText = "(Va/V)^n1";
            this.attitudeVolumeVaToVInPower.Name = "attitudeVolumeVaToVInPower";
            // 
            // pressureOnLineCompression
            // 
            this.pressureOnLineCompression.HeaderText = "p, МПа";
            this.pressureOnLineCompression.Name = "pressureOnLineCompression";
            // 
            // attitudeVolumeVToVz
            // 
            this.attitudeVolumeVToVz.HeaderText = "V/Vz";
            this.attitudeVolumeVToVz.Name = "attitudeVolumeVToVz";
            // 
            // attitudeVolumeInPowerVToVz
            // 
            this.attitudeVolumeInPowerVToVz.HeaderText = "(V/Vz)^n2";
            this.attitudeVolumeInPowerVToVz.Name = "attitudeVolumeInPowerVToVz";
            // 
            // pressureOnLineExpansion
            // 
            this.pressureOnLineExpansion.HeaderText = "p, МПа";
            this.pressureOnLineExpansion.Name = "pressureOnLineExpansion";
            // 
            // FormCreateDiagramProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 637);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "FormCreateDiagramProcess";
            this.Text = "Діаграма робочого процесу для цилінндра";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
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
    }
}