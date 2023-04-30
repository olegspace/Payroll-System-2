using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Payroll_system
{
    public class Worker
    {
        private string name;
        private string sex;
        public string Name
        {
            get { return name; }
            set 
            { 
                if (value != "")
                    name = value;
                else Console.WriteLine("Нельзя установить имя, как пустую строку");
            }
        }
        public string Sex
        {
            get { return sex; }
            set 
            { 
                if (value == "М" || value == "Мужской" || value == "Ж" || value == "Женский")
                    sex = value;
                else Console.WriteLine("Некорректная попытка установки пола");
            }
        }

        public virtual string Worker_type()  { return ""; }
        public Worker() 
        {
            name = "Не задано";
            sex = "Не задано";
        } 

        public Worker(string name, string sex)
        {
            Name = name;
            Sex = sex;
        }
        public string ReturnSex() 
        {
            string sex_full;
            if (Sex == "Ж" || Sex == "Женский")            
                sex_full = "Женщина";            
            else           
                sex_full = "Мужчина";
            
            return sex_full;
        }
    }
}
