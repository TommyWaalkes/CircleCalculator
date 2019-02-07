using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeCalculator sc = new ShapeCalculator();
            Circle c = new Circle(15.5);
            sc.DisplayArea(c);
            sc.DisplayPerimeter(c);

            Rectangle r = new Rectangle(12, 9.2);

            Console.WriteLine("The area of both the Rectangle and Circle is "+sc.AddShapeAreas(r, c));
        }
    }
}
