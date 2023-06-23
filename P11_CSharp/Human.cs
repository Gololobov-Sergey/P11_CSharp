using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_CSharp
{
    public abstract class Human
    {

        public string? Name { get; set; } = "No name";

        public DateTime? BirthDay { get; set; }


        protected int? _id;

        public int? ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public Human()
        {
            
        }

        public Human(int id, string name, DateTime bd)
        {
            ID = id;
            Name = name;
            BirthDay = bd;
        }
        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, BD: {BirthDay.Value.ToShortDateString()}";
        }

        public abstract void Work();

        public override int GetHashCode()
        {
            return $"ID: {ID}, Name: {Name}, BD: {BirthDay.Value.ToShortDateString()}".GetHashCode();
        }
    }


    public /*sealed*/ class Employee : Human, ISpeaking
    {
        new int? _id;

        public int _salary;

        public List<string> Lengauge { get; } = new List<string>();

        public Employee(int id, string name, DateTime bd, int salary) : base(id, name, bd)
        {
            _salary = salary;
            _id = 999;
        }

        public void GetInfoEmployee()
        {
            Console.WriteLine("I`m Employee");
        }


        public override string ToString()
        {
            return base.ToString() + $", Salary: {_salary}";
        }

        public override void Work()
        {
            Console.WriteLine("Я працюю");
        }

        public void Speak(string language)
        {
            if(Lengauge.Contains(language))
            {
                Console.WriteLine($"Я добре спілкуюсь на мові {language}");
            }
            else
            {
                Console.WriteLine($"Я не знаю мову {language}");
            }
        }
    }

    public class Director : Human, ISpeaking
    {
        int countPersonal;
        public Director(int id, string name, DateTime bd, int cp) : base(id, name, bd)
        {
            countPersonal = cp;
        }

        public List<string> Lengauge { get; } = new List<string>();

        public void GetInfoDirector()
        {
            Console.WriteLine("I`m Director");
        }

        public void Speak(string language)
        {
            if (Lengauge.Contains(language))
            {
                Console.WriteLine($"Я відмінно спілкуюсь на мові {language}");
            }
            else
            {
                Console.WriteLine($"Я не знаю мову {language}");
            }
        }

        public override string ToString()
        {
            return base.ToString() + $", Count Personal: {countPersonal}";
        }

        public override void Work()
        {
            Console.WriteLine("Я керую людьми");
        }
    }


    public class CleaningManager : Human, ISpeaking
    {
        int area;
        public CleaningManager(int id, string name, DateTime bd, int a) : base(id, name, bd)
        {
            area = a;
        }

        public List<string> Lengauge { get; } = new List<string>();

        public void GetInfoCleaningManager()
        {
            Console.WriteLine("I`m CleaningManager");
        }

        public void Speak(string language)
        {
            Console.WriteLine($"Я не знаю мову {language}");
        }

        public override string ToString()
        {
            return base.ToString() + $", Area: {area}";
        }

        public override void Work()
        {
            Console.WriteLine("Я прибираю приміщення");
        }

        
    }

    public class Worker : Human
    {
        public int IsWorking
        {
            get => default;
            set
            {
            }
        }


        public override void Work()
        {
            throw new NotImplementedException();
        }

        public string Info(int num, DateTime name)
        {
            throw new System.NotImplementedException();
        }
    }
}
