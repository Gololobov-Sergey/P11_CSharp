using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace P11_CSharp
{
    internal abstract class Figure
    {
        public abstract float Area();
    }


    class Circle : Figure
    {
        public int Radius { get; set; }

        public override float Area()
        {
            return (float)Math.PI * Radius * Radius;
        }
    }
}
