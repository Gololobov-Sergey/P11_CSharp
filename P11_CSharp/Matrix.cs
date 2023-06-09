﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_CSharp
{
    namespace _111
    {

    }


    interface IOutput
    {
        void Show();

        void Show(string info);
    }

    internal class Matrix : IOutput
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


        public int this[int i, int j]
        {
            get { return matrix[i, j]; }
            set { matrix[i, j] = value; }
        }

        public override string ToString()
        {
            int max = matrix[0, 0];
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Column; j++)
                {
                    max = matrix[i, j] < max ? max : matrix[i, j];
                }
            }

            int height = max.ToString().Length;

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Column; j++)
                {
                    sb.Append($"{matrix[i, j]}".PadLeft(height + 1));
                }
                sb.Append("\n");
            }

            return sb.ToString();
        }

        public void Show()
        {
            Console.WriteLine(this.ToString());
        }

        public void Show(string info)
        {
            Console.WriteLine(info);
            Console.WriteLine(this.ToString());
        }
    }
}
