using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Triangle : Rectangle
    {
        private double hypotenuse;
        private double baseEdge;
        private double baseFragment;

        public override double calculateArea()
        {
            return base.calculateArea() / 2;
        }


        public override double calculatePerimeter()
        {
            double sideEdge, otherSideEdge;
            sideEdge = Math.Sqrt((hypotenuse * hypotenuse) + (baseEdge * baseFragment * baseEdge * baseFragment));
            otherSideEdge = Math.Sqrt((hypotenuse * hypotenuse) + (baseEdge * (1 - baseFragment) * baseEdge * (1 -baseFragment)));
            return baseEdge + sideEdge + otherSideEdge;
        }

        public Triangle(double baseEdge, double hypotenuse, double baseFragment) : base(baseEdge, hypotenuse) {
            this.baseEdge = baseEdge;
            this.hypotenuse = hypotenuse;
            if (baseFragment > 0 && baseFragment < 1)
                this.baseFragment = baseFragment;
            else {
                throw new Exception("Invalid value for the base fragment ratio!");
            }
        }
    }
}
