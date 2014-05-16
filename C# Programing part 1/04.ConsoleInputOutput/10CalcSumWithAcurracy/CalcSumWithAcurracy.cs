using System;

//Write a program to calculate the sum (with accuracy of 0.001):
//1 + 1/2 - 1/3 + 1/4 - 1/5 + ...

class CalcSumWithAcurracy
{
    static void Main()
    {
        Console.WriteLine("The sum of '1 + 1/2 - 1/3 + 1/4 - 1/5 + ...' with accuracy 0.001 should be :");
        decimal a = 1m;
        decimal b = 2m;
        decimal sum = 1m;
        while ( 1m / b > 0.001m)
        {
            a = a / b;
            sum += a;
            b++;
            if ( (b % 2) == 0)
            {
                a = 1m;
            }
            else
            {
                a = -1m;
            }
        }
        Console.WriteLine("The sum is : {0:0.000}",sum);
    }
}
