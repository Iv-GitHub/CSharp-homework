using System;

namespace NullValuesArithmetic
{
    class NullValuesArithmetic
    {
        static void Main()
        {
            int? nullinteger = null;
            Console.WriteLine("Integer with null value" + nullinteger);
            nullinteger = 11;
            Console.WriteLine("Integer with value 11" + nullinteger);
            double? nullDouble = null;
            Console.WriteLine("Double with null value" + nullDouble);
            nullDouble = 92.74;
            Console.WriteLine("Double with some value" + nullDouble);
        }
    }
}
