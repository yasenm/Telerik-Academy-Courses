using System;

//Write an expression that checks if given integer is odd or even.

class OddOrEven
{
    static void Main()
    {
        Console.WriteLine("Enter a number : ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine( (number % 2 == 0) ? "Number is even!" : "Number is odd!" );
    }
}
