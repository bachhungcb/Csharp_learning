using System;
using System.Runtime.CompilerServices;

namespace _32.Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            //object = An instance of a class
            //         A class can be used as a blueprint to create object (OOP)
            //         Objects can have fields and methods (characteristics and actions)

            Human human1 = new Human();
            Human human2 = new Human();

            human1.name = "Gran";
            human1.age = 54;

            human2.name = "Rick";
            human2.age = 100;

            human1.Eat();
            human1.Sleep();

            human2.Eat();
            human2.Sleep();

            Console.ReadKey();
        }

    }

    class Human
    {
        public String name;
        public int age;

        public void Eat()
        {
            Console.WriteLine(name + " is eating");
        }

        public void Sleep()
        {
            Console.WriteLine(name + " is sleeping");
        }
    }
}
