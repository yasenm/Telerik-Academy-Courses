using System;

//Write a program that prints all the numbers from 1 to N,
//that are not divisible by 3 and 7 at the same time.

class NumsNotDivisibleBy3and7
{
    static void Main()
    {
        Console.Write("Enter value for N = ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("All numbers from 1 to N not divisible by 3 and 7 at the same time :");
        for (int i = 1; i <= n; i++)
        {
            if ((i % 3 == 0) && (i % 7 == 0))
            {
                continue;
            }
            Console.Write(i + ", ");
        }
    }
}
