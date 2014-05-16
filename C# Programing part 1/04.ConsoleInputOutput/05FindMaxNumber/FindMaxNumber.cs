using System;

//Write a program that gets two numbers from the console and prints 
//the greater of them. Don’t use if statements.

class FindMaxNumber
{
    static void Main()
    {
        Console.WriteLine("Enter two numbers and check which one is greater.");
        Console.Write("Enter 'first' value out of two : ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter 'second' value out of two : ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("The greater one is {0}", Math.Max(a, b));
    }
}
