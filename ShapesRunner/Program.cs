using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes;
using System.Text.RegularExpressions;

namespace ShapesRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(7.0d);
            Square s = new Square(10.0d);
            Rectangle r = new Rectangle(5, 7);
            Triangle t = new Triangle(8, 10, 1.25);
            Console.WriteLine(t.calculatePerimeter());
            Console.ReadKey();
        }
    }
}
