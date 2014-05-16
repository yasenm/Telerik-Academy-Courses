using System;

//Declare a character variable and assign it with the symbol that
//has Unicode code 72. Hint: first use the Windows Calculator to
//find the hexadecimal representation of 72.


class DeclareACharVariable72
{
    static void Main()
    {
        char newChar = '\u0048';
        Console.WriteLine("The hexadecimal representation of 72 is 48 , so '\\u0048' is = " + newChar);
    }
}