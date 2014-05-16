using System;
using System.Numerics;

//Write a program to calculate n! for each n in the range [1..100].
//Hint: Implement first a method that multiplies a number represented 
//as array of digits by given integer number. 

namespace _10NFactorial
{
    class NFactorial
    {
        static BigInteger NumberFactorial(int number) 
        {
            BigInteger result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }

        static void Main()
        {
            Console.Write("Enter value for 'n' bewtween 1 and 100 : ");
            int n = int.Parse(Console.ReadLine());
            BigInteger result = NumberFactorial(n);
            Console.WriteLine("{0} factorial is : {1}",n,result);

        }
    }
}
