using System;
using System.Collections;

//Write a method that returns the index of the first element in array that
//is bigger than its neighbors, or -1, if there’s no such element.
//Use the method from the previous exercise.

namespace _06FindFirstBiggerThanNeighbours
{
    class FindFirstBiggerThanNeighbours
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

        //Find first bigger than two neighbours
        static void FindBiggerThanNeighours(int[] array) 
        {
            bool thereIsNoSuchMember = true;
            for (int midIndex = 1; midIndex < array.Length - 1; midIndex++)
            {
                int lowerIndex = midIndex - 1;
                int higherIndex = midIndex + 1;
                if (array[lowerIndex] < array[midIndex] && array[midIndex] > array[higherIndex])
                {
                    Console.WriteLine("Number {0} at position {1} is bigger than his two neighbours.", array[midIndex], midIndex);
                    thereIsNoSuchMember = false;
                    break;
                }
            }
            if (thereIsNoSuchMember)
            {
                Console.WriteLine("No number bigger than it's neighbours found!");
            }
        }

        static void Main()
        {
            Console.Write("Chose length for Array : ");
            int arrayLen = int.Parse(Console.ReadLine());
            int[] array = new int[arrayLen];
            FillArray(array);
            PrintArray(array);
            FindBiggerThanNeighours(array);
        }
    }
}
