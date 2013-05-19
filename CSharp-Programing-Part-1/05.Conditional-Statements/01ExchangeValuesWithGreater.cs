using System;

//Write an if statement that examines two integer variables
//and exchanges their values if the first one is greater
//than the second one.

class ExchangeValuesWithGreater
{
    static void Main()
    {
        Console.Write("Enter value for first number : ");
        int first = int.Parse(Console.ReadLine());
        Console.Write("Enter value for second number : ");
        int second = int.Parse(Console.ReadLine());
        int temp = 0;
        if ( first > second)
        {
            temp = first;
            first = second;
            second = temp;
            Console.WriteLine("First number is greater then second!");
            Console.WriteLine("First now is : {0}", first);
            Console.WriteLine("Second now is : {0}", second);
        }
        else if (first == second)
        {
            Console.WriteLine("Numbers are equal!");
        }
        else
        {
            Console.WriteLine("First number is lower then second!");
        }
    }
}
