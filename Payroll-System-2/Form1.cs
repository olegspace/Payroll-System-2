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
    public partial class Form1 : Form
    {
        ViewModel viewModel = new ViewModel();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void AddPerHour_Click(object sender, EventArgs e)
        {
            AddPerHourWindow form = new AddPerHourWindow();
            form.ShowDialog();
        }

        private void AddPercent_Click(object sender, EventArgs e)
        {
            AddPercentWindow form = new AddPercentWindow();
            form.ShowDialog();
        }
    }
}
