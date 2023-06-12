using System;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Xml.Linq;

namespace P11_CSharp
{
    internal class Program
    {

        enum Month : long
        {
            Jan = 9, Feb, Mar, Apr
        }


        struct Money
        {
            public int Grn;

            public int Kop;

            public Money(int g, int k)
            {
                Grn = g;
                Kop = k;
            }

            public string Print()
            {
                return $"{Grn} grn {Kop} kop";
            }
        }


        static void Func(ref int a, ref int[] arr, out int b)
        {
            Console.WriteLine(a);
            foreach (int i in arr) 
                Console.Write($"{i} ");
            Console.WriteLine();

            b = 100;
            a = 1000;
            arr = new int[] { 22,33,44};

            Console.WriteLine(a);
            foreach (int i in arr)
                Console.Write($"{i} ");
            Console.WriteLine();
        }


        static int SumArr(int a, params int[] arr)
        {
            int res = 0;
            foreach (int i in arr)
            {
                res += i;
            }
            return res;
        }


        static void Main(string[] args)
        {
            Console.Title = "P11 - Слава Україні!";
            Console.OutputEncoding = Encoding.UTF8;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();



            ///// 12.06.2023 //////
            ///


            Matrix matrix = new Matrix(10, 10, 5, 6, 8, 2, 4, 7,3,3,3,3,3);
            //Matrix matrix1 = new Matrix(2, 3);
            //Console.WriteLine(matrix.Rows);
            //Console.WriteLine(matrix.Column);
            //matrix.Print();

            using(OperationTimer timer = new OperationTimer("Test 1"))
            {
                matrix.Test1();
            }

            using (OperationTimer timer = new OperationTimer("Test 2"))
            {
                matrix.Test2();
            }

            matrix.Print();

            //Human human = new Human();
            //human.Name = "Oleg";
            //Console.WriteLine(human.Name);
            //human.ID = 1;
            //int i = human.ID;

            //Console.WriteLine(human.ID);


            //Human human2 = new Human()
            //{
            //    Name = "Irina",
            //    BirthDay = new DateTime(2000, 10, 12),
            //    ID = 1
            //};


            //Student student = new Student();
            //student.MMM();

            ///// 09.06.2023 //////
            ///

            //int[] arr = { 1, 2, 3 };
            //Console.WriteLine(SumArr( 1, 2, 3, 4, 5 ));


            //int a = 5;
            //int[] arr = { 1, 2, 3 };
            //int b = 9;

            //Func(ref b, ref arr, out a);

            //Console.WriteLine("------------");
            //Console.WriteLine(a);
            //foreach (int i in arr)
            //    Console.Write($"{i} ");
            //Console.WriteLine();

            //(a, b) = (b, a);

            //var t = (2, "65456", 5);
            //Console.WriteLine(t.Item1);






            //Student student = new Student();

            //student.Print();

            //Student.id = 1;

            //student.mark[0] = 10;

            //student.Method(name:"Oleg", id:12);


            //Money m = new Money(12, 56);
            //Money m1 = new Money(4, 23);
            //Console.WriteLine(m.Print());
            //Console.WriteLine(m1.Print());
            //m = m1;
            //m1.Grn = 1;
            //Console.WriteLine(m.Print());
            //Console.WriteLine(m1.Print());

            //object[] arr = { 1, "efwer", m, Month.Mar };



            //Month m = Month.Jan;
            //Console.WriteLine(m);
            //Console.WriteLine(Enum.IsDefined(typeof(Month), 5));

            //Enum.GetValues(typeof(Month))
            //    .Cast<int>()
            //    .ToList()
            //    .ForEach(n => Console.WriteLine(n));


            //switch (m)
            //{
            //    case Month.Jan:
            //        break;
            //    case Month.Feb:
            //        break;
            //    case Month.Mar:
            //        break;
            //    case Month.Apr:
            //        break;
            //    default:
            //        break;
            //}


            //Console.WriteLine("Слава Україні!");

            //int a;
            //Int32.TryParse(Console.ReadLine(), out a);

            //int b = Convert.ToInt32(Console.ReadLine());

            //int c = a + b;

            //Console.WriteLine(c);

            //string s = null;
            //int? g = null;
            ////g = g ?? 10;

            //Console.WriteLine(s);

            //DateTime d = DateTime.Now;
            //Console.WriteLine(d);
            //Console.WriteLine(d.ToLongDateString());
            //Console.WriteLine(d.ToShortDateString());
            //Console.WriteLine(d.ToLongTimeString());
            //Console.WriteLine(d.ToShortTimeString());

            //float t = (float)2.2F;

            //int b = 8;

            //int l = (int)10L;

            //double g = 10;

            //int a = 5;

            //if(a > 0)
            //{

            //}

            //int m = a > 0 ? 1 : 0;

            //string j = "mama";

            //switch(j)
            //{
            //    case "mama":
            //        Console.WriteLine("papa");
            //        break;
            //    case "papa":
            //    case "baba":
            //        Console.WriteLine("deda");
            //        break;
            //}

            //DateTime d = DateTime.Now;
            //DateTime d1 = new DateTime(2023, 6, 4);
            //if(d > d1)
            //{

            //}

            //for (int i = 0; i < args.Length; i++)
            //{

            //}

            //while (true)
            //{

            //}

            //do { 

            //} while (true);

            //var f = 10;


            //string str = "kjfhkerufheir";

            //int[] arr = { 1, 2, 3, 4 };



            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);

