using Payroll_system;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_System_2
{
    public class ViewModel
    {
        Company company = new Company();
        PerHourWorker perHourWorker = new PerHourWorker();
        PercentWorker percentWorker = new PercentWorker();
        public void AddHourWorker()
        {
            MessageBox.Show("Добавление почасового работника");
        }
    }
}
