using System;

//Write a program to print the first 100 members of the sequence
//of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

class Fibonacci
{
    static void Main()
    {
        Console.WriteLine("First 100 member of the sequence of Fibonnacci are : ");
        Console.Write("Sequence is : ");
        ulong memberMinus2 = 0;
        ulong memberMinus1 = 1;
        ulong memberCurrent = memberMinus2 + memberMinus1;
        for (int i = 0; i < 102; i++)
        {
            Console.Write(memberMinus2 + ",");
            memberMinus2 = memberMinus1;
            memberMinus1 = memberCurrent;
            memberCurrent = memberMinus2 + memberMinus1;
        }
    }
}
