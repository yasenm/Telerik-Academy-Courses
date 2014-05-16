using System;

//Write a program that finds the index of given element in a sorted array 
//of integers by using the binary search algorithm (find it in Wikipedia).

namespace _11BinarySearch
{
    class BinarySearch
    {
        static void Main()
        {
            Console.Write("Enter length of array : ");
            int N = int.Parse(Console.ReadLine());
            int[] arr = new int[N];
            Random randomNumber = new Random();

            //---- inputs values in new array 
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = randomNumber.Next(-10, 10);
            }
            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0,0:000},", arr[i]);
            }
            Console.WriteLine();

            //----- binary search algo

            //----- enter the number we are gonna be looking for
            Console.WriteLine("Enter the number which index we are goin to be looking for");
            int X = int.Parse(Console.ReadLine());
            int lowerIndex = 0;
            int higherIndex = arr.Length;
            int result = 0;

            //----- binary search loop
            while (true)
            {
                if (X == arr[(higherIndex + lowerIndex) / 2])
                {
                    result = (higherIndex + lowerIndex) / 2;
                    break;
                }
                if (X > arr[(higherIndex + lowerIndex) / 2])
                {
                    lowerIndex = (higherIndex + lowerIndex) / 2;
                }
                else
                {
                    higherIndex = (higherIndex + lowerIndex) / 2;
                }
            }
            Console.WriteLine("The number {0} is in position arr[{1}]", X, result);
        }
    }
}
