using System;

//Write a program that reads the coefficients a, b and c of
//a quadratic equation ax2+bx+c=0 and solves it (prints its real roots).

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Enter values for quadratic equation arguments 'a', 'b' and 'c'.");
        Console.Write("Enter value for 'a' : ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter value for 'b' : ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter value for 'c' : ");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("The equations now looks like : '{0:0.000}x^2 + {1:0.000}x + {2:0.000} = 0'", a, b, c);
        double x1 = 0;
        double x2 = 0;
        double discriminant = b * b - 4 * a * c;
        if ( discriminant >= 0 )
        {
            if (discriminant == 0)
            {
                x1 = x2 = - b / ( 2 * a );
                Console.WriteLine("There is only one real root x1,x2 = {0}", x1);
            }
            else
            {
                x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine("There are two real roots for that equation " +
                    "\nx1 = {0:0.000} \nx2 = {1:0.000}", x1, x2);
            }
        }
        else
        {
            Console.WriteLine("There are no real roots!");
        }
    }
}