using System;

namespace _5.ThirdDigitIs7
{
    class ThirdDigitIs7
    {
        static void Main()
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            number /= 100;

            bool ThirdDigitIs7 = (number % 10) == 7;

            Console.WriteLine("The third digit is 7 -> " + ThirdDigitIs7);
        }
    }
}
