namespace Payroll_System_2
{
    partial class AddPercentWindow
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
            this.label6 = new System.Windows.Forms.Label();
            this.btAddPercentWorker = new System.Windows.Forms.Button();
            this.nudPerc = new System.Windows.Forms.NumericUpDown();
            this.nudFixPay = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.tbWorkerName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudPerc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFixPay)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(97, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(631, 28);
            this.label6.TabIndex = 26;
            this.label6.Text = "Добавление сотрудника с фиксированной оплатой и процентом\r\n";
            // 
            // btAddPercentWorker
            // 
            this.btAddPercentWorker.Location = new System.Drawing.Point(41, 351);
            this.btAddPercentWorker.Name = "btAddPercentWorker";
            this.btAddPercentWorker.Size = new System.Drawing.Size(719, 96);
            this.btAddPercentWorker.TabIndex = 25;
            this.btAddPercentWorker.Text = "Добавить";
            this.btAddPercentWorker.UseVisualStyleBackColor = true;
            this.btAddPercentWorker.Click += new System.EventHandler(this.btAddPercentWorker_Click);
            // 
            // nudPerc
            // 
            this.nudPerc.Location = new System.Drawing.Point(399, 259);
            this.nudPerc.Name = "nudPerc";
            this.nudPerc.Size = new System.Drawing.Size(150, 27);
            this.nudPerc.TabIndex = 23;
            this.nudPerc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudFixPay
            // 
            this.nudFixPay.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudFixPay.Location = new System.Drawing.Point(400, 209);
            this.nudFixPay.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudFixPay.Name = "nudFixPay";
            this.nudFixPay.Size = new System.Drawing.Size(150, 27);
            this.nudFixPay.TabIndex = 22;
            this.nudFixPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudFixPay.ThousandsSeparator = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Процент от продаж";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Фиксированная оплата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Пол сотрудника";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Имя сотрудника";
            // 
            // cbSex
            // 
            this.cbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Items.AddRange(new object[] {
            "Мужчина",
            "Женщина"});
            this.cbSex.Location = new System.Drawing.Point(399, 149);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(151, 28);
            this.cbSex.TabIndex = 16;
            // 
            // tbWorkerName
            // 
            this.tbWorkerName.Location = new System.Drawing.Point(399, 99);
            this.tbWorkerName.Name = "tbWorkerName";
            this.tbWorkerName.Size = new System.Drawing.Size(151, 27);
            this.tbWorkerName.TabIndex = 15;
            this.tbWorkerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddPercentWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btAddPercentWorker);
            this.Controls.Add(this.nudPerc);
            this.Controls.Add(this.nudFixPay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSex);
            this.Controls.Add(this.tbWorkerName);
            this.Name = "AddPercentWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPercentWindow";
            ((System.ComponentModel.ISupportInitialize)(this.nudPerc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFixPay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btAddPercentWorker;
        private System.Windows.Forms.NumericUpDown nudPerc;
        private System.Windows.Forms.NumericUpDown nudFixPay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.TextBox tbWorkerName;
    }
}