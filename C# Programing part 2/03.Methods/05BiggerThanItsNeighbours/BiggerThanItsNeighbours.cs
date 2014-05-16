using System;
using System.Collections;

//Write a method that checks if the element at given position in given 
//array of integers is bigger than its two neighbors (when such exist).

namespace _05BiggerThanItsNeighbours
{
    class BiggerThanItsNeighbours
    {
        //First two methods for generating the array and printing it
        static void PrintArray(IEnumerable array)
        {
            Console.WriteLine("Your array is : ");
            foreach (var item in array)
            {
                Console.Write("{0,2},", item);
            }
            Console.WriteLine();
        }

        static void FillArray(int[] array)
        {
            Random randomNumber = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randomNumber.Next(0, 10);
            }
        }

        static void CheckForBiggerAtIndex(int index, int[] array) 
        {
            int lowerIndex = index - 1;
            int higherIndex = index + 1;
            //check if the index entered by the user is correct and has two neighbours if not print that we cant find such
            if (index >= array.Length - 1 || index <= 0)
            {
                Console.WriteLine("The index you entered is invalid.");
            }
            //else we check the truth statement
            else
            {
                if (array[lowerIndex] < array[index] && array[index] > array[higherIndex])
                {
                    Console.WriteLine("Number {0} at position {1} is bigger than his two neighbours.",array[index],index);
                }
                else
                {
                    Console.WriteLine("Number {0} at position {1} isn't bigger than his two neighbours.", array[index], index);
                }
            }
        }

        static void Main()
        {
            Console.Write("Chose length for Array : ");
            int arrayLen = int.Parse(Console.ReadLine());
            int[] array = new int[arrayLen];
            FillArray(array);
            PrintArray(array);
            Console.WriteLine("Chose index and check if member there is bigger than its neighbours.");
            Console.Write("Enter index in array = ");
            int index = int.Parse(Console.ReadLine());
            CheckForBiggerAtIndex(index, array);
        }
    }
}
