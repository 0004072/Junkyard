using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenSegDisplay
{
    class Program
    {
        static void Main(string[] args)
        {
            int segLength = 4;
            Digit one = new Digit(Digits.ONE, new Segment[] {
                new Segment(segLength, new Side(Sides.TOP_RIGHT, segLength + 2, 0)),
                new Segment(segLength, new Side(Sides.BOTTOM_RIGHT, segLength + 2, segLength + 3))
            });
            DisplayPanel dp = new DisplayPanel(20, 10, 1, 2);
            Character ch1 = new Character(one, dp.Margin);
            Console.ReadKey();
        }
    }
}
