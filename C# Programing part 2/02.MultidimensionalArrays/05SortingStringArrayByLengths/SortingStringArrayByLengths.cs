using System;

//You are given an array of strings. Write a method that sorts the 
//array by the length of its elements (the number of characters composing them).

namespace _05SortingStringArrayByLengths
{
    class SortingStringArrayByLengths
    {
        static void Main()
        {
            //For user input of array
            //Console.Write("Choose length of array 'N' : ");
            //int N = int.Parse(Console.ReadLine());

            //string[] stringArray = new string[N];
            //for (int i = 0; i < stringArray.Length; i++)
            //{
            //    stringArray[i] = Console.ReadLine();
            //}

            //seting some array to work with and solve
            string[] stringArray = { "Pesho","Mariq","Mara","Cvetelina","Pantalei","Graf Monte Kristo","Piqnica","Trezvenik" };

            //print the starting string array
            Console.WriteLine("Starting with the array :");
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.Write("|{0}|",stringArray[i]);
            }
            Console.WriteLine();

            //sorting part of exercise
            //initialization of solving part
            string[] sortedArray = new string[stringArray.Length];
            int lowerIndexer = 0;
            string tempHolder = "";
            //start of sorting sequence
            //first we enter the first member of the unsorted array
            for (int i = 0; i < stringArray.Length; i++)
            {
                //we give the lowerIndexer 'i' as a value
                lowerIndexer = i;
                for (int nextIndex = 1 + i; nextIndex < sortedArray.Length; nextIndex++)
                {
                    //if the previous member is with bigger length than the next one we 
                    //switch their indexes and after that their positions with temp holders
                    if (stringArray[lowerIndexer].Length > stringArray[nextIndex].Length)
                    {
                        lowerIndexer = nextIndex;
                    }
                }
                //the tempHolder holds the string with lower length
                tempHolder = stringArray[lowerIndexer];
                stringArray[lowerIndexer] = stringArray[i];
                sortedArray[i] = tempHolder;
            }
            //printing sortedArray
            Console.WriteLine("Sorted by string lenghts array looks like : ");
            for (int i = 0; i < sortedArray.Length; i++)
            {
                Console.WriteLine("String array[{0}] : {1};",i, sortedArray[i]);
            }
            Console.WriteLine();
        }
    }
}
