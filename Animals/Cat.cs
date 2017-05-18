using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Cat : Animal, IWalkingAnimal, IJumpingAnimal, IRunningAnimal, IAcquaticAnimal
    {
        public void afloat()
        {
            Console.WriteLine("Cat float");
        }

        public void jump()
        {
            Console.WriteLine("Cat jump");
        }

        public override void makeSound()
        {
            Console.WriteLine("Cat make sound");
        }

        public void run()
        {
            Console.WriteLine("Cat Run");
        }

        public void swim()
        {
            Console.WriteLine("Cat Swim");
        }

        public void walk()
        {
            Console.WriteLine("Cat Walk");
        }
    }
}
