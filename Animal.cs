using System;
using System.Collections.Generic;
using System.Linq;


namespace Zoology
{
     abstract class Animal
    {
        protected string type;
        protected string name;
        protected double weight;
        protected int age;

        public int Age
        {
            get { return this.age; }
        }

        public string Name
        {
            get { return this.name; }
        }

        public string Type
        {
            get { return this.type; }
        }

        public double Weight
        {
            get { return this.weight; }
        }
        public string Description
        {
            get { return $"{name} is a {type}\n{name} is {(weight < 10 ? "a cute little rascal" : weight < 100 ? "neither tiny or huge" : "literally a beast")}, and is {age} years old. "; }
        }

        public void describe()
        {
            Console.WriteLine($"{name} is a {type}");
            Console.WriteLine($"{name} is {(weight < 10 ? "a cute little rascal" : weight < 100 ? "neither tiny or huge" : "literally a beast")}.");
        }

        public static List<Animal> select(List<Animal> animals, string type)
        {
            IEnumerable<Animal> selectedByType =
            from animal in animals
            where animal.Type.ToLower() == type.ToLower()
            orderby animal.Name ascending
            select animal;

            IEnumerator<Animal> selection = selectedByType.GetEnumerator();
            List<Animal> animalSelection = new List<Animal>();
            do
            {
                if(selection.Current != null)
                {
                    animalSelection.Add(selection.Current);
                }
            } while (selection.MoveNext());
            return animalSelection;
        }

        public static List<Animal> sort(List<Animal> animals, int age)
        {
            IEnumerable<Animal> sortedByAge =
            from animal in animals
            where animal.Age > age
            orderby animal.Age ascending
            select animal;

            IEnumerator<Animal> selection = sortedByAge.GetEnumerator();
            List<Animal> animalSelection = new List<Animal>();
            do
            {
                if (selection.Current != null)
                {
                    animalSelection.Add(selection.Current);
                }
            } while (selection.MoveNext());
            return animalSelection;
        }

        public static List<Animal> sort(List<Animal> animals, double weight)
        {
            IEnumerable<Animal> sortedByWeight =
            from animal in animals
            where animal.Weight > weight
            orderby animal.Weight ascending
            select animal;

            IEnumerator<Animal> selection = sortedByWeight.GetEnumerator();
            List<Animal> animalSelection = new List<Animal>();
            do
            {
                if (selection.Current != null)
                {
                    animalSelection.Add(selection.Current);
                }
            } while (selection.MoveNext());
            return animalSelection;
        }

        public abstract void say();
        public abstract void move();
    }
}
