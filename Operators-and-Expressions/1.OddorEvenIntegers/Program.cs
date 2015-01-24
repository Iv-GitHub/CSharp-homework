//1.Write an expression that checks if given integer is odd or even

using System;

namespace _1.OddorEvenIntegers
{
    class OddorEvenIntegers
    {
        static void Main()
        {
            Console.Write("Enter Integer: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);

            bool odd = (number % 2) != 0;
            Console.WriteLine("Is {0} odd -> {1}", number, odd);
        }
    }
}
