using System;

//Write an expression that checks for given point (x, y) 
//if it is within the circle K( (1,1), 3) and out of the 
//rectangle R(top=1, left=-1, width=6, height=2).


class CheckForPointPlace
{
    static void Main()
    {
        //circle parameters
        int circleCenterX = 1;      //coordinates of center
        int circleCenterY = 1;      //coordinates of center
        int circleRadius = 3;       //circkeRadius

        //input coordinates data
        Console.WriteLine("Enter point coordinates");
        Console.WriteLine("Enter positon on 'x' : ");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter positon on 'y' : ");
        int y = int.Parse(Console.ReadLine());

        //check if within the circle
        double newCircleCenterX = Math.Pow((x - circleCenterX), 2);
        double newCircleCenterY = Math.Pow((y - circleCenterY), 2);
        double circleRadiusPow = Math.Pow(circleRadius, 2);

        bool circle = newCircleCenterX + newCircleCenterY <= circleRadiusPow;
        Console.WriteLine(circle ? "Point is in circle" : "Point is not in circle");

        //rectangle data
        int rectStartX = -1;
        int rectStartY = 1;
        int rectEndX = 5;
        int rectEndY = -1;

        //check if it's in rectangle
        if (x < rectStartX)
        {
            Console.WriteLine("Point is outside of rectangle");
        }
        else if (x > rectEndX)
        {
            Console.WriteLine("Point is outside of rectangle");
        }
        else if (y < rectStartY)
        {
            Console.WriteLine("Point is outside of rectangle");
        }
        else if (y < rectEndY)
        {
            Console.WriteLine("Point is outside of rectangle");
        }
        else
        {
            Console.WriteLine("Point is in rectangle");
        }
    }
}
