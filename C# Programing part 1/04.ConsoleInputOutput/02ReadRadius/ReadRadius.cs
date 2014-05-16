using System;

//Write a program that reads the
//radius r of a circle and prints its perimeter and area.

class ReadRadius
{
    static void Main()
    {
        Console.Write("Enter value for radius of circle 'r' : ");
        int r = int.Parse(Console.ReadLine());
        double circlePerimeter = 2 * Math.PI * r;
        double circleArea = Math.PI * Math.Pow(r, 2);
        Console.WriteLine("Circle perimeter is : {0}", circlePerimeter);
        Console.WriteLine("Circle area is : {0}", circleArea);
    }
}
