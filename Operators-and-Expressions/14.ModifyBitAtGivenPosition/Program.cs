//We are given an integer number n, a bit value v (v=0 or 1) and a position p.
//Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p 
//from the binary representation of n while preserving all other bits in n.
using System;

namespace _14.ModifyBitAtGivenPosition
{
    class ModifyBitAtGivenPosition
    {
        static void Main()
        {
            Console.Write("Enter integer: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter value: ");
            int v = int.Parse(Console.ReadLine());
            Console.Write("Enter position: ");
            int p = int.Parse(Console.ReadLine());

            Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
            int NewVal;
            int BitAtRight;
            if (v == 1)
            {
                BitAtRight = 1 << p;
                NewVal = n | BitAtRight;
                Console.WriteLine(Convert.ToString(NewVal, 2).PadLeft(32, '0'));
                Console.WriteLine("Result: " + NewVal);
            }
            else if (v == 0)
            {
                BitAtRight = ~(1 << p);
                NewVal = n & BitAtRight;
                Console.WriteLine(Convert.ToString(NewVal, 2).PadLeft(32, '0'));
                Console.WriteLine("Result: " + NewVal);
            }
            else
            {
                Console.WriteLine("Invalid input, try again!");
            }
        }
    }
}
