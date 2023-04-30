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
    public partial class MainWindow : Form
    {
        ViewModel viewModel = new ViewModel();
        public static Company Company = new Company();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void AddPerHour_Click(object sender, EventArgs e)
        {
            AddPerHourWindow addPerHourWindow = new AddPerHourWindow();
            addPerHourWindow.ShowDialog();
        }

        private void AddPercent_Click(object sender, EventArgs e)
        {
            AddPercentWindow addPercentWindow = new AddPercentWindow();
            addPercentWindow.ShowDialog();
        }
        private void Simulation_Click(object sender, EventArgs e)
        {
            if (Company.percent_workers.Count != 0 || Company.per_hour_workers.Count != 0)
            {
                SimulationWindow simulationWindow = new SimulationWindow();
                simulationWindow.ShowDialog();
            }
            else
            {
                MessageBox.Show("В компании пока нет работников", "Попытка симуляции", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btShowWorkers_Click(object sender, EventArgs e)
        {
            tbAllWorkers.Text = string.Empty;

            if (Company.percent_workers.Count == 0 && Company.per_hour_workers.Count == 0)
            {
                tbAllWorkers.Text += "Нет работников в предприятии";
            }
            else
            {

                for (int j = 0; j < Company.per_hour_workers.Count; j++)
                {
                    tbAllWorkers.Text += Company.per_hour_workers[j].Worker_type() + "\r\n";
                    tbAllWorkers.Text += $"Имя: {Company.per_hour_workers[j].Name}\r\n";
                    tbAllWorkers.Text += $"Пол: {Company.per_hour_workers[j].ReturnSex()}\r\n";
                    tbAllWorkers.Text += $"Обычная оплата в час: {Company.per_hour_workers[j].HoursPay} рублей\r\n";
                    tbAllWorkers.Text += $"Количество обычных часов в день: {Company.per_hour_workers[j].NormHours} часов\r\n";
                    tbAllWorkers.Text += $"Сверхурочная оплата за час: {Company.per_hour_workers[j].ExtraPay} рублей\r\n";
                    tbAllWorkers.Text += $"Уже проработано: {Company.per_hour_workers[j].Hours} часов\r\n\r\n";
                }
                
                for (int j = 0; j < Company.percent_workers.Count; j++)
                {
                    tbAllWorkers.Text += Company.percent_workers[j].Worker_type() + "\r\n";
                    tbAllWorkers.Text += $"Имя: {Company.percent_workers[j].Name}\r\n";
                    tbAllWorkers.Text += $"Пол: {Company.percent_workers[j].ReturnSex()}\r\n";
                    tbAllWorkers.Text += $"Фиксированная оплата: {Company.percent_workers[j].Fixpay} рублей\r\n";
                    tbAllWorkers.Text += $"Процент: {Company.percent_workers[j].Perc} %\r\n";
                    tbAllWorkers.Text += $"Уже продано: {Company.percent_workers[j].Sold} рублей\r\n\r\n";
                }
            }
        }

        private void DeleteWorker_Click(object sender, EventArgs e)
        {
            string workerName = tbWorkerForDelete.Text;
            if (workerName.Length != 0)
            {
                if (Company.DeleteWorker(workerName))
                {
                    MessageBox.Show($"Работник с именем {workerName} успешно удалён.", "Удаление работника", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show($"Работника с именем {workerName} не существует.", "Удаление работника", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Вы ввели пустую строку", "Удаление работника", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MainWindow_Activated(object sender, EventArgs e)
        {
            lbNumDays.Text = Company.Days.ToString();
        }
    }
}
