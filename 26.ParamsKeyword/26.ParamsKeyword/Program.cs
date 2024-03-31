using System;
using System.ComponentModel.Design;

namespace _26.ParamsKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            //param keyword = a method parameter that takes a variables number of argument
            //                The parameter type must be a single - dimensional key

            double total = CheckOut(3.95, 5.75, 15);

            Console.WriteLine(total);
            Console.ReadKey();

        }

        static double CheckOut(params double[] prices)
        {
            double total = 0;

            foreach (double price in prices)
            {
                total += price;
            }

            return total;
        }

    }
}
