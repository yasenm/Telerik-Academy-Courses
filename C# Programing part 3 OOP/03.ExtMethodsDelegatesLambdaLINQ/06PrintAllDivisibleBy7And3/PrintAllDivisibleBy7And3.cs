// Exercise 06 : Write a program that prints from given array of integers
// all numbers that are divisible by 7 and 3. Use the built-in extension methods
// and lambda expressions. Rewrite the same with LINQ.

namespace _06PrintAllDivisibleBy7And3
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    class PrintAllDivisibleBy7And3
    {
        static void Main()
        {
            #region Generating the array with random number between 1 and 100
            Random randomNumber = new Random();
            Console.WriteLine("Enter array length : ");
            int arrayLength = int.Parse(Console.ReadLine());
            int[] array = new int[arrayLength];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randomNumber.Next(0, 101);
            }

            Console.WriteLine();
            Console.WriteLine("Generated array : ");

            foreach (var number in array)
            {
                Console.Write("{0}, ", number);
            }

            Console.WriteLine();
            #endregion

            // Lambda expression try
            var lambdaResult = array.Where( x => x % 7 == 0 & x % 3 == 0);
            Console.WriteLine("With Lambda result : ");
            foreach (var number in lambdaResult)
            {
                Console.Write("{0}, ", number);
            }
            Console.WriteLine();


            // LINQ part of exercise 
            var linqResult =
                from number in array
                where number % 7 == 0 && number % 3 == 0
                select number;
            Console.WriteLine("With LINQ result : ");
            foreach (var number in linqResult)
            {
                Console.Write("{0}, ", number);
            }
            Console.WriteLine();
        }

    }
}
