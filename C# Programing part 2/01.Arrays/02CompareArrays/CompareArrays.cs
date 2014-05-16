using System;

//Write a program that reads two arrays from the console and compares them element by element.

namespace _02CompareArrays
{
    class CompareArrays
    {
        static void Main()
        {
            Console.Write("Enter length of arrays : ");
            int N = int.Parse(Console.ReadLine());
            int[] arr1 = new int[N];
            int[] arr2 = new int[N];
            bool sameArrays = true;

            //---- Start reading integers from console for the new arrays
            //---- For first array
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write("arr1[{0}] = ", i);
                arr1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            //---- For second array
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write("arr2[{0}] = ", i);
                arr2[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            //---- Start comparing arrays element by element
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    Console.WriteLine("arr1[{0}] == arr2[{0}]? ----> {1}", i, false);
                    sameArrays = false;
                }
                else
                {
                    Console.WriteLine("arr1[{0}] == arr2[{0}]? ----> {1}", i, true);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Are both arrays equal ? ---------> {0}", sameArrays);

        }
    }
}
