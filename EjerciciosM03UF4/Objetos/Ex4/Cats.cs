using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Ex4
{
    public class Cat
    {
        private string name;
        private int age;
        private string breed;
        private string favouriteFood;

        public Cat(int age, string name, string breed, string favouriteFood)
        {
            Age = age;
            Name = name;
            Breed = breed;
            FavouriteFood = favouriteFood;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }

        public string FavouriteFood
        {
            get { return favouriteFood; }
            set { favouriteFood = value; }
        }

        public void Meow()
        {
            Console.WriteLine("Meow");
        }

        public void Play()
        {
            Console.WriteLine($"{Name} is playing");
        }

        public void Wash()
        {
            Console.WriteLine($"washing {Name} ");
        }

        public void Eat()
        {
            Console.WriteLine($"{Name} is eating {FavouriteFood}");
        }

        public void Hunt()
        {
            Console.WriteLine($"{Name} is hunting");
        }

    }
}
