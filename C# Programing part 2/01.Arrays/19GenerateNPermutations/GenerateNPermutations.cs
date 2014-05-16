using System;
using System.Collections.Generic;

//* Write a program that reads a number N and generates and prints all
//the permutations of the numbers [1 … N].
//Example:
//n = 3  {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2}, {3, 2, 1}

//------------------ NE E DOVYRSHENA

namespace _19GenerateNPermutations
{
    class GenerateNPermutations
    {
        static void GeneratePermutation(int[] inputArray,List<int> workingList)
        {
            //Main if that checks if we are at the last component of the permutation and if so we need to print
            //the whole thing
            if (workingList.Count + 1 == inputArray.Length )
            {
                for (int i = 0; i < inputArray.Length; i++)
                {
                    for (int j = 0; j < workingList.Count; j++)
                    {
                        if (inputArray[i] != workingList[j])
                        {
                            workingList.Add(inputArray[i]);
                            //Printing loop
                            Console.WriteLine("Permutation : ");
                            for (int k = 0; k < workingList.Count; k++)
                            {
                                Console.Write("{0,0:000},", workingList[k]);
                            }
                            Console.WriteLine();
                            workingList.Remove(inputArray[i]);
                            return;
                        }
                    }
                }
            }
            else
	        {
                for (int i = 0; i < inputArray.Length; i++)
			    {
			        for (int j = 0; j < workingList.Count; j++)
			        {
			            if (inputArray[i] != workingList[j])
	                    {
		                    workingList.Add(inputArray[i]);
                            GeneratePermutation(inputArray, workingList);
                            workingList.Remove(inputArray[i]);
	                    }
			        }
			    }
            }
        }

        static int[] Permutate(int[] inputArray)
        {
            if (inputArray.Length <= 1)
            {
                return inputArray;
            }
            else
            {
                for (int i = 0; i < inputArray.Length; i++)
                {
                    List<int> StartWorkingList = new List<int>();
                    StartWorkingList.Add(inputArray[i]);
                    GeneratePermutation(inputArray, StartWorkingList);
                }
            }
            return inputArray;
        }
        static void Main()
        {
            Console.Write("Enter 'N' = ");
            int N = int.Parse(Console.ReadLine());

            int[] startingArray = new int[N];
            for (int i = 0, j = 1; i < N; i++,j++)
            {
                startingArray[i] = j;
            }

            Console.WriteLine("Array to permutate : ");
            for (int i = 0; i < startingArray.Length; i++)
            {
                Console.Write("{0,0:000}, ", startingArray[i]);
            }
            Console.WriteLine();
            Console.WriteLine("-----------------");

            Permutate(startingArray);
            Console.WriteLine();
        }
    }
}
