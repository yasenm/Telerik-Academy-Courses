using System;

//* Write a program that sorts an array of integers using the merge sort algorithm (find it in Wikipedia).

namespace _13SortWithMergeSortAlgo
{
    class SortWithMergeSortAlgo
    {
        static void Main()
        {
            //Console.Write("Enter length of array : ");
            //int N = int.Parse(Console.ReadLine());
            //int[] unsortedArray = new int[N];
            //Random randomNumber = new Random();

            ////---- input values in unsorted array 
            //for (int i = 0; i < unsortedArray.Length; i++)
            //{
            //    unsortedArray[i] = randomNumber.Next(0, 100);
            //}

            //---- initialize main components of algorithm
            int[] unsortedArray = { 9, 2, 6, 5, 3, 10, 1, 7 };
            int len = unsortedArray.Length;
            int decomposeSteps = 0;
            int sortSteps = 0;
            int stepsLenVar = unsortedArray.Length;
            int[] workingArray = new int[len];
            int tempHolder = 0;
            int[] tempArray = new int[len];
            int counter = 0;

            //---- Print unsorted array
            for (int i = 0; i < unsortedArray.Length; i++)
            {
                Console.Write("{0,0:000},", unsortedArray[i]);
            }
            Console.WriteLine();

            //---- merge sort algorithm
            //---- calculate our steps
            while (true)
            {
                stepsLenVar = stepsLenVar / 2;
                if (stepsLenVar == 0)
                {
                    break;
                }
                else
                {
                    decomposeSteps++;
                }
            }
            Console.WriteLine("steps : {0}", decomposeSteps);

            //---- start merging step by step
            int endIndex = 1;
            while (sortSteps < decomposeSteps)
            {
                for (int i = 0; i < len / endIndex; i+=2)
                {
                    for (int left = i, right = i + endIndex; left < i + endIndex; left++, right++)
                    {
                        if (unsortedArray[left] < unsortedArray[right])
                        {
                            workingArray[counter] = unsortedArray[left];
                            if (endIndex > 1)
                            {
                                if ( counter + 1 == right )
                                {
                                    counter++;
                                    workingArray[counter] = unsortedArray[left];
                                    break;
                                }
                                right--;
                            }
                            else
                            {
                                counter++;
                                workingArray[counter] = unsortedArray[right];
                            }
                        }
                        else
                        {
                            workingArray[counter] = unsortedArray[right];
                            if (endIndex > 1)
                            {
                                if (counter - i == left )
                                {
                                    counter++;
                                    workingArray[counter] = unsortedArray[right];
                                    break;
                                }
                                left--;
                            }
                            else
                            {
                                counter++;
                                workingArray[counter] = unsortedArray[left];
                                unsortedArray[right] = workingArray[right];
                                unsortedArray[left] = workingArray[left];
                            }
                        }
                        counter++;
                    }
                }
                counter = 0;
                tempArray = workingArray;
                workingArray = new int[len];
                unsortedArray = tempArray; 
                sortSteps++;
                endIndex *= 2;
            }


            for (int i = 0; i < unsortedArray.Length; i++)
            {
                Console.Write("{0,0:000},", unsortedArray[i]);
            }
            Console.WriteLine();
        }
    }
}
