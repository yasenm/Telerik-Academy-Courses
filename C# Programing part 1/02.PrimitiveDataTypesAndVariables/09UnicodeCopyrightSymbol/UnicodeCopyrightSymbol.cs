using System;

//Write a program that prints an isosceles triangle of 9 copyright
//symbols ©. Use Windows Character Map to find the Unicode code of the
//© symbol. Note: the © symbol may be displayed incorrectly.

class UnicodeCopyrightSymbol
{
    static void Main()
    {
        char newChar1 = '\u00A9';
        Console.WriteLine("{0}", newChar1);
        Console.WriteLine("{0}{0}", newChar1);
        Console.WriteLine("{0}{0}{0}", newChar1);
        Console.WriteLine("{0}{0}", newChar1);
        Console.WriteLine("{0}", newChar1);
    }
}
