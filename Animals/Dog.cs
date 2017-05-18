using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Dog : Animal, IWalkingAnimal, IJumpingAnimal, IRunningAnimal, IAcquaticAnimal
    {
        public void afloat()
        {
            Console.WriteLine("Dog float");
        }

        public void jump()
        {
            Console.WriteLine("Dog jump");
        }

        public override void makeSound()
        {
            Console.WriteLine("Dog make sound");
        }

        public void run()
        {
            Console.WriteLine("Dog Run");
        }

        public void swim()
        {
            Console.WriteLine("Dog Swim");
        }

        public void walk()
        {
            Console.WriteLine("Dog Walk");
        }
    }
}
