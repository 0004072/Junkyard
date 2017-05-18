using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Cow : Animal, IWalkingAnimal, IJumpingAnimal, IRunningAnimal
    {
        public void jump()
        {
            Console.WriteLine("Cow jump");
        }

        public override void makeSound()
        {
            Console.WriteLine("Cow make sound");
        }

        public void run()
        {
            Console.WriteLine("Cow Run");
        }

        public void walk()
        {
            Console.WriteLine("Cow Walk");
        }
    }
}
