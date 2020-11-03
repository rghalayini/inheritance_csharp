using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchical_Inheritance
{
    public class Animal
    {
        public string Eat()
        {
            return "eating...";
        }
    }
    public class Dog:Animal
    {
        public string Bark()
        {
            return "barking...";
        }
    }
    public class Cat:Animal
    {
        public string Meow()
        {
            return "meowing...";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();

            Cat cat = new Cat();
            cat.Eat();
            cat.Meow();
        }
    }
}
