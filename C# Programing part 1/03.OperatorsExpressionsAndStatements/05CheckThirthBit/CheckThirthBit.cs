using System;

//Write a boolean expression for finding if the bit 3
//(counting from 0) of a given integer is 1 or 0.


class CheckThirthBit
{
    static void Main()
    {
        int p = 3;
        Console.WriteLine("Enter number : ");
        int number = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        int result = mask & number;
        result = result >> p;
        Console.WriteLine((result == 1) ? "Thirth bit is 1" : "Thirth bit is 0");
    }
}
