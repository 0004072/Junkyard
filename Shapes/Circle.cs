using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle : Shape
    {
        private double radius;

        public override double calculateArea()
        {
            return (22.0d * radius * radius) / 7.0d;
        }

        public override double calculatePerimeter()
        {
            return (2.0d * 22.0d * radius) / 7.0d;
        }

        public Circle(double radius) {
            this.radius = radius;
        }
    }
}
