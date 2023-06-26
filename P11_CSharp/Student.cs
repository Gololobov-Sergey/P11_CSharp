using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace P11_CSharp
{

    public class StudentCard : IComparable
    {
        public string Series { get; set; }
        public int Number { get; set; }

        public int CompareTo(object obj)
        {
            StudentCard sc = obj as StudentCard;
            return (Series + Number.ToString()).CompareTo(sc.Series + sc.Number.ToString());
        }

        public override string ToString()
        {
            return $"{Series} {Number}";
        }
    }

    public class Student : IComparable
    {
        public static IComparer FromBirthDay { get { return new DateComparer(); } }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public StudentCard StudentCard { get; set; }

        public int CompareTo(object obj)
        {
            if(obj is  Student)
            {
                Student s = (Student)obj;
                return (LastName+FirstName).CompareTo(s.LastName + s.FirstName);
            }
            throw new ArgumentException("Not Student!!!");
        }

        public override string ToString()
        {
            return $"{LastName.PadRight(15)} {FirstName.PadRight(10)} {BirthDay.ToShortDateString()} {StudentCard}";
        }
    }


    class Group : IEnumerable
    {
        Student[] students;

        public Group()
        {
            students = new Student[]
            {
                new Student
                {
                    LastName = "Petrov",
                    FirstName = "Oleg",
                    BirthDay = new DateTime(2000, 10, 12),
                    StudentCard = new StudentCard
                    {
                        Series = "AB",
                        Number = 123456
                    }
                },

                new Student
                {
                    LastName = "Fedoriv",
                    FirstName = "Anton",
                    BirthDay = new DateTime(2000, 10, 10),
                    StudentCard = new StudentCard
                    {
                        Series = "AB",
                        Number = 123256
                    }
                },

                new Student
                {
                    LastName = "Osipova",
                    FirstName = "Irina",
                    BirthDay = new DateTime(2001, 4, 5),
                    StudentCard = new StudentCard
                    {
                        Series = "AB",
                        Number = 123446
                    }
                },

                new Student
                {
                    LastName = "Osipova",
                    FirstName = "Anna",
                    BirthDay = new DateTime(1999, 5, 20),
                    StudentCard = new StudentCard
                    {
                        Series = "AA",
                        Number = 123456
                    }
                }
            };

        }

        public void Print()
        {
            foreach (Student item in students)
            {
                Console.WriteLine(item);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return students.GetEnumerator();
        }

        public void Sort()
        {
            Array.Sort(students);
        }

        public void Sort(IComparer comparer)
        {
            Array.Sort(students, comparer);
        }
    }


    class DateComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            if(x is Student &&  y is Student)
            {
                return DateTime.Compare((x as Student).BirthDay, (y as Student).BirthDay);  
            }

            throw new NotImplementedException();
        }
    }

    class StudentCardComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            return (x as Student).StudentCard.CompareTo((y as Student).StudentCard);
        }
    }











    //internal partial class Student
    //{
    //    static public int id = 10;

    //    string name;

    //    const int groupNumber = 10;

    //    readonly int count;

    //    public readonly int[] mark = { 12, 12, 12 };

    //    static Student()
    //    {
    //        id = 0;
    //    }

    //    public Student()
    //    {
    //        count = 0;
    //    }

    //    public void Print()
    //    {
    //        Console.WriteLine($"Id: {id}, Name: {name}");
    //    }


    //    public void Method(int id, string name)
    //    {
    //        Student.id = id;
    //        this.name = name;
    //    }


    //    public Student GetStudent()
    //    {
    //        return this;
    //    }
    //}
}
