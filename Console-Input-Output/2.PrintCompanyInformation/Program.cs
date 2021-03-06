﻿//A company has name, address, phone number, fax number, web site and manager. 
//The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.

using System;

namespace _2.PrintCompanyInformation
{
    class PrintCompanyInformation
    {
        static void Main()
        {
            Console.WriteLine("Company name:");
            string cName = Console.ReadLine();
            Console.WriteLine("Company address:");
            string cAddress = Console.ReadLine();
            Console.WriteLine("Phone number:");
            string cPhone = Console.ReadLine();
            Console.WriteLine("Fax number:");
            string cFax = Console.ReadLine();
            Console.WriteLine("Web site:");
            string cWebSite = Console.ReadLine();
            Console.WriteLine("Manager first name:");
            string manager = Console.ReadLine();
            string mFName = Console.ReadLine();
            Console.WriteLine("Manager last name:");
            string mLName = Console.ReadLine();
            Console.WriteLine("Manager age:");
            string mAge = (Console.ReadLine());
            Console.WriteLine("Manager phone:");
            string mPhone = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("{0}\nAddress: {1}\nTel.: {2}\nFax: {3}\nWeb site: {4}\n"
                                , cName, cAddress, cPhone, cFax, cWebSite);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})"
                                , mFName, mLName, mAge, mPhone);
        }
    }
}
