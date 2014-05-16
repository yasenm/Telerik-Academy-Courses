using System;

//Write a program that compares two char arrays lexicographically (letter by letter).

namespace _03ComapareCharArrays
{
    class ComapareCharArrays
    {
        static void Main()
        {
            Console.Write("Enter length of arrays : ");
            int N = int.Parse(Console.ReadLine());

            char[] arr1 = new char[N];
            char[] arr2 = new char[N];
            bool equalArrays = true;

            Console.WriteLine();
            //---- Start reading chars from console for the new arrays
            //---- For first array
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write("Enter char for arr1[{0}] : ",i);
                arr1[i] = char.Parse(Console.ReadLine());
            }
            //---- For second array
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write("Enter char for arr2[{0}] : ", i);
                arr1[i] = char.Parse(Console.ReadLine());
            }

            //---- Compare chars lexicographically
            for (int i = 0; i < arr1.Length; i++)
            {
                if ( arr1[i] != arr2[i] ){
                    equalArrays = false;
					break;
				}
            }

            Console.WriteLine(equalArrays? "Arrays are equal!" : "Arrays are not equal!" );
        }
    }
}
