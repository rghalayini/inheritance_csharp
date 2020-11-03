using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_inheritance
{
    public class Animal
    {
        public string Eat()
        {
            return "eating...";
        }
    }
    public class Dog : Animal   //class dog inherits from Animal
    {
        public string Bark()
        {
            return "barking...";
        }
    }

    public class Program
    {
        public static void Main()   //method
        {
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();
        }

    }
}
