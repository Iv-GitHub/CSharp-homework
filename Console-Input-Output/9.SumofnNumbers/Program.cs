//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum.
//Note: You may need to use a for-loop.
using System;

namespace _9.SumofnNumbers
{
    class SumofnNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter numbers: ");
            double n = double.Parse(Console.ReadLine());
            double sum = 0;

            for (double i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the {0} number", i + 1);
                double value = double.Parse(Console.ReadLine());
                sum += value;
            }
           Console.WriteLine("Sum: {0}", sum);
        }
    }
}
