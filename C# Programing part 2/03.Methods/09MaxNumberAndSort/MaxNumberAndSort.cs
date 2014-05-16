using System;
using System.Collections;

//Write a method that return the maximal element in a portion of array of 
//integers starting at given index. Using it write another method that 
//sorts an array in ascending / descending order.

namespace _09MaxNumberAndSort
{
    class MaxNumberAndSort
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
                array[i] = randomNumber.Next(0, 101);
            }
        }

        static int MaxInt(int index, int[] array) 
        {
            int result = array[index];
            for (int i = index; i < array.Length - 1; i++)
            {
                if (array[i + 1] > result)
                {
                    result = array[i + 1];
                }
            }
            return result;
        }

        //Sort array in accending order
        static int[] SortAccending(int[] unsortedArray)
        {
            int[] sortedArray = new int[unsortedArray.Length];
            int lowerIndexer;
            int tempHolder;

            for (int i = 0; i < sortedArray.Length; i++)
            {
                //---- we give the lowerIndexer 'i' as a value
                lowerIndexer = i;
                for (int nextIndex = 1 + i; nextIndex < sortedArray.Length; nextIndex++)
                {
                    //---- if the previous member is bigger than the next one we 
                    //---- switch their indexes and after that positions with temp holders
                    if (unsortedArray[lowerIndexer] > unsortedArray[nextIndex])
                    {
                        lowerIndexer = nextIndex;
                    }
                }
                //---- the tempHolder holds the lower integer and pu
                tempHolder = unsortedArray[lowerIndexer];
                unsortedArray[lowerIndexer] = unsortedArray[i];
                sortedArray[i] = tempHolder;
            }
            return sortedArray;
        }

        //Sort array in decending order
        static int[] SortDecending(int[] unsortedArray) 
        {
            int[] sortedArray = new int[unsortedArray.Length];
            int[] sortedDecendingArray = new int[unsortedArray.Length];
            sortedArray = SortAccending(unsortedArray);
            //reverse algorithm
            for (int i = sortedArray.Length - 1, j = 0; i >= 0; i--,j++)
            {
                sortedDecendingArray[j] = sortedArray[i];
            }
            return sortedDecendingArray;
        }

        static void Main()
        {
            Console.Write("Chose length for Array : ");
            int arrayLen = int.Parse(Console.ReadLine());
            int[] array = new int[arrayLen];
            FillArray(array);
            PrintArray(array);
            Console.WriteLine("Chose index between 0 and {0}", array.Length - 1);
            int index = int.Parse(Console.ReadLine());
            int numberIndex = MaxInt(index, array);
            Console.WriteLine("Max int from {0} to {1} is {2}", index, array.Length, numberIndex);
            //Sort accending the array and print
            array = SortAccending(array);
            PrintArray(array);
            //Sort decending and print
            array = SortDecending(array);
            PrintArray(array);
        }
    }
}
