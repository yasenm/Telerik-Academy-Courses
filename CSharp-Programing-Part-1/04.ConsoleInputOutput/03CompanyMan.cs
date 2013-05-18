using System;

//A company has name, address, phone number, fax number,
//web site and manager. The manager has first name, last name,
//age and a phone number. Write a program that reads the 
//information about a company and its manager and 
//prints them on the console.

class CompanyMan
{
    static void Main()
    {
        Console.Write("{0,-30} : ", "Enter company name");
        string companyName = Console.ReadLine();
        Console.Write("{0,30} : ", "Enter company address");
        string companyAddress = Console.ReadLine();
        Console.Write("{0,30} : ", "Enter company phone number");
        string companyPhone = Console.ReadLine();
        Console.Write("{0,30} : ", "Enter company fax number");
        string companyFax = Console.ReadLine();
        Console.Write("{0,30} : ", "Enter company web site");
        string companyWebSite = Console.ReadLine();
        Console.Write("{0,30} : ", "Enter company manager first name");
        string managerFirstName = Console.ReadLine();
        Console.Write("{0,30} : ", "Enter company manager last name");
        string managerLastName = Console.ReadLine();
        Console.Write("{0,30} : ", "Enter company manager Age");
        int managerAge = int.Parse(Console.ReadLine());
        Console.Write("{0,30} : ", "Enter company manager phone number");
        string managerPhone = Console.ReadLine();
    }
}
