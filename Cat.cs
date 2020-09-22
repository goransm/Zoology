using System;
using System.Collections.Generic;
using System.Text;

namespace Zoology
{
    class Cat : Animal, IClimber
    {
        public Cat(string name, double weight, int age)
        {
            this.type = "Cat";
            this.name = name;
            this.weight = weight;
            this.age = age;
        }

        public override void say()
        {
            Console.WriteLine($"{name} goes meow!");
        }

        public void climb()
        {
            Console.WriteLine($"{name} climbs up the nearest tree!");
        }

        public override void move()
        {
            climb();
        }
    }
}
