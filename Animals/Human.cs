using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Human : Animal, ISubAcquaticAnimal, IRunningAnimal, IWalkingAnimal, IJumpingAnimal
    {
        public void afloat()
        {
            Console.WriteLine("Human floating");
        }

        public void dive()
        {
            Console.WriteLine("Human dive");
        }

        public void jump()
        {
            Console.WriteLine("Human jump");
        }

        public override void makeSound()
        {
            Console.WriteLine("Human make sound");
        }

        public void run()
        {
            Console.WriteLine("Human run");
        }

        public void swim()
        {
            Console.WriteLine("Human swim");
        }

        public void walk()
        {
            Console.WriteLine("Human walk");
        }
    }
}
