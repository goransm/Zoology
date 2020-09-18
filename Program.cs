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
            animals.Add(new Dog("Snoop", 86));
            animals.Add(new Cat("Garfield", 56));
            animals.Add(new Bird("Trumpy", 120));
            animals.Add(new Fox("Sneaky", 9.9));

            animals.ForEach(delegate(Animal animal)
            {
                animal.describe();
                animal.say();
                Console.WriteLine();
            });
        }
    }
}
