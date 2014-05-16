using System;

//Write a program that reads two positive integer numbers and prints
//how many numbers p exist between them such that the reminder of the
//division by 5 is 0 (inclusive). Example: p(17,25) = 2.

class PrintNumbersBetweenInsDiv5and0
{
    static void Main()
    {
        Console.WriteLine("Enter positive integer values!");
        Console.Write("Enter 'first' value out of two : ");
        uint firstNum = uint.Parse(Console.ReadLine());
        Console.Write("Enter 'second' value out of two : ");
        uint secondNum = uint.Parse(Console.ReadLine());
        int p = 0;
        for (uint i = firstNum; i <= secondNum; i++)
        {
            if ((i % 5) == 0)
            {
                p++;
            }
        }
        Console.WriteLine("The number of integers between {0} and {1} between them such " + 
            "that the reminder of the division by 5 is 0 (inclusive)" + 
            " p({0}/{1}) = {2}", firstNum, secondNum, p);
    }
}
