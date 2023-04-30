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

namespace Payroll_System_2
{
    public partial class SimulationWindow : Form
    {
        private int daysWork = 0;
        private int currentDay = 0;
        public SimulationWindow()
        {
            InitializeComponent();
            daysWork = 0;
            currentDay = 0;
        }

        private void btStartSimulation_Click(object sender, EventArgs e)
        {
            daysWork = (int)nudNumDays.Value;
            Simulation();
            btNextDay.Visible = true;
            btStartSimulation.Hide();
            nudNumDays.Hide();
            labelNumDays.Hide();
        }

        private void btNextDay_Click(object sender, EventArgs e)
        {
            if (currentDay < daysWork)
            {
                Simulation();
            }
            else
            {
                MessageBox.Show($"Симуляция работы компании в течение {daysWork} дней завершена.");
                Close();
            }
        }
        private void Simulation()
        {
            int start, temp;
            Random rnd = new Random();

            currentDay++;
            tbSimulation.Text = string.Empty;
            MainWindow.Company.Days++;

            tbSimulation.Text += Print_day(currentDay);

            start = MainWindow.Company.Get_day_type();

            for (int j = 0; j < MainWindow.Company.per_hour_workers.Count; j++)
            {

                MainWindow.Company.per_hour_workers[j].Worker_type();
                tbSimulation.Text += $"{MainWindow.Company.per_hour_workers[j].Name} проработал/а ";

                temp = rnd.Next(1, 3) + start;
                MainWindow.Company.per_hour_workers[j].Work(temp);

                tbSimulation.Text += $"{temp} часов\r\n";
            }
            for (int l = 0; l < MainWindow.Company.percent_workers.Count; l++)
            {
                MainWindow.Company.percent_workers[l].Worker_type();
                tbSimulation.Text += $"{MainWindow.Company.percent_workers[l].Name} продал/a на ";

                temp = start * (100 + rnd.Next(1, 50));
                MainWindow.Company.percent_workers[l].Sell(temp);
                tbSimulation.Text += $"{temp} рублей\r\n";
            }               

            if (MainWindow.Company.Days != 0 && MainWindow.Company.Days % 15 == 0)
            {
                tbSimulation.Text = string.Empty;
                PayDay();
            }
        }

        private string Print_day(int day)
        {
            return "              -----------------------\r\n" +
            $"                       День {day}       \r\n" +
           "              -----------------------\r\n\r\n";
        }

        public void PayDay()
        {
            Pay_day_print();
            for (int j = 0; j < MainWindow.Company.per_hour_workers.Count; j++)
            {
                tbSimulation.Text += $"{MainWindow.Company.per_hour_workers[j].Name} проработал/а {MainWindow.Company.per_hour_workers[j].Hours} часов";
                tbSimulation.Text += $" получает {MainWindow.Company.per_hour_workers[j].Count()} рублей\r\n";
            }
            for (int l = 0; l < MainWindow.Company.percent_workers.Count; l++)
            {
                tbSimulation.Text += $"{MainWindow.Company.percent_workers[l].Name} продал/а {MainWindow.Company.percent_workers[l].Sold} рублей";
                tbSimulation.Text += $" получает {MainWindow.Company.percent_workers[l].Count()} рублей\r\n";
            }
        }

        private void Pay_day_print()
        {
            tbSimulation.Text += "  ----------------  \r\n";
            tbSimulation.Text += " |   Зарплата !!! | \r\n";
            tbSimulation.Text += "  ----------------  \r\n";
        }
    }
}
