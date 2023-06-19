using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_CSharp
{
    public class Human
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
    }


    public /*sealed*/ class Employee : Human
    {
        new int? _id;

        int _salary;

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
    }

    public class Director : Human
    {
        int countPersonal;
        public Director(int id, string name, DateTime bd, int cp) : base(id, name, bd)
        {
            countPersonal = cp;
        }

        public void GetInfoDirector()
        {
            Console.WriteLine("I`m Director");
        }

        public override string ToString()
        {
            return base.ToString() + $", Count Personal: {countPersonal}";
        }

    }


    public class CleaningManager : Human
    {
        int area;
        public CleaningManager(int id, string name, DateTime bd, int a) : base(id, name, bd)
        {
            area = a;
        }

        public void GetInfoCleaningManager()
        {
            Console.WriteLine("I`m CleaningManager");
        }

        public override string ToString()
        {
            return base.ToString() + $", Area: {area}";
        }
    }

}
