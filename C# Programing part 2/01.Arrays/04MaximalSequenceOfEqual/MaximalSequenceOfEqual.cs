using System;

//Write a program that finds the maximal sequence of equal elements in an array.

//Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.

namespace _04MaximalSequenceOfEqual
{
    class MaximalSequenceOfEqual
    {
        static void Main()
        {
            Console.Write("Enter length of array : ");
            int N = int.Parse(Console.ReadLine());
            int[] arr = new int[N];
            int counter = 0;
            int tempCounter = 1;
            int result = 0;
            //---- Input the numbers in the array
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            //---- Loop that checks for maximal sequnce of equal
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i-1] == arr[i])
                {
                    tempCounter++;
                }
                else
                {
                    tempCounter = 1;
                }
                if (tempCounter > counter)
                {
                    result = arr[i - 1];
                    counter = tempCounter;
                }
            }

            //---- Make array out of the sequence
            int[] resultArray = new int[counter];
            for (int i = 0; i < counter; i++)
            {
                resultArray[i] = result;
            }
            //---- Print the result
            Console.Write("The largest sequence is : ");
            for (int i = 0; i < resultArray.Length; i++)
            {
                Console.Write("{0}, ", resultArray[i]);
            }
            Console.Write(".");
            Console.WriteLine();
        }
    }
}
