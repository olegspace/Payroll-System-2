namespace Payroll_system
{
    public class PercentWorker : Worker
    {        
        private int fixpay, perc, sold;
        public int Fixpay
        {
            get { return fixpay; }
            set { fixpay = value; }
        }
        public int Perc
        {
            get { return perc; }
            set { perc = value; }
        }
        public int Sold
        {
            get { return sold; }
            set { sold = value; }
        }
        public PercentWorker()
        {
            fixpay = 0;
            perc = 0;
            sold = 0;
        }
        public PercentWorker(int fixpay, int perc)
        {
            this.fixpay = fixpay;
            this.perc = perc;
            sold = 0;
        }
        public PercentWorker(string name, string sex, int fixpay, int perc) : base(name, sex)
        {
            this.fixpay = fixpay;
            this.perc = perc;
            sold = 0;
        }
        public override string Worker_type()
        {
            return "Работник с фиксированной оплатой";
        }
        public void Sell(int money) { Sold += money; }
        public int Count()
        {
            float res;

            res = (float)fixpay + (sold * perc / 100);

            Sold = 0;

            return (int)res;
        }
    }
}
