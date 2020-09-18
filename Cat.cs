using System;
using System.Collections.Generic;
using System.Text;

namespace Zoology
{
    class Cat : Animal
    {
        public Cat(string name, double weight)
        {
            this.type = "Cat";
            this.name = name;
            this.weight = weight;
        }

        public override void say()
        {
            Console.WriteLine($"{name} goes meow!");
        }
    }
}
