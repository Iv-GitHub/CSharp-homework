using System;

namespace _7.PointInCircle
{
    class PointInCircle
    {
        static void Main()
        {
            Console.Write("Enter x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Enter y: ");
            double y = double.Parse(Console.ReadLine());
            int radius = 2;

            bool PointInCircle = (x * x + y * y) <= radius * radius;

            Console.WriteLine("Is it in the circle? " + PointInCircle);
        }
    }
}
