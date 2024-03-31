using System;

namespace _25.MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //Method overloading = methods share the same name, but different parameters
            //                     name + parameters = signature
            //                     methods must have a unique signature

            double total;

            total = Multiply(3, 4, 5);

            Console.WriteLine(total);
            Console.ReadKey();

        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static double Multiply(double a, double b, double c)
        {
            return a * b * c;
        }
    }
}
