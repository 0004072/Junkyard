using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace RobotRunning
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot();

            robot.Strength = 70;
            robot.Life = 100;

            robot.shoot();
        }
    }
}
