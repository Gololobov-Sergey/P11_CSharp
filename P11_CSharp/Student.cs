using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_CSharp
{
    internal partial class Student
    {
        static public int id = 10;

        string name;

        const int groupNumber = 10;

        readonly int count;

        public readonly int[] mark = { 12, 12, 12 };

        static Student()
        {
            id = 0;
        }

        public Student()
        {
            count = 0;
        }

        public void Print()
        {
            Console.WriteLine($"Id: {id}, Name: {name}");
        }


        public void Method(int id, string name)
        {
            Student.id = id;
            this.name = name;
        }


        public Student GetStudent()
        {
            return this;
        }
    }
}
