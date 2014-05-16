using System;

//Write an expression that calculates trapezoid's area by given sides a and b and height h.

class CalculateTrapezoidArea
{
    static void Main()
    {
        Console.WriteLine("Calculate trapezoiod area");
        Console.WriteLine("Enter value for base 'a' : ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for base 'b' : ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value height 'h' : ");
        int h = int.Parse(Console.ReadLine());
        double trArea = h * ( (a + b) / 2);
        Console.WriteLine("Trapezoid area is : {0}", trArea);
    }
}
