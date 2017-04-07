using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeFormatter
{
    class Program
    {
        static void Main(string[] args)
        {
            string year, month, date, hrs, min, sec;
            Console.Write("Year:");
            year = Console.ReadLine();

            Console.Write("Month:");
            month = Console.ReadLine();

            Console.Write("date:");
            date = Console.ReadLine();

            Console.Write("Hours:");
            hrs = Console.ReadLine();

            Console.Write("Minutes:");
            min = Console.ReadLine();

            Console.Write("Seconds:");
            sec = Console.ReadLine();

            try
            {
                DateTime intOutput = DateTime.Parse(String.Format("{0} {1} {2} {3}:{4}:{5}", year, month, date, hrs, min, sec));
                Console.WriteLine(intOutput.ToString("F", CultureInfo.CreateSpecificCulture("en-UK")));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.ReadKey();
        }
    }
}
