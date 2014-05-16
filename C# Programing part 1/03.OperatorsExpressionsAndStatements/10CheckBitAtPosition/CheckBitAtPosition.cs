using System;

//Write a boolean expression that returns if the bit
//at position p (counting from 0) in a given integer 
//number v has value of 1. Example: v=5; p=1  false.


class CheckBitAtPosition
{
    static void Main()
    {
        Console.WriteLine("Enter position for bit to be checked : ");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number to examinate : ");
        int v = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        int result = v & mask;
        result = result >> p;
        Console.WriteLine(result == 1);
    }
}
