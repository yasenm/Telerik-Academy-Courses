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
        Console.Write("{0,-35} : ", "Enter company name");
        string companyName = Console.ReadLine();
        Console.Write("{0,-35} : ", "Enter company address");
        string companyAddress = Console.ReadLine();
        Console.Write("{0,-35} : ", "Enter company phone number");
        string companyPhone = Console.ReadLine();
        Console.Write("{0,-35} : ", "Enter company fax number");
        string companyFax = Console.ReadLine();
        Console.Write("{0,-35} : ", "Enter company web site");
        string companyWebSite = Console.ReadLine();
        Console.Write("{0,-35} : ", "Enter company manager first name");
        string managerFirstName = Console.ReadLine();
        Console.Write("{0,-35} : ", "Enter company manager last name");
        string managerLastName = Console.ReadLine();
        Console.Write("{0,-35} : ", "Enter company manager Age");
        int managerAge = int.Parse(Console.ReadLine());
        Console.Write("{0,-35} : ", "Enter company manager phone number");
        string managerPhone = Console.ReadLine();
        Console.WriteLine("{0, -20} | {1, -20} |", "Company", companyName);
        Console.WriteLine("{0, -20} | {1, -20} |", "Company address", companyAddress);
        Console.WriteLine("{0, -20} | {1, -20} |", "Company phone", companyPhone);
        Console.WriteLine("{0, -20} | {1, -20} |", "Company fax", companyFax);
        Console.WriteLine("{0, -20} | {1, -20} |", "Company web site", companyWebSite);
        Console.WriteLine("-------------------------------");
        Console.WriteLine("{0, -20} :", "Company manager");
        Console.WriteLine("{0, -20} : {1, -20} |", "Manager first name", managerFirstName);
        Console.WriteLine("{0, -20} : {1, -20} |", "Manager last name", managerLastName);
        Console.WriteLine("{0, -20} : {1, -20} |", "Manager age", managerAge);
        Console.WriteLine("{0, -20} : {1, -20} |", "Manager phone", managerPhone);
    }
}

