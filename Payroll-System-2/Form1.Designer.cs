﻿namespace Payroll_System_2
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.AddPerHour = new System.Windows.Forms.Button();
            this.AddPercent = new System.Windows.Forms.Button();
            this.DeleteWorker = new System.Windows.Forms.Button();
            this.labelAdd = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(692, 515);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(515, 68);
            this.button1.TabIndex = 1;
            this.button1.Text = "Начать симуляцию";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AddPerHour
            // 
            this.AddPerHour.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddPerHour.Location = new System.Drawing.Point(713, 215);
            this.AddPerHour.Name = "AddPerHour";
            this.AddPerHour.Size = new System.Drawing.Size(187, 67);
            this.AddPerHour.TabIndex = 2;
            this.AddPerHour.Text = "Добавить";
            this.AddPerHour.UseVisualStyleBackColor = true;
            this.AddPerHour.Click += new System.EventHandler(this.AddPerHour_Click);
            // 
            // AddPercent
            // 
            this.AddPercent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddPercent.Location = new System.Drawing.Point(1009, 215);
            this.AddPercent.Name = "AddPercent";
            this.AddPercent.Size = new System.Drawing.Size(187, 67);
            this.AddPercent.TabIndex = 3;
            this.AddPercent.Text = "Добавить";
            this.AddPercent.UseVisualStyleBackColor = true;
            this.AddPercent.Click += new System.EventHandler(this.AddPercent_Click);
            // 
            // DeleteWorker
            // 
            this.DeleteWorker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteWorker.Location = new System.Drawing.Point(848, 380);
            this.DeleteWorker.Name = "DeleteWorker";
            this.DeleteWorker.Size = new System.Drawing.Size(214, 77);
            this.DeleteWorker.TabIndex = 4;
            this.DeleteWorker.Text = "Удалить работника по имени";
            this.DeleteWorker.UseVisualStyleBackColor = true;
            // 
            // labelAdd
            // 
            this.labelAdd.AutoSize = true;
            this.labelAdd.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAdd.Location = new System.Drawing.Point(798, 102);
            this.labelAdd.Name = "labelAdd";
            this.labelAdd.Size = new System.Drawing.Size(315, 38);
            this.labelAdd.TabIndex = 5;
            this.labelAdd.Text = "Добавление работника";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(701, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "С почасовой оплатой";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(969, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "С фиксированной + процент";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(29, 139);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(642, 444);
            this.listBox1.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(29, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 67);
            this.button2.TabIndex = 9;
            this.button2.Text = "Вывести список сотрудников";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(862, 347);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 27);
            this.textBox1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 616);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelAdd);
            this.Controls.Add(this.DeleteWorker);
            this.Controls.Add(this.AddPercent);
            this.Controls.Add(this.AddPerHour);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Никита Копп";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AddPerHour;
        private System.Windows.Forms.Button AddPercent;
        private System.Windows.Forms.Button DeleteWorker;
        private System.Windows.Forms.Label labelAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
    }
}