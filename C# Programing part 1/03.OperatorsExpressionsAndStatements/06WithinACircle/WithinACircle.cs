using System;

//Write an expression that checks if given point (x,  y) is within a circle K(O, 5).

class WithinACircle
{
    static void Main()
    {
        int radius = 5;
        double circleSurface = Math.PI * radius * radius; 

        Console.WriteLine("Enter point coordinates");
        Console.WriteLine("Enter positon on 'x' : ");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter positon on 'y' : ");
        int y = int.Parse(Console.ReadLine());
        int new_radius =  (x * x) + (y * y);
        double new_circleSurface = Math.PI * new_radius;
        Console.WriteLine((new_circleSurface < circleSurface) ? "Point is within the circle!" : "Point is out of the circle!");
    }
}
