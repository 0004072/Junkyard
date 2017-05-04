using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenSegDisplay
{
    public enum Sides
    {
        TOP,
        TOP_LEFT,
        TOP_RIGHT,
        MIDDLE,
        BOTTOM_LEFT,
        BOTTOM_RIGHT,
        BOTTOM
    }

    class Segment
    {
        private Side side;
        private int length;
        private Pixel[] segmentPixels;

        public Segment(int length, Side side) {
            this.length = length;
            segmentPixels = new Pixel[length];
            
        }

        
    }
}
