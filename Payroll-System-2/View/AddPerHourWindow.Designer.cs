namespace Payroll_System_2
{
    partial class AddPerHourWindow
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
            this.tbWorkerName = new System.Windows.Forms.TextBox();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudPayPerHour = new System.Windows.Forms.NumericUpDown();
            this.nudNormHours = new System.Windows.Forms.NumericUpDown();
            this.nudExtraPay = new System.Windows.Forms.NumericUpDown();
            this.AddHourWorker = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudPayPerHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNormHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExtraPay)).BeginInit();
            this.SuspendLayout();
            // 
            // tbWorkerName
            // 
            this.tbWorkerName.Location = new System.Drawing.Point(375, 81);
            this.tbWorkerName.Name = "tbWorkerName";
            this.tbWorkerName.Size = new System.Drawing.Size(151, 27);
            this.tbWorkerName.TabIndex = 0;
            this.tbWorkerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbSex
            // 
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Items.AddRange(new object[] {
            "Мужчина",
            "Женщина"});
            this.cbSex.Location = new System.Drawing.Point(375, 133);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(151, 28);
            this.cbSex.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Имя сотрудника";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Пол сотрудника";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Зарплата за 1 час";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(303, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Нормальное количество часов за 15 дней";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(174, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Зарплата за экстра часы";
            // 
            // nudPayPerHour
            // 
            this.nudPayPerHour.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudPayPerHour.Location = new System.Drawing.Point(376, 192);
            this.nudPayPerHour.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudPayPerHour.Name = "nudPayPerHour";
            this.nudPayPerHour.Size = new System.Drawing.Size(150, 27);
            this.nudPayPerHour.TabIndex = 10;
            this.nudPayPerHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudNormHours
            // 
            this.nudNormHours.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudNormHours.Location = new System.Drawing.Point(375, 243);
            this.nudNormHours.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nudNormHours.Name = "nudNormHours";
            this.nudNormHours.Size = new System.Drawing.Size(150, 27);
            this.nudNormHours.TabIndex = 11;
            this.nudNormHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudExtraPay
            // 
            this.nudExtraPay.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudExtraPay.Location = new System.Drawing.Point(375, 293);
            this.nudExtraPay.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudExtraPay.Name = "nudExtraPay";
            this.nudExtraPay.Size = new System.Drawing.Size(150, 27);
            this.nudExtraPay.TabIndex = 12;
            this.nudExtraPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddHourWorker
            // 
            this.AddHourWorker.Location = new System.Drawing.Point(22, 357);
            this.AddHourWorker.Name = "AddHourWorker";
            this.AddHourWorker.Size = new System.Drawing.Size(719, 96);
            this.AddHourWorker.TabIndex = 13;
            this.AddHourWorker.Text = "Добавить";
            this.AddHourWorker.UseVisualStyleBackColor = true;
            this.AddHourWorker.Click += new System.EventHandler(this.AddHourWorker_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(147, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(450, 28);
            this.label6.TabIndex = 14;
            this.label6.Text = "Добавление сотрудника с почасовой оплатой";
            // 
            // AddPerHourWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 477);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AddHourWorker);
            this.Controls.Add(this.nudExtraPay);
            this.Controls.Add(this.nudNormHours);
            this.Controls.Add(this.nudPayPerHour);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSex);
            this.Controls.Add(this.tbWorkerName);
            this.Name = "AddPerHourWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPerHourWorker";
            ((System.ComponentModel.ISupportInitialize)(this.nudPayPerHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNormHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExtraPay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbWorkerName;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudPayPerHour;
        private System.Windows.Forms.NumericUpDown nudNormHours;
        private System.Windows.Forms.NumericUpDown nudExtraPay;
        private System.Windows.Forms.Button AddHourWorker;
        private System.Windows.Forms.Label label6;
    }
}