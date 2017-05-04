using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle t = new Triangle(6, 4, 0.5);
            Console.WriteLine(t.calculatePerimeter());
            Circle c = new Circle(7);
            Console.WriteLine(c.calculateArea());
            Console.ReadKey();
        }
    }
}
