using System;

namespace ComparingFloats
{
    class ComparingFloats
    {
        static void Main()
        {
            Console.WriteLine("Enter real number a:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter real number b:");
            double b = Convert.ToDouble(Console.ReadLine());
            bool equal = Math.Abs(a - b) < 0.000001;
            Console.WriteLine("a == b " + equal);
        }
    }
}
