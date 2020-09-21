using System;
using System.Collections.Generic;
using System.Text;

namespace Zoology
{
    class Bird : Animal, IFlyer
    {
        public Bird(string name, double weight)
        {
            this.type = "Bird";
            this.name = name;
            this.weight = weight;
        }

        public override void say()
        {
            Console.WriteLine($"{name} goes quack, but also likes to tweet!");
        }

        public void fly()
        {
            Console.WriteLine($"{name} flies!");
        }

        public override void move()
        {
            fly();
        }
    }
}
