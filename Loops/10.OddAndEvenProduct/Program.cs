﻿//You are given n integers (given in a single line, separated by a space).
//Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
//Elements are counted from 1 to n, so the first element is odd, the second is even, etc.
       //Examples:
//numbers	result
//2 1 1 6 3	yes
//product = 6	
//3 10 4 6 5 1	yes
//product = 60	
//4 3 2 5 2	no
//odd_product = 16	
//even_product = 15
using System;

namespace _10.OddAndEvenProduct
{
    class OddAndEvenProduct
    {
        static void Main()
        {
            Console.WriteLine("Enter Integers (given in a single line, separated by a space) :");
            string strNumbers = Console.ReadLine();
            string[] Numbers = strNumbers.Split(new char[] { '\u0020' }, StringSplitOptions.RemoveEmptyEntries);
            int oddProduct = 1;
            int evenProduct = 1;

            for (int i = 0; i < Numbers.Length; i++)
            {
                int currentNumber = int.Parse(Numbers[i]);
                if (i % 2 == 0)
                {
                    evenProduct *= currentNumber;
                }
                else if (i % 2 != 0)
                {
                    oddProduct *= currentNumber;
                }
            }
            bool equalProducts = oddProduct == evenProduct;
            Console.WriteLine(equalProducts ? " Result: Yes\nProduct = {0}" : "Result: No\nOddProduct = {0}\nEvenProduct = {1}"
                            , oddProduct, evenProduct);
        }
    }
}
