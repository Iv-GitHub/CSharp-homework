﻿//Write a program that reads an integer number n from the console and 
//prints all the numbers in the interval [1..n], each on a single line.
using System;

namespace _8.NumbersFrom1ToN
{
    class NumbersFrom1ToN
    {
        static void Main()
        {
            Console.WriteLine("Enter a number: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
