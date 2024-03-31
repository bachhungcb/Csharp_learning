using System;

namespace _29.StringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            //string interpolation = allows us to insert variables into a string literal
            //                       precede a string literal with $
            //                       {} are placeholders

            String firstName = "bach";
            string lastName = "Dam";
            int age = 21;

            Console.WriteLine($"Hello {firstName} {lastName}.");
            Console.WriteLine($"Your are {age} years old.");

            Console.ReadKey();
        }
    }
}
