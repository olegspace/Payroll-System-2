using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Payroll_system
{
    public class Company
    {
        private int days;
        public int Days 
        {
            get { return days; }
            set { days = value; }
        }

        public List<PerHourWorker> per_hour_workers;
        public List<PercentWorker> percent_workers;

        public Company()
        {
            days = 0;
            per_hour_workers = new List<PerHourWorker>();
            percent_workers = new List<PercentWorker>();
        }
        public void AddWorkerPerHour(PerHourWorker worker)
        {
            per_hour_workers.Add(worker); 
        }
        public void AddPercentWorker(PercentWorker worker)
        {
            percent_workers.Add(worker);
        }
        public void Simulation(int days_sim)
        {
            int start = 0, temp;
            Random rnd = new Random();

            Console.Clear();

            for (int i = 1; i < days_sim + 1; i++)
            {
                days++;

                Print_day(i);

                start = Get_day_type();

                for (int j = 0; j < per_hour_workers.Count; j++)
                {

                    per_hour_workers[j].Worker_type();
                    Console.Write($"{per_hour_workers[j].Name} проработал/а ");
                    
                    temp = rnd.Next(1, 3) + start;
                    per_hour_workers[j].Work(temp);

                    Console.WriteLine($"{temp} часов");
                }
                for (int l = 0; l < percent_workers.Count; l++)
                {
                    percent_workers[l].Worker_type();
                    Console.Write($"{percent_workers[l].Name} продал/a на ");

                    temp = start * (100 + rnd.Next(1, 50));
                    percent_workers[l].Sell(temp);
                    Console.WriteLine($"{temp} рублей");
                }
                Console.Write("Нажмите любую клавишу для продолжения...");
                Console.ReadKey(); //Пауза
                Console.Clear();  //Очистка консоли

                if (days != 0 && days % 15 == 0)
                {
                    PayDay();
                }
            }           
        }
        public void SimulationWithoutPause(int days_sim)
        {
            int start = 0, temp;
            Random rnd = new Random();            

            for (int i = 1; i < days_sim + 1; i++)
            {
                days++;

                Print_day(i);

                start = Get_day_type();

                for (int j = 0; j < per_hour_workers.Count; j++)
                {

                    per_hour_workers[j].Worker_type();
                    Console.Write($"{per_hour_workers[j].Name} проработал/а ");

                    temp = rnd.Next(1, 3) + start;
                    per_hour_workers[j].Work(temp);

                    Console.WriteLine($"{temp} часов");
                }
                for (int l = 0; l < percent_workers.Count; l++)
                {
                    percent_workers[l].Worker_type();
                    Console.Write($"{percent_workers[l].Name} продал/a на ");

                    temp = start * (100 + rnd.Next(1, 50));
                    percent_workers[l].Sell(temp);
                    Console.WriteLine($"{temp} рублей");
                }
                Console.Write("Нажмите любую клавишу для продолжения...");
                

                if (days != 0 && days % 15 == 0)
                {
                    PayDayWithouPause();
                }
            }
        }

        public void Show_all_workers()
        {
            if (percent_workers.Count == 0 && per_hour_workers.Count == 0)
            {
                Console.WriteLine("Нет работников в предприятии");                
            }
            else
            {
                for (int j = 0; j < per_hour_workers.Count; j++)
                {
                    per_hour_workers[j].Worker_type();
                    Console.WriteLine($"Имя: {per_hour_workers[j].Name}");
                    Console.WriteLine($"Пол: {per_hour_workers[j].ReturnSex()}");
                    Console.WriteLine($"Обычная оплата в час: {per_hour_workers[j].HoursPay} рублей");
                    Console.WriteLine($"Количество обычных часов в день: {per_hour_workers[j].NormHours} часов");
                    Console.WriteLine($"Сверхурочная оплата за час: {per_hour_workers[j].ExtraPay} рублей");
                    Console.WriteLine($"Уже проработано: {per_hour_workers[j].Hours} часов\n");
                }

                for (int j = 0; j < percent_workers.Count; j++)
                {
                    percent_workers[j].Worker_type();
                    Console.WriteLine($"Имя: {percent_workers[j].Name}");
                    Console.WriteLine($"Пол: {percent_workers[j].ReturnSex()}");
                    Console.WriteLine($"Фиксированная оплата: {percent_workers[j].Fixpay} рублей");
                    Console.WriteLine($"Процент: {percent_workers[j].Perc} %");
                    Console.WriteLine($"Уже продано: {percent_workers[j].Sold} рублей\n");
                }
            }
            Console.Write("Нажмите любую клавишу для продолжения...");
            Console.ReadKey(); //Пауза
            Console.Clear();  //Очистка консоли
        }
        public bool DeleteWorker(string workerName)
        {
            for (int i = 0; i < per_hour_workers.Count; i++)
            {
                if (per_hour_workers[i].Name == workerName)
                {
                    per_hour_workers.RemoveAt(i);
                    return true;
                }
            }
            for (int i = 0; i < percent_workers.Count; i++)
            {
                if (percent_workers[i].Name == workerName)
                {
                    percent_workers.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public void DeleteUserName()
        {
            string name = "";

            Console.WriteLine("Введите имя и нажмите enter");

            name = Console.ReadLine();  
  
            if (DeleteWorker(name))            
                Console.WriteLine($"{name} был/а уволен/а");
            else 
                Console.WriteLine($"Работник с именем: {name} не найден.");

            Console.Write("Нажмите любую клавишу для продолжения...");
            Console.ReadKey(); //Пауза
        }
        private int Get_day_type()
        {
            Random rnd = new Random();
            int day_type, start;

            day_type = rnd.Next(1, 4);

            if (day_type == 1)
            {
                start = 3;
                Console.WriteLine("Сегодня незанятой день, продажи низкие и работники раньше уходят домой");
            }
            else if (day_type == 2)
            {
                start = 5;
                Console.WriteLine("Сегодня обычный день, работники остаются обычное количество часов и продажи средние");
            }
            else
            {
                start = 8;
                Console.WriteLine("Сегодня загруженный день, работники остаются до поздна и продажи высокие");
            }
            return start;
        }
        private void Print_day(int day)
        {
            Console.WriteLine("              -----------------------");
            Console.WriteLine("                       День {0}       ", day);
            Console.WriteLine("              -----------------------\n");
        }
        private void Pay_day_print()
        {
            Console.WriteLine("  ----------------  ");
            Console.WriteLine(" |   Зарплата !!! | ");
            Console.WriteLine("  ----------------  ");
        }

        private void PayDay()
        {
            Pay_day_print();
            for (int j = 0; j < per_hour_workers.Count; j++)
            {
                Console.Write($"{per_hour_workers[j].Name} проработал/а {per_hour_workers[j].Hours} часов");
                Console.WriteLine($" получает {per_hour_workers[j].Count()} рублей");
            }
            for (int l = 0; l < percent_workers.Count; l++)
            {
                Console.Write($"{percent_workers[l].Name} продал/а {percent_workers[l].Sold} рублей");
                Console.WriteLine($" получает {percent_workers[l].Count()} рублей");
            }
            Console.Write("Нажмите любую клавишу для продолжения...");
            Console.ReadKey(); //Пауза
            Console.Clear();  //Очистка консоли
        }
        private void PayDayWithouPause()
        {
            Pay_day_print();
            for (int j = 0; j < per_hour_workers.Count; j++)
            {
                Console.Write($"{per_hour_workers[j].Name} проработал/а {per_hour_workers[j].Hours} часов");
                Console.WriteLine($" получает {per_hour_workers[j].Count()} рублей");
            }
            for (int l = 0; l < percent_workers.Count; l++)
            {
                Console.Write($"{percent_workers[l].Name} продал/а {percent_workers[l].Sold} рублей");
                Console.WriteLine($" получает {percent_workers[l].Count()} рублей");
            }
            Console.Write("Нажмите любую клавишу для продолжения...");            
        }
    }
}
