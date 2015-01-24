//Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
//Prints on the console the number in reversed order: dcba (in our example 1102).
//Puts the last digit in the first position: dabc (in our example 1201).
//Exchanges the second and the third digits: acbd (in our example 2101).
using System;

namespace Four_DigitNumber
{
    class Four_DigitNumber
    {
        static void Main()
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            int d = number % 10;
            number /= 10;
            int c = number % 10;
            number /= 10;
            int b = number % 10;
            number /= 10;
            int a = number % 10;

            Console.WriteLine("Sum of the digit is: " + (a + b + c + d));

            int ReversedNum = d * 1000 + c * 100 + b * 10 + a;
            Console.WriteLine("Reversed number: " + ReversedNum);

            int LastDigitFirstPos = d * 1000 + a * 100 + b * 10 + c;
            Console.WriteLine("Last digit first: " + LastDigitFirstPos);

            int ExchangeSecondAndThird = a * 1000 + c * 100 + b * 10 + d;
            Console.WriteLine("Exchange second and third: " + ExchangeSecondAndThird);
        }
    }
}
