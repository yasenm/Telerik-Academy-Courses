using System;

//Write an expression that checks if given positive integer number n (n ≤ 100)
//is prime. E.g. 37 is prime

class CheckIfIntegerIsPrime
{
    static void Main()
    {
        Console.WriteLine("Enter number to see if it's prime : ");
        int x = int.Parse(Console.ReadLine());
        int i = 2;
        bool result = true;
        while ( i < x )
        {
            if ( x % i == 0 )
            {
                result = false;
                break;
            }
            i++;
        }
        Console.WriteLine(result? "Number is prime" : "Number is not prime" );
    }
}
