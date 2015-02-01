//write a program that calculates n! / k! for given n and k (1 < k < n < 100).
//Use only one loop.
using System;

namespace _6.CalculateNFactorial
{
    class CalculateNFactorial
    {
        static void Main()
        {
            Console.Write("Enter value of N > 1: ");
            double n = double.Parse(Console.ReadLine());
            Console.Write("Enter value of K<n<100 : ");
            double k = double.Parse(Console.ReadLine());

            double factorialN = 1;
            if (1 < k && n > k && n < 100)
            {
                for (double i = k + 1; i <= n; i++)
                {
                    factorialN *= i;
                }
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
            Console.WriteLine("N!/!K = {0}", factorialN);
        }
    }
}
