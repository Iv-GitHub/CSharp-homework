//Write a program that reads two positive integer numbers and prints 
//how many numbers p exist between them such that the reminder of the division by 5 is 0.
using System;

namespace _11.NumbersInIntervalDividableByGivenNumber
{
    class NumbersInIntervalDividableByGivenNumber
    {
        static void Main()
        {
            Console.WriteLine("Enter first integer number: ");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second integer number: ");
            int second = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = first; i <= second; i++)
            {

                if (i % 5 == 0)
                {
                    counter++;
                    Console.Write("{0}, ", i);
                }
            }
            Console.WriteLine("\nThere are {0} numbers between {1} and {2}, that the reminder of their division by 5 is 0"
                                , counter, first, second);
        }
    }
}
