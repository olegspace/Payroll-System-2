using Payroll_System_2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Payroll_System_2
{
    public partial class AddPercentWindow : Form
    {
        PercentWorker percentWorker;
        public AddPercentWindow()
        {
            InitializeComponent();
        }

        private void btAddPercentWorker_Click(object sender, EventArgs e)
        {
            int fix_pay = (int)nudFixPay.Value;
            int perc = (int)nudPerc.Value;
            

            if (!Validate_percent(tbWorkerName.Text, cbSex.Text, fix_pay,
                perc,  out percentWorker))
            {   
                return;
            }

            MainWindow.Company.AddPercentWorker(percentWorker);
            Close();
        }

        static private bool Validate_percent(string name, string sex, int fixpay, int perc, out PercentWorker percentWorker)
        {
            percentWorker = null;

            if (name == null || name.Length == 0)
            {
                MessageBox.Show("Неверное имя! (ввели пустую строку)", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (sex == null || !(sex == "М" || sex == "Ж" || sex == "Мужской" || sex == "Женский" || sex == "Мужчина" || sex == "Женщина"))
            {
                MessageBox.Show("Выберите пол между двух предложенных", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (fixpay == 0)
            {
                MessageBox.Show("Фиксированна оплата не может быть равна нулю!", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            percentWorker = new PercentWorker(name, sex, fixpay, perc);

            return true;
        } 
    }
}
