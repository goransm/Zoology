using System;
using System.Collections.Generic;
using System.Text;

namespace Zoology
{
    class Dog : Animal, ISwimmer
    {
        public Dog(string name, double weight)
        {
            this.type = "Dog";
            this.name = name;
            this.weight = weight;
        }

        public override void say()
        {
            Console.WriteLine($"{name} goes woof!");
        }

        public void swim()
        {
            Console.WriteLine($"{name} jumps into the water, and goes for a swim!");
        }

        public override void move()
        {
            swim();
        }
    }
}
