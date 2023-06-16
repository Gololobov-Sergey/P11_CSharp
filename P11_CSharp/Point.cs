using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_CSharp
{
    internal class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        private string print;

        public string Print
        {
            get { return $"(X = {X}, Y = {Y})"; }
        }

        public static Point operator-(Point p)
        {
            return new Point() { X = -p.X, Y = -p.Y };
        }

        public static Point operator++(Point p)
        {
            p.X++;
            p.Y++;
            return p;
        }


        public static Point operator-(Point p1, Point p2)
        {
            return new Point() { X = p1.X - p2.X, Y = p1.Y - p2.Y};
        }

        public static Point operator*(Point p1, int n)
        {
            return new Point() { X = p1.X * n, Y = p1.Y * n };
        }

        public static Point operator*(int n, Point p1)
        {
            return p1 * n;
        }

        public override bool Equals(object p2)
        {
            if(p2 is Point) 
            {
                return (X == ((Point)p2).X) && (Y == ((Point)p2).Y);   
            }
             return false;
        }

        public override int GetHashCode()
        {
            return Print.GetHashCode();
        }

        public static bool operator ==(Point p1, Point p2)
        {
            return (p1.X == p2.X) && (p1.Y == p2.Y);
        }

        public static bool operator !=(Point p1, Point p2)
        {
            return (p1.X != p2.X) || (p1.Y != p2.Y);
        }

        public static bool operator >(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p1.X, 2) + Math.Pow(p1.Y, 2)) >
                Math.Sqrt(Math.Pow(p2.X, 2) + Math.Pow(p2.Y, 2));
        }

        public static bool operator <(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p1.X, 2) + Math.Pow(p1.Y, 2)) <
                Math.Sqrt(Math.Pow(p2.X, 2) + Math.Pow(p2.Y, 2));
        }


        public static bool operator true(Point p1)
        {
            return p1.X != 0 || p1.Y != 0 ? true : false;    
        }


        public static bool operator false(Point p1)
        {
            return p1.X == 0 && p1.Y == 0 ? true : false;
        }

        public static Point operator | (Point p1, Point p2)
        {
            return new Point();
        }


        public static Point operator &(Point p1, Point p2)
        {
            return new Point();
        }


        public static /*implicit*/ explicit operator float(Point p1)
        {
            return (float)Math.Sqrt(Math.Pow(p1.X, 2) + Math.Pow(p1.Y, 2));
        }

        public static implicit /*explicit*/ operator Point(int p)
        {
            return new Point() { X = p, Y = 0 };
        }
    }
}
