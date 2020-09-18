using System;
using System.Collections.Generic;
using System.Text;

namespace Zoology
{
    class Fox : Animal
    {
        public Fox(string name, double weight)
        {
            this.type = "Fox";
            this.name = name;
            this.weight = weight;
        }

        public override void say()
        {
            Console.WriteLine($"{name} goes Ring-ding-ding-ding-dingeringeding!\nGering - ding - ding - ding - dingeringeding!\nGering - ding - ding - ding - dingeringeding!");
        }
    }
}
