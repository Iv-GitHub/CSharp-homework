using System;

namespace QuotesinStrings
{
    class QuotesinStrings
    {
        static void Main()
        {
            string difficulties = "The \"use\" of quotations causes difficulties.";
            string quotation = @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine(difficulties + "\n" + quotation + "\n" + "Are they equal? -" + (difficulties == quotation));
        }
    }
}
