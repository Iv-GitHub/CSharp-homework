using System;

namespace StringsandObjects
{
    class StringsandObjects
    {
        static void Main()
        {
            string one = "Hello";
            string two = "World";
            object concat = one + ", " + two;
            string newSentence = (string)concat;
            Console.WriteLine(concat + "! :)");
        }
    }
}
