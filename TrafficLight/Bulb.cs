using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLight
{
    class Bulb
    {
        private ConsoleColor color;
        private bool on;
        private int radius;

        public ConsoleColor Color
        {
            get
            {
                return color;
            }

            set
            {
                color = value;
            }
        }

        public bool On
        {
            get
            {
                return on;
            }

            set
            {
                on = value;
            }
        }

        public int Radius
        {
            get
            {
                return radius;
            }

            set
            {
                if (value % 2 == 1)
                    radius = value;
                else {
                    Console.WriteLine("Incorrect value for the diameter! Should be an odd integer.");
                }
            }
        }

        public Bulb() {

        }

        public Bulb(ConsoleColor color, int radius) {
            this.Radius = radius;
            this.color = color;
        }

        public void showBulb() {
            if (this.On)
                Console.ForegroundColor = this.color;
            int top = this.radius, bottom = 1, horizontal = this.radius + 1;
            for (int i = 1; i <= (2 * radius) + 1; i++)
            {
                if (i <= this.radius + 1)
                {
                    //Ascend
                    for (int j = top; j >= 1; j--)
                    {
                        Console.Write(" ");
                    }
                    top--;
                    for (int k = 1; k <= horizontal; k++)
                    {
                        Console.Write("* ");
                    }
                    horizontal++;
                }
                else
                {
                    //Descend
                    for (int j = 1; j <= bottom; j++)
                    {
                        Console.Write(" ");
                    }
                    bottom++;

                    for (int k = horizontal; k >= this.radius; k--)
                    {
                        Console.Write("* ");
                    }
                    horizontal--;
                }
                Console.WriteLine();
            }
            Console.ResetColor();
        }
    }
}
