//Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence 
//(at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
//Note: You may need to learn how to use loops.
using System;

namespace _10.FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main()
        {
             Console.WriteLine("Enter the last Fibonacci member:");
             int counter = int.Parse(Console.ReadLine());

             decimal firstNumber = 0m;
             decimal secondNumber = 1m;
             decimal sum;

             for (int i = 0; i < counter; i++)
             {
                 Console.Write("{0} ", firstNumber);

                 sum = firstNumber + secondNumber;
                 firstNumber = secondNumber;
                 secondNumber = sum;
             }
        }
    }
}
