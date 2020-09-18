using System;
using System.Collections.Generic;
using System.Text;

namespace Zoology
{
    class Bird : Animal
    {
        public Bird(string name, double weight)
        {
            this.type = "Bird";
            this.name = name;
            this.weight = weight;
        }

        public override void say()
        {
            Console.WriteLine($"{name} goes quack, but also like to tweet!");
        }
    }
}
