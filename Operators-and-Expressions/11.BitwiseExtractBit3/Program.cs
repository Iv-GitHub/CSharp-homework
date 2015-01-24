using System;

namespace _11.BitwiseExtractBit3
{
    class BitwiseExtractBit3
    {
        static void Main()
        {
            Console.Write("Enter unsigned integer:");
            uint n = uint.Parse(Console.ReadLine());
            byte BitAtThree = (byte)((n >> 3) & 1);
            Console.WriteLine("Bit at #3 is: " + BitAtThree);
        }
    }
}
