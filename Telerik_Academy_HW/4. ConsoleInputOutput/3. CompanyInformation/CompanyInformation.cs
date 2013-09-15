using System;

class CompanyInformation
{
    static void Main()
    {
        Console.Write("Company name: ");
        string companyame = Console.ReadLine();

        Console.Write("Company adress: ");
        string companyAddress = Console.ReadLine();

        Console.Write("Company phone number: ");
        string companyPhoneNumber = Console.ReadLine();

        Console.Write("Company fax number: ");
        string companyFaxNumber = Console.ReadLine();

        Console.Write("Company web site: ");
        string companyWebSite = Console.ReadLine();

        Console.Write("Company manager first name: ");
        string managerFirstName = Console.ReadLine();

        Console.Write("Company manager last name: ");
        string managerLastName = Console.ReadLine();

        Console.Write("Company manager age: ");
        byte managerAge = byte.Parse(Console.ReadLine());

        Console.Write("Company manager phone number: ");
        string managerPhoneNumber = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Company name is {0}", companyame);
        Console.WriteLine("Company adress is {0}", companyAddress);
        Console.WriteLine("Company phone number is {0}", companyPhoneNumber);
        Console.WriteLine("Company fax number is {0}", companyFaxNumber);
        Console.WriteLine("Company web site is {0}", companyWebSite);
        Console.WriteLine("Company manager first name is {0}", managerFirstName);
        Console.WriteLine("Company manager last name is {0}", managerLastName);
        Console.WriteLine("Company manager age is {0}", managerAge);
        Console.WriteLine("Company manager phone number is {0}", managerPhoneNumber);
    }
}
