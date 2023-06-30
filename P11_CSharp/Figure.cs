using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace P11_CSharp
{
    interface IPrintable
    {
        void Print();
    }

    internal abstract class Figure : IPrintable
    {
        public string Type { get; set; }

        public ConsoleColor Color { get; set; }

        public Figure(string type)
        {
            Type = type;
        }

        public abstract Figure Clone();

        public virtual void Print()
        {
            throw new NotImplementedException();
        }
    }


    class Circle : Figure
    {
        public Circle(string type) : base(type) { }
        public override void Print()
        {
            Console.ForegroundColor = Color;
            Console.WriteLine($"Circle {Color}");
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        public override Circle Clone()
        {
            return (Circle)this.MemberwiseClone();
        }
    }

    class Triangle : Figure
    {
        public Triangle(string type) : base(type) { }
        public override void Print()
        {
            Console.ForegroundColor = Color;
            Console.WriteLine($"Triangle {Color}");
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        public override Triangle Clone()
        {
            return (Triangle)this.MemberwiseClone();
        }
    }

    class Rectangle : Figure
    {
        public Rectangle(string type) : base(type) { }
        public override void Print()
        {
            Console.ForegroundColor = Color;
            Console.WriteLine($"Rectangle {Color}");
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        public override Rectangle Clone()
        {
            return (Rectangle)this.MemberwiseClone();
        }
    }


    class FigureCollection : IEnumerable
    {
        List<Figure> figures = new();

        public List<Figure> GetList { get { return figures; } }

        Figure[] cash = { new Circle("Circle"), new Triangle("Triangle"), new Rectangle("Rectangle") };

        public void AddFigure()
        {
            int ind = ConsoleMenu.SelectVertical(HPosition.Center,
                VPosition.Center, HorizontalAlignment.Center,
                "Circle", "Triangle", "Rectangle");

            Figure f = cash[ind].Clone();

            //Figure f = null;
            //switch (ind)
            //{
            //    case 0: f = new Circle("Circle"); break;
            //    case 1: f = new Triangle("Triangle"); break;
            //    case 2: f = new Rectangle("Rectangle"); break;
            //}

            ind = ConsoleMenu.SelectVertical(HPosition.Center,
                VPosition.Center, HorizontalAlignment.Center,
                typeof(ConsoleColor).GetEnumNames());

            f.Color = (ConsoleColor)ind;

            figures.Add(f);
        }

        public void RemoveFigure(Figure figure)
        {

        }

        public void PrintAll()
        {
            foreach (Figure f in figures)
            {
                f.Print();
            }
        }

        public IEnumerator GetEnumerator()
        {
            return figures.GetEnumerator();
        }
    }

    class App
    {
        FigureCollection figureCollection = new FigureCollection();

        public void Menu()
        {
            while (true)
            {
                Console.Clear();    
                int ind = ConsoleMenu.SelectVertical(HPosition.Center,
                    VPosition.Center, HorizontalAlignment.Center,
                    "Add", "Del", "Print All");
                switch (ind)
                {
                    case 0:
                        figureCollection.AddFigure();
                        break;
                    case 2:
                        //figureCollection.PrintAll();
                        foreach (Figure f in figureCollection)
                        {
                            f.Print();
                        }

                        Console.Read();
                        break;
                }
            }
        }
    }
}
