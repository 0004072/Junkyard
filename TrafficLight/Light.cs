using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLight
{
    class Light
    {
        private class LightSignal {
            private int[] bulbsOn;
            private int durationInSeconds;

            public LightSignal(int[] b, int d) {
                this.BulbsOn = b;
                this.DurationInSeconds = d;
            }

            public int[] BulbsOn
            {
                get
                {
                    return bulbsOn;
                }

                set
                {
                    bulbsOn = value;
                }
            }

            public int DurationInSeconds
            {
                get
                {
                    return durationInSeconds;
                }

                set
                {
                    durationInSeconds = value;
                }
            }
        }

        private Bulb[] bulbs;
        private LightSignal[] switchingOrder;
        private int currentPattern;

        public Light() {
            int radius = 3;
            this.currentPattern = 3;
            bulbs = new Bulb[3];
            Bulb red = new Bulb(ConsoleColor.Red, radius);
            Bulb orange = new Bulb(ConsoleColor.Yellow, radius);
            Bulb green = new Bulb(ConsoleColor.Green, radius);
            bulbs[0] = red;
            bulbs[1] = orange;
            bulbs[2] = green;

            //Light Signal pattern
            int[] stopPattern = { 0 };
            int[] readyPattern = { 0, 1 };
            int[] goPattern = { 2 };
            int[] waitPattern = { 1 };

            LightSignal stop = new LightSignal(stopPattern, 10);
            LightSignal ready = new LightSignal(readyPattern, 3);
            LightSignal go = new LightSignal(goPattern, 10);
            LightSignal wait = new LightSignal(waitPattern, 3);
            LightSignal[] tmp = { stop, ready, go, wait };
            switchingOrder = tmp;
        }

        public void switchPattern() {
            Console.Clear();
            this.currentPattern = (++this.currentPattern % 4);
            LightSignal nextPattern = switchingOrder[currentPattern];
            //Turn off all the bulbs
            foreach (Bulb b in this.bulbs) {
                b.On = false;
            }

            foreach (int bulbOn in nextPattern.BulbsOn) {
                this.bulbs[bulbOn].On = true;
            }

            //Show bulbs
            foreach (Bulb b in this.bulbs) {
                b.showBulb();
                Console.WriteLine();
            }
            System.Threading.Thread.Sleep(nextPattern.DurationInSeconds * 1000);
        }
    }
}
