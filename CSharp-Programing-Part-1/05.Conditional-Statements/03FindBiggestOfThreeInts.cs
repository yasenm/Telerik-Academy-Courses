using System;

//Write a program that finds the biggest of three integers using nested if statements.

class FindBiggestOfThreeInts
{
    static void Main()
    {
        Console.WriteLine("Enter 3 integers and see which one is the biggest!");
        Console.Write("Enter value for first number : ");
        int first = int.Parse(Console.ReadLine());
        Console.Write("Enter value for second number : ");
        int second = int.Parse(Console.ReadLine());
        Console.Write("Enter value for thirth number : ");
        int thirth = int.Parse(Console.ReadLine());
        if ( first > second && first > second)
        {
            Console.WriteLine("Biggest is the first one {0}", first);
        }
        else if (first == second && first == thirth)
        {
            Console.WriteLine("The three integers are equal");
        }
        else
        {
            if ( second > first && second > thirth)
            {
                Console.WriteLine("Biggest is the second one {0}", second);
            }
            else if (thirth > first && thirth > second)
            {
                Console.WriteLine("Biggest is the thirth one {0}", thirth);
            }
        }
    }
}