            //    //goto l1;

            //}

            //foreach (int s in arr)
            //{
            //    Console.WriteLine(s);
            //}


            //Random rnd = new Random();
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(rnd.NextDouble());
            //}



            // type[] name;

            //int[] arr1 = new int[10];
            //int[] arr2 = new int[5] { 1, 2, 3, 4, 5 };
            //int[] arr3 =  { 1, 2, 3, 4, 5 };

            //int[] arr4;
            //arr4 = new int[]{ 12,23,32,4,54, 12, 23, 32, 4, 54 };

            ////arr2[2] = 999;
            ////Console.WriteLine(arr4[2]);

            //Array.Find(arr4, (s) => s > 0); // [](int s){ return s > 0;}

            //foreach (int i in arr4)
            //{
            //    Console.Write(i + ", ");
            //}
            //Console.WriteLine();

            //Console.WriteLine(Array.Find(arr4, (s) => s > 30));

            //Console.WriteLine(arr4.Average());

            //Console.WriteLine(arr4.Sum());

            ////var arr = arr4.Skip(2).ToArray();

            ////var arr = arr4.Where(x => x%10 == 2);   

            //var arr = arr4.Where(x => x % 10 == 2).Distinct().ToArray();

            //foreach (int i in arr)
            //{
            //    Console.Write(i + ", ");
            //}
            //Console.WriteLine();


            //Array.ForEach(arr, x => Console.Write(x + ", "));

            //int[,] arr1 = new int[2, 3] { { 2,4,6}, {5,3,8 } };
            //int[,] arr2 = new int[,] { { 2,4,6}, {5,3,8 } };
            //int[,] arr3 = { { 2,4,6}, {5,3,8 } };

            //int[,,] arr4 = new int[,,] { { {  2,4,6}, { 5,3,8 }, { 5,3,9 } } };

            //Console.WriteLine(arr3.Length);
            //arr3[1, 2] = 11;
            //Console.WriteLine(arr3.Rank);


            //for (int i = 0; i < arr3.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr3.GetLength(1); j++)
            //    {
            //        Console.Write(arr3[i, j] + " ");
            //    }

            //    Console.WriteLine();
            //}


            //int[][] arr5 = new int[3][];
            //arr5[0] = new int[] { 2, 34, 5, 6, 7 };
            //arr5[1] = new int[] { 2, 34, 5 };
            //arr5[2] = new int[] { 2, 34, 7 ,3,2,3,5,6};

            //for (int i = 0; i < arr5.GetLength(0);i++)
            //{
            //    foreach (var item in arr5[i])
            //    {
            //        Console.Write(item + " ");
            //    }
            //    Console.WriteLine();
            //}



            //string str1 = "mama";

            //str1 += " papa, baba";

            //Console.WriteLine(str1);

            //Console.WriteLine(str1.EndsWith("pa"));
            //Console.WriteLine(str1.StartsWith("pa"));
            //Console.WriteLine(str1.PadLeft(12, '*'));
            //Console.WriteLine(str1.PadRight(12, '*'));
            //Console.WriteLine(str1.Replace("ma", "ba"));
            //string[] arr = str1.Split(" ,".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            //foreach (string str2 in arr)
            //{
            //    Console.WriteLine(str2);
            //}








        }
    }
}
