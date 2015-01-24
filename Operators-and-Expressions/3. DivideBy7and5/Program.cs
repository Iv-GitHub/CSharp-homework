using System;

namespace _3.DivideBy7and5
{
    class DivideBy7and5
    {
        static void Main()
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);

            bool divide = ((number % 7)) == 0 && ((number % 5) == 0);
            Console.WriteLine("Is {0} divisible by 5 and 7 at the same time -> {1}", number, divide);
        }
    }
}
