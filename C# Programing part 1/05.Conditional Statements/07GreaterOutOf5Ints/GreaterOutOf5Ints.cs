using System;

//Write a program that finds the greatest of given 5 variables.

class GreaterOutOf5Ints
{
    static void Main()
    {
        Console.WriteLine("Enter 3 integers too sort them in descending order!");
        Console.Write("Enter value for first number : ");
        double first = double.Parse(Console.ReadLine());
        Console.Write("Enter value for second number : ");
        double second = double.Parse(Console.ReadLine());
        Console.Write("Enter value for thirth number : ");
        double thirth = double.Parse(Console.ReadLine());
        Console.Write("Enter value for thirth number : ");
        double fourth = double.Parse(Console.ReadLine());
        Console.Write("Enter value for thirth number : ");
        double fifth = double.Parse(Console.ReadLine());
        double max1 = Math.Max(first, second);
        double max2 = Math.Max(thirth, fourth);
        if ( max1 > max2)
        {
            Console.WriteLine(Math.Max(max1, fifth));
        }
        else
        {
            Console.WriteLine(Math.Max(max2, fifth));
        }
    }
}