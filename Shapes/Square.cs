using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Square : Rectangle
    {
        private double sideLength;

        public override double calculateArea()
        {
            return sideLength * sideLength;
        }

        public override double calculatePerimeter()
        {
            return sideLength * 4;
        }

        public Square(double sideLength) : base(sideLength, sideLength)
        {
            
        }
    }
}
