namespace Payroll_System_2
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btSimulation = new System.Windows.Forms.Button();
            this.btAddPerHour = new System.Windows.Forms.Button();
            this.btAddPercent = new System.Windows.Forms.Button();
            this.btDeleteWorker = new System.Windows.Forms.Button();
            this.labelAdd = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btShowWorkers = new System.Windows.Forms.Button();
            this.tbWorkerForDelete = new System.Windows.Forms.TextBox();
            this.tbAllWorkers = new System.Windows.Forms.TextBox();
            this.lbNumDays = new System.Windows.Forms.Label();
            this.lbDaysGone = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(449, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Система расчёта зарплаты";
            // 
            // btSimulation
            // 
            this.btSimulation.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btSimulation.Location = new System.Drawing.Point(693, 515);
            this.btSimulation.Name = "btSimulation";
            this.btSimulation.Size = new System.Drawing.Size(515, 68);
            this.btSimulation.TabIndex = 1;
            this.btSimulation.Text = "Симуляция работы";
            this.btSimulation.UseVisualStyleBackColor = true;
            this.btSimulation.Click += new System.EventHandler(this.Simulation_Click);
            // 
            // btAddPerHour
            // 
            this.btAddPerHour.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btAddPerHour.Location = new System.Drawing.Point(713, 215);
            this.btAddPerHour.Name = "btAddPerHour";
            this.btAddPerHour.Size = new System.Drawing.Size(187, 67);
            this.btAddPerHour.TabIndex = 2;
            this.btAddPerHour.Text = "Добавить";
            this.btAddPerHour.UseVisualStyleBackColor = true;
            this.btAddPerHour.Click += new System.EventHandler(this.AddPerHour_Click);
            // 
            // btAddPercent
            // 
            this.btAddPercent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btAddPercent.Location = new System.Drawing.Point(1009, 215);
            this.btAddPercent.Name = "btAddPercent";
            this.btAddPercent.Size = new System.Drawing.Size(187, 67);
            this.btAddPercent.TabIndex = 3;
            this.btAddPercent.Text = "Добавить";
            this.btAddPercent.UseVisualStyleBackColor = true;
            this.btAddPercent.Click += new System.EventHandler(this.AddPercent_Click);
            // 
            // btDeleteWorker
            // 
            this.btDeleteWorker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btDeleteWorker.Location = new System.Drawing.Point(848, 380);
            this.btDeleteWorker.Name = "btDeleteWorker";
            this.btDeleteWorker.Size = new System.Drawing.Size(214, 77);
            this.btDeleteWorker.TabIndex = 4;
            this.btDeleteWorker.Text = "Удалить работника по имени";
            this.btDeleteWorker.UseVisualStyleBackColor = true;
            this.btDeleteWorker.Click += new System.EventHandler(this.DeleteWorker_Click);
            // 
            // labelAdd
            // 
            this.labelAdd.AutoSize = true;
            this.labelAdd.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAdd.Location = new System.Drawing.Point(798, 101);
            this.labelAdd.Name = "labelAdd";
            this.labelAdd.Size = new System.Drawing.Size(315, 38);
            this.labelAdd.TabIndex = 5;
            this.labelAdd.Text = "Добавление работника";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(703, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "С почасовой оплатой";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(968, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "С фиксированной + процент";
            // 
            // btShowWorkers
            // 
            this.btShowWorkers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btShowWorkers.Location = new System.Drawing.Point(29, 52);
            this.btShowWorkers.Name = "btShowWorkers";
            this.btShowWorkers.Size = new System.Drawing.Size(187, 67);
            this.btShowWorkers.TabIndex = 9;
            this.btShowWorkers.Text = "Вывести список сотрудников";
            this.btShowWorkers.UseVisualStyleBackColor = true;
            this.btShowWorkers.Click += new System.EventHandler(this.btShowWorkers_Click);
            // 
            // tbWorkerForDelete
            // 
            this.tbWorkerForDelete.Location = new System.Drawing.Point(862, 347);
            this.tbWorkerForDelete.Name = "tbWorkerForDelete";
            this.tbWorkerForDelete.Size = new System.Drawing.Size(187, 27);
            this.tbWorkerForDelete.TabIndex = 10;
            // 
            // tbAllWorkers
            // 
            this.tbAllWorkers.Location = new System.Drawing.Point(29, 146);
            this.tbAllWorkers.Multiline = true;
            this.tbAllWorkers.Name = "tbAllWorkers";
            this.tbAllWorkers.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbAllWorkers.Size = new System.Drawing.Size(589, 437);
            this.tbAllWorkers.TabIndex = 12;
            // 
            // lbNumDays
            // 
            this.lbNumDays.AutoSize = true;
            this.lbNumDays.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNumDays.Location = new System.Drawing.Point(1259, 20);
            this.lbNumDays.Name = "lbNumDays";
            this.lbNumDays.Size = new System.Drawing.Size(22, 25);
            this.lbNumDays.TabIndex = 13;
            this.lbNumDays.Text = "0";
            // 
            // lbDaysGone
            // 
            this.lbDaysGone.AutoSize = true;
            this.lbDaysGone.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDaysGone.Location = new System.Drawing.Point(1101, 20);
            this.lbDaysGone.Name = "lbDaysGone";
            this.lbDaysGone.Size = new System.Drawing.Size(152, 25);
            this.lbDaysGone.TabIndex = 14;
            this.lbDaysGone.Text = "Прошедшие дни:";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 616);
            this.Controls.Add(this.lbDaysGone);
            this.Controls.Add(this.lbNumDays);
            this.Controls.Add(this.tbAllWorkers);
            this.Controls.Add(this.tbWorkerForDelete);
            this.Controls.Add(this.btShowWorkers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelAdd);
            this.Controls.Add(this.btDeleteWorker);
            this.Controls.Add(this.btAddPercent);
            this.Controls.Add(this.btAddPerHour);
            this.Controls.Add(this.btSimulation);
            this.Controls.Add(this.label1);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Никита Копп";
            this.Activated += new System.EventHandler(this.MainWindow_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSimulation;
        private System.Windows.Forms.Button btAddPerHour;
        private System.Windows.Forms.Button btAddPercent;
        private System.Windows.Forms.Button btDeleteWorker;
        private System.Windows.Forms.Label labelAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btShowWorkers;
        private System.Windows.Forms.TextBox tbWorkerForDelete;
        private System.Windows.Forms.TextBox tbAllWorkers;
        private System.Windows.Forms.Label lbNumDays;
        private System.Windows.Forms.Label lbDaysGone;
    }
}
