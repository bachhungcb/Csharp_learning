using System;

namespace _27.ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //exception  = errors that occur during execution

            //try = try some code that is considered "dangerous"
            //catch = catches and handles exceptions when they occur
            //finally = always executes regardless if exception is caught or not


            int x;
            int y;
            double result;

            try 
            {
                Console.WriteLine("Enter number 1: ");
                x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter number 2: ");
                y = Convert.ToInt32(Console.ReadLine());

                result = x / y;

                Console.WriteLine("result: " + result);

            }
            catch (FormatException e)
            {
                Console.WriteLine("Enter ONLY number");
            }
            catch(DivideByZeroException) 
            {
                Console.WriteLine("You CAN NOT divide by zero");
            }
            catch(Exception e)
            {
                Console.WriteLine("Some thing went wrong");
            }
            finally
            {
                Console.WriteLine("Thanks for visiting");
            }
            Console.ReadKey();
        }
    }
}
