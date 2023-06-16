using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_CSharp__
{
    namespace _111
    {

    }
    internal class Matrix
    {
        int[,] matrix;

        public uint Rows { get; }
        public uint Column { get; }

        public Matrix(uint row, uint col, params int[] init)
        {
            Rows = row;
            Column = col;

            matrix = new int[Rows, Column];

            uint length = init.Length < Rows * Column ? (uint)init.Length : Rows * Column;
            for (uint i = 0; i < length; i++)
            {
                uint r = i / Column;
                uint c = i % Column;
                matrix[r,c] = init[i];
            }
        }

        public void Test1()
        {
            int max = matrix.Cast<int>().Max();

        }

        public void Test2()
        {
            int max = matrix[0, 0];
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Column; j++)
                {
                    max = matrix[i, j] < max ? max : matrix[i, j];
                }
            }
        }


        public void Print()
        {
            //int max = array.Cast<int>().Max();

            int max = matrix[0,0];
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Column;j++)
                {
                    max = matrix[i,j] < max ? max : matrix[i,j];
                }
            }

            int height = max.ToString().Length;

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Column; j++)
                {
                    Console.Write($"{matrix[i,j]}".PadLeft(height+1));
                }
                Console.WriteLine();
            }

        }
    }
}
