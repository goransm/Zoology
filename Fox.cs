using System;
using System.Collections.Generic;
using System.Text;

namespace Zoology
{
    class Fox : Animal, IFlyer
    {
        public Fox(string name, double weight, int age)
        {
            this.type = "Fox";
            this.name = name;
            this.weight = weight;
            this.age = age;
        }

        public override void say()
        {
            Console.WriteLine($"{name} goes Ring-ding-ding-ding-dingeringeding!\nGering - ding - ding - ding - dingeringeding!\nGering - ding - ding - ding - dingeringeding!");
        }

        public void fly()
        {
            Console.WriteLine($"{name} is confused. A fox can't fly!");
        }

        public override void move()
        {
            fly();
        }
    }
}
