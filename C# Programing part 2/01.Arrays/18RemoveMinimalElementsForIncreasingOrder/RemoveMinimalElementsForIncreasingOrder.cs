using System;

//* Write a program that reads an array of integers and removes 
//from it a minimal number of elements in such way that the 
//remaining array is sorted in increasing order. 
//Print the remaining sorted array.
//Example:
//{6, 1, 4, 3, 0, 3, 6, 4, 5}  {1, 3, 3, 4, 5}

namespace _18RemoveMinimalElementsForIncreasingOrder
{
    class RemoveMinimalElementsForIncreasingOrder
    {
        static void Main()
        {
            //default input values
            Console.Write("Enter length for array N = ");
            int N = int.Parse(Console.ReadLine());

            int[] arr = new int[N];
            Console.WriteLine(arr.Length);
            //For loop to input the set of numbers
            Console.WriteLine("Enter value for members of array");
            for (int i = 0; i < N; i++)
            {
                Console.Write("Enter vlaue for arr[{0}] : ",i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            int[] arrB = new int[N];
            int[] arrC = new int[N];
            int l = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int k = 0;
                arrB[k] = arr[i];
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] >= arrB[k])
                    {
                        k++;
                        arrB[k] = arr[j];
                    }
                }
                if (k > l)
                {
                    l = k;
                    for (int index = 0; index < k; index++)
                    {
                        arrC[index] = arrB[index];
                    }
                }
            }
            Console.WriteLine("asdas");
            for (int i = 0; i < l; i++)
            {
                Console.Write("{0,0:000},", arrC[i]);
            }

        }
    }
}
