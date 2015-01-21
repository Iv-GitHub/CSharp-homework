using System;

namespace EmployeeData
{
    class  EmployeeData
    {
        static void Main()
        {
            String FirstName = "Eve";
            String LastName = "Mankova";
            sbyte Age = 22;
            char Gender = 'f';
            long PersonalNum = 8306112507;
            int UniqueEmpNum = 27569999;
            Console.WriteLine("First name: {0} \nLast name: {1} \nAge: {2} \nGender: {3} \nPersonalNumber: {4} \nUniqueEmpNumber {5}", FirstName, LastName, Age, Gender, PersonalNum, UniqueEmpNum);     
        }
    }
}
