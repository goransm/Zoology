using System;
using System.Collections.Generic;

namespace Zoology
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Time for a little bit of Zoology!\n");
            List<Animal> animals = new List<Animal>();
            animals.Add(new Animal("badger","Knutsen", 5));
            animals.Add(new Animal("human","Ludvigsen", 92));
            animals.Add(new Animal("killer whale","Willy", 1902));
            animals.Add(new Animal());

            animals.ForEach(delegate(Animal animal)
            {
                animal.describe();
            });
        }
    }

    class Animal
    {
        string type;
        string name;
        double weight;

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
            Console.WriteLine($"{name} is {(weight < 10 ? "a cute little rascal" : weight < 100 ? "neither tiny or huge" : "literally a beast")}.\n");
        }
    }
}
