using System;
using System.Collections.Generic;
using System.Text;

namespace Zoology
{
    class Dog : Animal
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
    }
}
