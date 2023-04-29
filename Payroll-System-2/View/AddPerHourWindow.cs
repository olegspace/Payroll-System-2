using Payroll_system;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_System_2
{
    public partial class AddPerHourWindow : Form
    {
        PerHourWorker hourWorker;
        public AddPerHourWindow()
        {
            InitializeComponent();
        }

        private void AddHourWorker_Click(object sender, EventArgs e)
        {
            int start_pay = (int)nudPayPerHour.Value;
            int extra_pay = (int)nudExtraPay.Value;
            int norm_hours = (int)nudNormHours.Value;

            if (!Validate_per_hour(tbWorkerName.Text, cbSex.Text, start_pay, 
                norm_hours,extra_pay, out hourWorker))
            {
                return;
            }

            MainWindow.Company.AddWorkerPerHour(hourWorker);
            Close();
        }

        private bool Validate_per_hour(string name, string sex, int start_pay, int norm_hours, int extra_pay, out PerHourWorker hourWorker)
        {
            hourWorker = null;

            if (name == null || name.Length == 0)
            {
                MessageBox.Show("Неверное имя! (ввели пустую строку)", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }


            if (sex == null || !(sex == "М" || sex == "Ж" || sex == "Мужчина" || sex == "Женщина"))
            {
                MessageBox.Show("Выберите пол между двух предложенных", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (start_pay == 0)
            {
                MessageBox.Show("Зарплата не может быть равна нулю!", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (norm_hours == 0)
            {
                MessageBox.Show("Количество часов не может равно нулю!", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (extra_pay < start_pay)
            {
                MessageBox.Show("Зарплата за дополнительные часы не может быть меньше обычной зарплаты!", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            hourWorker = new PerHourWorker(name, sex, start_pay, norm_hours, extra_pay);

            return true;
        }
    }
}
