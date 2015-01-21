using System;

namespace BankAccountData
{
    class BankAccountData
    {
        static void Main()
        {
            string FirstName = "Eve";
            string MiddleName = "Mankova";
            string LastName = "Stnakovna";
            double balance = 11386500.92;
            string BankName = "UniCredit";
            string IBan = "BG47UNCR814043957291";
            long cardNum1 = 7452178912635832;
            long cardNum2 = 5836759857434987;
            long dinersclub = 43194867266883;
            Console.WriteLine("Full name: {0} {1} {2} \nBalance: {3} \nBank: {4} \nIBAN: {5} \nCard Numbers: \nVisa: {6} \nDiners Club: {7} \nMaestro: {8}", 
                FirstName, MiddleName, LastName, balance, BankName, IBan, cardNum1, cardNum2, dinersclub);
        }
    }
}
