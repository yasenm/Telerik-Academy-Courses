using System;

//Sort 3 real values in descending order using nested if statements.

class SortThreeValues
{
    static void Main()
    {
        Console.WriteLine("Enter 3 integers too sort them in descending order!");
        Console.Write("Enter value for first number : ");
        int first = int.Parse(Console.ReadLine());
        Console.Write("Enter value for second number : ");
        int second = int.Parse(Console.ReadLine());
        Console.Write("Enter value for thirth number : ");
        int thirth = int.Parse(Console.ReadLine());
        if ( first > second && first > thirth)
        {
            if (second > thirth)
            {
                Console.WriteLine("In order : {0} | {1} | {2}", first, second, thirth);
            }
            else
            {
                Console.WriteLine("In order : {0} | {2} | {1}", first, second, thirth);
            }
        }
        else if (first == second && first == thirth)
        {
            Console.WriteLine("The three integers are equal");
        }
        else if ( second > first && second > thirth)
        {
            if (first > thirth)
            {
                Console.WriteLine("In order : {1} | {0} | {2}", first, second, thirth);
            }
            else
            {
                Console.WriteLine("In order : {1} | {2} | {0}", first, second, thirth);
            }
        }
        else if ( thirth > first &&  thirth > second )
        {
            if (first > second)
            {
                Console.WriteLine("In order : {2} | {0} | {1}", first, second, thirth);
            }
            else
            {
                Console.WriteLine("In order : {2} | {1} | {2}", first, second, thirth);
            }
        }
    }
}
