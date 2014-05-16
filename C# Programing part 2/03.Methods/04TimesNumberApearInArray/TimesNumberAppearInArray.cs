using System;
using System.Collections;

//Write a method that counts how many times given number appears in given 
//array. Write a test program to check if the method is working correctly.

namespace _04TimesNumberApearInArray
{
    public class TimesNumberAppearInArray
    {
        //First two methods for generating the array and printing it
        static void PrintArray(IEnumerable array)
        {
            Console.WriteLine("Your array is : ");
            foreach (var item in array)
	        {
                Console.Write("{0,2},",item);
	        }
            Console.WriteLine();
        }

        static void FillArray(int[] array) 
        {
            Random randomNumber = new Random();
            for (int i = 0; i < array.Length; i++)
			{
                array[i] = randomNumber.Next(0, 10);
			}
        }

        //method to find the count of times we encounter chosen number in the array
        public static int AppearancesOfNumberInArray(int number, IEnumerable array)
        {
            int counter = 0;
            foreach (var item in array)
            {
                if ((int)item == number)
                {
                    counter++;
                }
            }
            return counter;
        }

        static void Main()
        {
            Console.Write("Chose length for Array : ");
            int arrayLen = int.Parse(Console.ReadLine());
            int[] array = new int[arrayLen];
            FillArray(array);
            PrintArray(array);
            Console.WriteLine("Chose a number to count how many times it appears in the array.");
            Console.Write("Enter number = ");
            int number = int.Parse(Console.ReadLine());
            int result = AppearancesOfNumberInArray(number, array);
            Console.WriteLine("The times {0} appears in the array is : {1}", number, result);
        }
    }
}
