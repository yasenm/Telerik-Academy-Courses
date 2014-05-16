using System;

//Write a program that reads a number N and calculates the sum
//of the first N members of the sequence of Fibonacci: 0, 1, 1,
//2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

//Each member of the Fibonacci sequence (except the first two)
//is a sum of the previous two members.

namespace _07Fibonacci
{
    class Fibonacci
    {
        static void Main()
        {
            Console.WriteLine("Enter value for N = ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Sequence is : ");
            ulong memberMinus2 = 0;
            ulong memberMinus1 = 1;
            ulong memberCurrent = memberMinus2 + memberMinus1;
            ulong sum = 0;
            for (int i = 0; i < N; i++)
            {
                sum += memberMinus2;
                Console.Write(memberMinus2 + ",");
                memberMinus2 = memberMinus1;
                memberMinus1 = memberCurrent;
                memberCurrent = memberMinus2 + memberMinus1;
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
