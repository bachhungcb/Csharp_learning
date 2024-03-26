using System;

namespace _23.Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //methods = performs a section of code, whenever it is called 'invoked'.
            //          benefit = Let's us reuse code w/o writing the same code again.
            string name = "bach";
            int age = 20;

            singHappyBirthday(name, age);
            singHappyBirthday(name, age);
            singHappyBirthday(name, age); 

        }

        static void singHappyBirthday(string name, int age)
        {
            Console.WriteLine("Happy birthday to you");
            Console.WriteLine("Happy birthday to you");
            Console.WriteLine("Happy birthday dear " + name);
            Console.WriteLine("Happy birthday to you");
            Console.WriteLine("You are " + age + " years old");
            Console.WriteLine();
        }
    }
}
