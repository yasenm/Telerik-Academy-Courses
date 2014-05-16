using System;

//Write a program that finds the maximal increasing sequence in an array.
//Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.

namespace _05MaximalAccendingSequence
{
    class MaximalAccendingSequence
    {
        static void Main()
        {
            Console.Write("Enter length of array : ");
            int N = int.Parse(Console.ReadLine());
            int[] arr = new int[N];
            int counter = 0;
            int result = 0;
            int tempCounter = 1;

            //---- Enter integers in array
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("arr[{0}] = ",i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            //---- Loop to find the sequence of increasing members
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i-1] + 1 == arr[i])
                {
                    tempCounter++;
                }
                else
                {
                    tempCounter = 1;
                }
                if (tempCounter > counter)
                {
                    counter = tempCounter;
                    result = arr[i];
                }
            }

            //---- Get a array with the result
            int[] resultArr = new int[counter];
            for (int i = 0; i < resultArr.Length; i++)
            {
                resultArr[i] = result - counter + i + 1;
            }
            //---- print result array
            Console.Write("The largest accending sequence is : ");
            for (int i = 0; i < resultArr.Length; i++)
            {
                Console.Write("{0}, ", resultArr[i]);
            }
            Console.Write(".");
            Console.WriteLine();
        }
    }
}
