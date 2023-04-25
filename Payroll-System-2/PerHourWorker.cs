namespace Payroll_system
{
    public class PerHourWorker : Worker
    {       
        private int hours, hours_pay, norm_hours, extra_pay;
        public int Hours 
        {
            get { return hours; }
            set { hours = value; }
        }
        public int HoursPay 
        {
            get { return hours_pay; }
            set { hours_pay = value; }
        }
        public int NormHours
        {
            get { return norm_hours; }
            set { norm_hours = value; }
        }
        public int ExtraPay
        {
            get { return extra_pay; }
            set { extra_pay = value; }
        }

        public PerHourWorker()
        {
            hours = 0;
            hours_pay = 0;
            norm_hours = 0;
            extra_pay = 0;
        }
        public PerHourWorker(int hours_pay,
            int norm_hours, int extra_pay) : base()
        {
            hours = 0;
            this.hours_pay = hours_pay;
            this.norm_hours = norm_hours;
            this.extra_pay = extra_pay;
        }
        public PerHourWorker(string name, string sex, int hours_pay, 
            int norm_hours, int extra_pay) : base( name, sex)
        {            
            hours = 0;
            this.hours_pay = hours_pay;
            this.norm_hours = norm_hours;
            this.extra_pay = extra_pay;
        }
        public override void Worker_type()
        {
            //Console.WriteLine("Работник с почасовой оплатой");
        }
        public void Work(int worked) { Hours += worked; }

        public int Count()
        {
            int res, extra;

            if (Hours <= NormHours)
            {
                res = Hours * HoursPay;
            }
            else
            {
                extra = Hours - NormHours;
                res = (NormHours * HoursPay) + (extra * ExtraPay);
            }

            Hours = 0;

            return res;
        }
    }
}
