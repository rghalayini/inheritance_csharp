using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    public class Animal
    {
        public string Eat()
        {
            return "eating...";
        }
    }
    public class Dog:Animal   // dog inherits from animal
    {
        public string Bark()
        {
            return "barking...";
        }
    }
    public class Puppy:Dog    //puppy inherits from dog
    {
        public string Weep()
        {
            return "weeping...";
        }
    }
    class Program
    {
        static void Main(string[] args)   //method
        {
            Puppy puppy = new Puppy();
            puppy.Eat();
            puppy.Bark();
            puppy.Weep();
        }
    }
}
