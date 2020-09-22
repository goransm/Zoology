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
            animals.Add(new Dog("Snoop", 86, 48));
            animals.Add(new Bird("Garfield", 56, 42));
            animals.Add(new Bird("Trumpy", 120, 74));
            animals.Add(new Dog("Sneaky", 9.9, 17));
            animals.Add(new Dog("Ozzy", 76, 65));
            animals.Add(new Dog("Nyan", 1, 8));
            animals.Add(new Bird("Munin", 0.4, 1256));
            animals.Add(new Dog("Loki", 82, 1311));
            animals.Add(new Bird("Hugin", 0.54, 1271));
            animals.Add(new Bird("Woody", 0.2, 56));

            Console.WriteLine("\nSome dogs and birds:");

            animals.ForEach(delegate(Animal animal)
            {
                Console.WriteLine($"{animal.Name}, {animal.Type.ToLower()}, weight: {animal.Weight}, age: {animal.Age}");
            });

            string input = "";

            do
            {
                Console.WriteLine("What kind of animal would you select, dog or bird?");
                input = Console.ReadLine();
                List<Animal> userSelectedAnimals = Animal.select(animals, input);
                Console.WriteLine($"These are all the {input}s:");

                userSelectedAnimals.ForEach(delegate (Animal animal)
                {
                    Console.WriteLine($"{animal.Name} - {animal.Age} years old, and weight {animal.Weight} kg");
                });

                Console.WriteLine("\nSort them by weight or by age?");
                input = Console.ReadLine();
                switch (input)
                {
                    case "age":
                        {
                            userSelectedAnimals = Animal.sort(userSelectedAnimals, -1);
                            userSelectedAnimals.ForEach(delegate (Animal animal)
                            {
                                Console.WriteLine($"{animal.Name} - {animal.Age} years old, and weight {animal.Weight} kg");
                            });
                            Console.WriteLine("\n");
                            break;
                        }
                    case "weight":
                        {
                            userSelectedAnimals = Animal.sort(userSelectedAnimals, -1.1);
                            userSelectedAnimals.ForEach(delegate (Animal animal)
                            {
                                Console.WriteLine($"{animal.Name} - {animal.Age} years old, and weight {animal.Weight} kg");
                            });
                            Console.WriteLine("\n");
                            break;
                        }
                }
                Console.WriteLine("Now's your chance to quit. Type quit to exit, hit enter to start over.");
                input = Console.ReadLine();

            } while (input != "quit");

            Console.WriteLine("\nLINQ test:");

            List<Animal> dogs = Animal.select(animals, "dog");

            dogs.ForEach(delegate (Animal animal)
            {
                Console.WriteLine($"{animal.Type} {animal.Name} - {animal.Age}");
            });

        }
        
    }
}
