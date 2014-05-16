using System;

//Write a program that shows the sign (+ or -) of the product of three 
//real numbers without calculating it. Use a sequence of if statements.

class ShowSignOfProduct
{
    static void Main()
    {
        Console.WriteLine("Check sign of product of next 3 integers!");
        Console.Write("Enter value for 'a' : ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter value for 'b' : ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Enter value for 'c' : ");
        int c = int.Parse(Console.ReadLine());
        int product = a + b + c;
        if ( product >= 0 )
        {
            Console.WriteLine("Sign is '+'");
        }
        else
        {

            Console.WriteLine("Sign is '-'");
        }
    }
}
