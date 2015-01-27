using System;

namespace _1.Sumof3Numbers
{
    class Sumof3Numbers
    {
        static void Main()
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());

            double sum = a + b + c;
            Console.WriteLine("Sum = " + sum);
        }
    }
}
