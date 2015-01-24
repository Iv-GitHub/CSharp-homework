using System;

namespace _15.BitsExchange
{
    class BitsExchange
    {
        static void Main()
        {
            Console.Write("Enter unsigned integer: ");
            int n = int.Parse(Console.ReadLine());

            int posOne = 3;
            int posTwo = 24;

            int mOne = 7 << posOne;
            int mTwo = 7 << posTwo;

            int getNumOne = n & mOne;
            int getNumTwo = n & mTwo;

            int change = (n & ~mOne) & ~mTwo;

            int mThree = (getNumOne >> posOne) << posTwo;
            int mFour = (getNumTwo >> posTwo) << posOne;

            int result = (change | mThree) | mFour;

            Console.WriteLine("Result:"+ n);
        }
    }
}
