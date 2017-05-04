using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Rectangle : Shape
    {
        private double length, width;

        public override double calculateArea()
        {
            return length * width;
        }

        public override double calculatePerimeter()
        {
            return (length + width) * 2;
        }

        public Rectangle(double length, double width) {
            this.length = length;
            this.width = width;
        }
    }
}
