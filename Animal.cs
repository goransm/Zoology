using System;
using System.Collections.Generic;
using System.Text;

namespace Zoology
{
     abstract class Animal
    {
        protected string type;
        protected string name;
        protected double weight;

        public Animal(string type, string name, double weight)
        {
            this.type = type;
            this.name = name;
            this.weight = weight;
        }

        public Animal()
        {
            type = "...what is this thing?";
            name = "This thing doesn't even have a name, but";
            weight = 100;
        }
        public void describe()
        {
            Console.WriteLine($"{name} is a {type}");
            Console.WriteLine($"{name} is {(weight < 10 ? "a cute little rascal" : weight < 100 ? "neither tiny or huge" : "literally a beast")}.");
        }
        public abstract void say();
        public abstract void move();
    }
}
