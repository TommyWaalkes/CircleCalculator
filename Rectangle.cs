using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleCalculator
{
    class Rectangle : IShape
    {
        public double Length { get; }
        public double Width { get; }
        public Rectangle(double Length, double Width)
        {
            this.Length = Length;
            this.Width = Width;
        }
        public double GetArea()
        {
            return Length * Width;
        }

        public double GetPerimeter()
        {
            return (2 * Length) + (2 * Width);
        }
    }
}
