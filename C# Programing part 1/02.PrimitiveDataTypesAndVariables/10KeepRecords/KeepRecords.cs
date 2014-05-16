using System;

//A marketing firm wants to keep record of its employees.
//Each record would have the following characteristics – first name,
//family name, age, gender (m or f), ID number,
//unique employee number (27560000 to 27569999).
//Declare the variables needed to keep the information for a 
//single employee using appropriate data types and descriptive names.

class KeepRecords
{
    static void Main()
    {
        string firstName = "Yasen";
        string familyName = "Mihaylov";
        byte age = 25;
        char gender = 'm';
        int idNumber = 4000415;
        int employeNumber = 27560045;
        Console.WriteLine("Employe data: \nFirst name : {0} \nFamily name : {1}\n" + 
        "Age : {2}\nGender : {3}\nID number : {4}\nEmploye number : {5}",
        firstName,familyName, age, gender, idNumber, employeNumber);
    }
}
