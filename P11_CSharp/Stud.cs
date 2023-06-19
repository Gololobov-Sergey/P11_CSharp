using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_CSharp
{
    enum Course
    {
        CSharp, CPP, UML, SQL
    }

    internal class Stud
    {

        int[][] marks;

        public string Name { get; set; }

        public Stud()
        {
            marks = new int[typeof(Course).GetEnumNames().Length][];
            for(int i = 0; i < typeof(Course).GetEnumNames().Length; i++) 
            {
                marks[i] = new int[0];
            }

        }

        public int this[Course course]
        {
            set 
            {
                if(value > 0 && value <= 12) 
                { 
                    int oldSize = marks[(int)course].Length;
                    int[] temp = new int[oldSize + 1];
                    for (int i = 0; i < oldSize; i++) 
                    {
                        temp[i] = marks[(int)course][i];
                    }
                    temp[oldSize] = value;
                    marks[(int)course] = temp;
                }
            }
        }

        public void Print(Course course)
        {
            Console.Write($"{course} - ");
            for (int i = 0; i < marks[(int)course].Length; i++)
            {
                Console.Write($"{marks[(int)course][i]}, ");
            }
            Console.WriteLine();
        }


        public void Print()
        {
            Console.WriteLine(Name);
            for (int i = 0;i < marks.GetLength(0);i++)
            {
                Console.Write($"{typeof(Course).GetEnumName(i)} - ");
                for (int j = 0; j < marks[i].Length; j++)
                {
                    Console.Write($"{marks[i][j]}, ");
                }
                Console.WriteLine();
            }
        }

    }
}
