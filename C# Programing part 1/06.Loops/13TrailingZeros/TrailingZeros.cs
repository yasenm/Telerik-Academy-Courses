using System;
using System.Numerics;

//Write a program that calculates for given N how many trailing zeros 
//present at the end of the number N!. Examples:
//    -N = 10  N! = 3628800  2
//    -N = 20  N! = 2432902008176640000  4
//Does your program work for N = 50 000?
//Hint: The trailing zeros in N! are equal to the number of its prime
//divisors of value 5. Think why!

namespace _13TrailingZeros
{
    class TrailingZeros
    {
        static void Main()
        {
            Console.Write("Enter value for 'N' = ");
            int N = int.Parse(Console.ReadLine());
            BigInteger factN = 1;
            int counter = 0;        // will represent the count of trailing zeros
            // loop for N!
            for (int i = 1; i <= N; i++)
            {
                factN *= i;
            }
            Console.WriteLine("The chosen number N! = {0}", factN);
            // while the reminder is 0 we keep looping
            while (factN % 10 == 0)
            {
                // diving by 10 will leave us the same integer without its last 0 which after
                // every remove we count by adding 1 to our counter
                factN = factN / 10;
                counter++;
            }
            Console.WriteLine("The trailing zeros number is ---> {0}", counter);
        }
    }
}
