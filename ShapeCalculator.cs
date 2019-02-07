using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleCalculator
{
    class ShapeCalculator
    {
        public void DisplayArea(IShape s)
        {
            Console.WriteLine($"The area is {s.GetArea()}");
        }

        public void DisplayPerimeter(IShape s)
        {
            Console.WriteLine($"The periemter is {s.GetPerimeter()}");
        }
       
        public double AddShapeAreas(IShape s1, IShape s2)
        {
            return s1.GetArea() + s2.GetArea();
        }
        
    }
}
