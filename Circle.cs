using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleCalculator
{
    class Circle : IShape
    {
        public double Radius {get;}
        public Circle(double Radius)
        {
            this.Radius = Radius;
        }

        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        public double GetPerimeter()
        {
            return Math.PI * 2 * Radius;
        }
    }
}
