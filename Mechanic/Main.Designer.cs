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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxQuantCylinder = new System.Windows.Forms.ComboBox();
            this.btnDrawDiagram = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(55, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(687, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "1 Побудова індикаторної діаграми робочого процесу двигуна ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(209, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Кількість циліндрів двигуна\r\n";
            // 
            // comboBoxQuantCylinder
            // 
            this.comboBoxQuantCylinder.FormattingEnabled = true;
            this.comboBoxQuantCylinder.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboBoxQuantCylinder.Location = new System.Drawing.Point(444, 53);
            this.comboBoxQuantCylinder.Name = "comboBoxQuantCylinder";
            this.comboBoxQuantCylinder.Size = new System.Drawing.Size(44, 21);
            this.comboBoxQuantCylinder.TabIndex = 2;
            this.comboBoxQuantCylinder.Text = "1";
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnDrawDiagram);
            this.Controls.Add(this.comboBoxQuantCylinder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Двигатели внутреннего сгорания";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxQuantCylinder;
        private System.Windows.Forms.Button btnDrawDiagram;
    }
}

