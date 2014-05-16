using System;

//Write a program that allocates array of 20 integers and initializes 
//each element by its index multiplied by 5. Print the obtained array
//on the console.

namespace _01AllocateArrayOfIntegers
{
    class AllocateArrayOfIntegers
    {
        static void Main()
        {
            int N = 20;
            int[] arr = new int[N];
            //---- Seting the array of 20 ints
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
            }
            Console.WriteLine("Current array : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0,0:000},", arr[i]);
            }
            //---- Initializing each element and multiplying by 5
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i] * 5;
            }
            Console.WriteLine("New array : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0,0:000},", arr[i]);
            }
        }
    }
}
