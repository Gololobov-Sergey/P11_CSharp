using System;
using System.Linq;
using System.Text;

namespace P11_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "P11 - Слава Україні!";
            Console.OutputEncoding = Encoding.UTF8;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();

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



            string str1 = "mama";

            str1 += " papa, baba";

            Console.WriteLine(str1);

            Console.WriteLine(str1.EndsWith("pa"));
            Console.WriteLine(str1.StartsWith("pa"));
            Console.WriteLine(str1.PadLeft(12, '*'));
            Console.WriteLine(str1.PadRight(12, '*'));
            Console.WriteLine(str1.Replace("ma", "ba"));
            string[] arr = str1.Split(" ,".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (string str2 in arr)
            {
                Console.WriteLine(str2);
            }

            

        }
    }
}
