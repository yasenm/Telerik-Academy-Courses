using System;

//Write a program that finds the most frequent number in an array. Example:
//{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)

namespace _09MostFrequentNumber
{
    class MostFrequentNumber
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
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0,0:000},", arr[i]);
            }
            Console.WriteLine();

            //---- Solving part of exercise
            //---- we need to initiate counter and result that will hold our output datas
            int counter = 0;
            int currentInt = 0;
            int result = 0;
            int resultCounter = 0;
            //---- loop through the array to find maximal ocurance of number
            for (int i = 0; i < arr.Length; i++)
            {
                currentInt = arr[i];
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[j] == currentInt)
                    {
                        counter++;
                    }
                    if (counter > resultCounter)
                    {
                        resultCounter = counter;
                        result = currentInt;
                    }
                }
                counter = 0;
            }
            //---- Printing results
            Console.WriteLine("The most frequent integer is {0} and the times it ocures is {1}", result, resultCounter);

        }
    }
}
