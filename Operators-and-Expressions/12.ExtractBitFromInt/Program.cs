using System;

namespace _12.ExtractBitFromInt
{
    class ExtractBitFromInt
    {
        static void Main()
        {
            Console.Write("Enter integer: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter position: ");
            int p = int.Parse(Console.ReadLine());

            byte BitAtPosP = (byte)((n >> p) & 1);
            Console.WriteLine("Bit at #{0} is {1}", p, BitAtPosP);
        }
    }
}
