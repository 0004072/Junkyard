using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class YellowBird : Animal, IFlyingAnimal
    {
        public void fly()
        {
            Console.WriteLine("Yellow Bird fly");
        }

        public override void makeSound()
        {
            Console.WriteLine("Yellow Bird makesound");
        }
    }
}
