namespace Payroll_System_2
{
    partial class SimulationWindow
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
            this.tbSimulation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNumDays = new System.Windows.Forms.Label();
            this.btStartSimulation = new System.Windows.Forms.Button();
            this.btNextDay = new System.Windows.Forms.Button();
            this.nudNumDays = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumDays)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSimulation
            // 
            this.tbSimulation.Location = new System.Drawing.Point(94, 95);
            this.tbSimulation.Multiline = true;
            this.tbSimulation.Name = "tbSimulation";
            this.tbSimulation.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbSimulation.Size = new System.Drawing.Size(739, 271);
            this.tbSimulation.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(229, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Симуляция работы компании\r\n";
            // 
            // labelNumDays
            // 
            this.labelNumDays.AutoSize = true;
            this.labelNumDays.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNumDays.Location = new System.Drawing.Point(380, 435);
            this.labelNumDays.Name = "labelNumDays";
            this.labelNumDays.Size = new System.Drawing.Size(170, 28);
            this.labelNumDays.TabIndex = 3;
            this.labelNumDays.Text = "Количество дней";
            // 
            // btStartSimulation
            // 
            this.btStartSimulation.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btStartSimulation.Location = new System.Drawing.Point(314, 524);
            this.btStartSimulation.Name = "btStartSimulation";
            this.btStartSimulation.Size = new System.Drawing.Size(311, 45);
            this.btStartSimulation.TabIndex = 4;
            this.btStartSimulation.Text = "Начать симуляцию";
            this.btStartSimulation.UseVisualStyleBackColor = true;
            this.btStartSimulation.Click += new System.EventHandler(this.btStartSimulation_Click);
            // 
            // btNextDay
            // 
            this.btNextDay.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btNextDay.Location = new System.Drawing.Point(365, 387);
            this.btNextDay.Name = "btNextDay";
            this.btNextDay.Size = new System.Drawing.Size(217, 45);
            this.btNextDay.TabIndex = 5;
            this.btNextDay.Text = "Следующий день";
            this.btNextDay.UseVisualStyleBackColor = true;
            this.btNextDay.Visible = false;
            this.btNextDay.Click += new System.EventHandler(this.btNextDay_Click);
            // 
            // nudNumDays
            // 
            this.nudNumDays.Location = new System.Drawing.Point(400, 468);
            this.nudNumDays.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.nudNumDays.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumDays.Name = "nudNumDays";
            this.nudNumDays.Size = new System.Drawing.Size(150, 27);
            this.nudNumDays.TabIndex = 6;
            this.nudNumDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudNumDays.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SimulationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.nudNumDays);
            this.Controls.Add(this.btNextDay);
            this.Controls.Add(this.btStartSimulation);
            this.Controls.Add(this.labelNumDays);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSimulation);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SimulationWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimulationWindow";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumDays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSimulation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNumDays;
        private System.Windows.Forms.Button btStartSimulation;
        private System.Windows.Forms.Button btNextDay;
        private System.Windows.Forms.NumericUpDown nudNumDays;
    }
}