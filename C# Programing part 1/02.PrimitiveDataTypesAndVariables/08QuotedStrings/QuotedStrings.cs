using System;

//Declare two string variables and assign them with following value:
//--------------------------------------------
//The "use" of quotations causes difficulties.
//--------------------------------------------
//Do the above in two different ways: with and without using quoted strings.


class QuotedStrings
{
    static void Main()
    {
        string newStr1 = @"The ""use"" of quotations causes difficulties.";
        string newStr2 = "The \"use\" of quotations causes difficulties.";
        Console.WriteLine(newStr1);
        Console.WriteLine(newStr2);
    }
}
