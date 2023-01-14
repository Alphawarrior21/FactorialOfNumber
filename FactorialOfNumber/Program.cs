using System;

namespace FactorialOfNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to calculate the factorial of a number");
            int i= Convert.ToInt32(Console.ReadLine());
            int fact=GetFactorial(i);
            Console.WriteLine($"The factorial of {i} is {fact}");

        }

        private static int GetFactorial(int n)
        {
            if (n == 1 || n == 0)
                return 1;
            else
                return n * GetFactorial(n - 1);
           
        }
    }
}
