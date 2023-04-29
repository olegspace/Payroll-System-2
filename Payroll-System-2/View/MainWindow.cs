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
            SimulationWindow simulationWindow = new SimulationWindow();
            simulationWindow.ShowDialog();
        }

    }
}
