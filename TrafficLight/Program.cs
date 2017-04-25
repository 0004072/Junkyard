using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLight
{
    class Program
    {
        static void Main(string[] args)
        {
            Light trafficLight = new Light();
            while(true)
                trafficLight.switchPattern();
        }
    }
}
