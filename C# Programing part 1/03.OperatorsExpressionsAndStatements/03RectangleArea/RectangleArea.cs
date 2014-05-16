using System;

//Write an expression that calculates rectangle’s area by given width and height.

class RectangleArea
{
    static void Main()
    {
        Console.WriteLine("Enter value for width : ");
        int width = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for height : ");
        int height = int.Parse(Console.ReadLine());
        int squearArea = (width * width) + (height * height);
        Console.WriteLine("Square area is : {0}", squearArea);
    }
}
