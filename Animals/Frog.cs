using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Frog : Animal, ISubAcquaticAnimal, IWalkingAnimal, IJumpingAnimal
    {
        public void dive()
        {
            Console.WriteLine("Frog dive");
        }

        public void afloat() {
            Console.WriteLine("Frog floating");
        }

        public void jump()
        {
            Console.WriteLine("Frog jump");
        }

        public override void makeSound()
        {
            Console.WriteLine("Frog Makesound");
        }

        public void run()
        {
            Console.WriteLine("");
        }

        public void swim()
        {
            Console.WriteLine("Frog Swim");
        }

        public void walk()
        {
            Console.WriteLine("Frog Walk");
        }
    }
}
