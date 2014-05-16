using System;
using System.Collections.Generic;

//* Write a program that reads an array of integers and removes from it
//a minimal number of elements in such way that the remaining array is
//sorted in increasing order. Print the remaining sorted array.
//Example:
//{6, 1, 4, 3, 0, 3, 6, 4, 5}  {1, 3, 3, 4, 5}

namespace _18CombinatoricAlgoSolution
{
    class CombinatoricAlgoSolution
    {
        static void Main()
        {
            //default input values
            Console.Write("Enter length for array N = ");
            int N = int.Parse(Console.ReadLine());

            int[] arr = new int[N];
            //For loop to input the set of numbers
            Console.WriteLine("Enter value for members of array");
            for (int i = 0; i < N; i++)
            {
                Console.Write("Enter vlaue for arr[{0}] : ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            //Variables that we will use in the solving
            List<int> ResultList = new List<int>();
            string tempResultString = "";
            //Sets and checkings
            int limit = (2 << (N - 1)) - 1;
            for (int i = 1; i <= limit; i++)
            {
                bool itsIncreasingOrder = false;
                List<int> tempResultList = new List<int>();
                for (int bitIndex = 0; bitIndex < N; bitIndex++)
                {
                    if (((i >> bitIndex) & 1) == 1)
                    {
                        tempResultList.Add(arr[bitIndex]);
                    }
                }
                //Check fore every element in the list if its lesser than its next one
                int counter = 1;
                if (tempResultList.Count > 1)
                {
                    for (int j = 1; j < tempResultList.Count; j++)
                    {
                        if (tempResultList[j - 1] <= tempResultList[j])
                        {
                            counter++;
                        }
                    }
                }
                //Check if the whole list is in increasing order
                if (counter == tempResultList.Count)
                {
                    itsIncreasingOrder = true;
                }
                //In case is increasing order check if the length is bigger if so 
                //then thats ou new result
                if (itsIncreasingOrder)
                {
                    if (tempResultList.Count > ResultList.Count)
                    {
                        ResultList = tempResultList;
                    }
                }
            }
            //Print result
            Console.WriteLine("The result should be : ");
            for (int i = 0; i < ResultList.Count; i++)
            {
                Console.Write("{0,0:000}, ",ResultList[i]);
            }
            Console.WriteLine();
        }
    }
}
