using System;

//Write a program that reads 3 integer numbers from the console and prints their sum.

class SumOf3Ints
{
    static void Main()
    {
        Console.Write("Enter value for 'a' : ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter value for 'b' : ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Enter value for 'c' : ");
        int c = int.Parse(Console.ReadLine());
        int sum = a + b + c;
        Console.WriteLine("The sum of {0} + {1} + {2} = {3}", a, b, c, sum);
    }
}