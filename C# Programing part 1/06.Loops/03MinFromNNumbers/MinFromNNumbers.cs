using System;

//Write a program that reads from the console a sequence of N integer
//numbers and returns the minimal and maximal of them.

namespace _03MinFromNNumbers
{
    class MinFromNNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter 5 numbers!");
            int numbers = 0;
            int[] arr = new int[5];
            do
            {
                Console.Write("Enter number :");
                arr[numbers] = int.Parse(Console.ReadLine());
                numbers++;
            } while (numbers < 5);
            int min = arr[0];
            int max = arr[0];
            for (int i = 1; i < 5; i++)
            {
                if ( min >= arr[i] )
                {
                    min = arr[i];
                }
                if ( max <= arr[i] )
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("Min input = {0} \nMax input = {1}", min, max);
        }
    }
}
