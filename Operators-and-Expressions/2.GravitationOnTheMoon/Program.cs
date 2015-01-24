using System;

namespace _2.GravitationOnTheMoon
{
    class GravitationOnTheMoon
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your weight:");
            string input = Console.ReadLine();
            double weight = double.Parse(input);

            double WeightOnTheMoon = weight * 0.17;
            Console.WriteLine("Your weight on the moon will be: " + WeightOnTheMoon);
        }
    }
}
