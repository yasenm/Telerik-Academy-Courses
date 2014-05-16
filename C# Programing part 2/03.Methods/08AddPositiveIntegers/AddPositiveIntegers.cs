using System;
using System.Collections;

//Write a method that adds two positive integer numbers represented as arrays
//of digits (each array element arr[i] contains a digit; the last digit is kept
//in arr[0]). Each of the numbers that will be added could have up to 10 000 digits.

namespace _08AddPositiveIntegers
{
    class AddPositiveIntegers
    {
        //print array method
        static void PrintArray(IEnumerable array)
        {
            Console.WriteLine("Your array is : ");
            foreach (var item in array)
            {
                Console.Write("{0,2},", item);
            }
            Console.WriteLine();
        }

        //make int[] arrays out of strings
        static int[] MakeFromStringArrayOfInts(string integerStr, int[] array) 
        {
            int number;
            for (int i = array.Length - 1, j = 0; i >= 0; i--, j++)
            {
                if (int.TryParse(integerStr.Substring(j,1), out number))
                {
                    array[i] = int.Parse(integerStr.Substring(j, 1));
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    break;
                }
            }
            return array;
        }

        //Reverse string method
        static string ReverseStrings(string number)
        {
            string stringNumber = "" + number;
            string result = "";
            for (int i = stringNumber.Length - 1; i >= 0; i--)
            {
                result += stringNumber[i];
            }
            return result;
        }

        static string AddTwoIntegerArrays(int[] firstarray, int[] secondarray)
        {
            string result = "";
            //we have adder that will contain 0 or 1 depending on what the sum of two digits is
            int adder = 0;
            //if the first array is longer than second start adding
            if (firstarray.Length >= secondarray.Length)
            {
                //start adding 
                for (int i = 0, secondIndex = 0; i < firstarray.Length; i++,secondIndex++)
                {
                    //taking the two ints at current position
                    int firsInt = (int)firstarray[i];
                    int secondInt;
                    //if we reached the limit of the smaller array add from now on 0 until end of loop
                    if (secondIndex >= secondarray.Length)
                    {
                        secondInt = 0;
                    }
                    else
	                {
                        secondInt = (int)secondarray[secondIndex];
	                }
                    int inputInt = firsInt + secondInt + adder;
                    result += (inputInt % 10);
                    //get new value for adder for the next step
                    adder = inputInt / 10;
                }
                if (adder != 0)
                {
                    result += adder;
                }
            }
            //else change places and start same method
            else
            {
                result = AddTwoIntegerArrays(secondarray,firstarray);
            }
            //now reverse the string since it backwards
            result = ReverseStrings(result);
            //
            return result;
        }

        static void Main()
        {
            //input strings for big numbers
            Console.Write("Enter first integer : ");
            string firstInt = Console.ReadLine();
            int[] firstIntArray = new int[firstInt.Length];
            Console.Write("Enter second integer : ");
            string secondInt = Console.ReadLine();
            int[] secondIntArray = new int[secondInt.Length];

            //make string to array of ints
            firstIntArray = MakeFromStringArrayOfInts(firstInt, firstIntArray);
            secondIntArray = MakeFromStringArrayOfInts(secondInt, secondIntArray);

            //print the two new reversed arrays from the strings
            Console.WriteLine("First array reversed digits : ");
            PrintArray(firstIntArray);
            Console.WriteLine("Second array reversed digits : ");
            PrintArray(secondIntArray);

            //add the two chosen numbers
            string addedArraysString = AddTwoIntegerArrays(firstIntArray, secondIntArray);
            int[] addedResultArray = new int[addedArraysString.Length];
            addedResultArray = MakeFromStringArrayOfInts(addedArraysString, addedResultArray);

            //print the result of adding both numbers
            Console.WriteLine("Result string number is : ");
            Console.WriteLine(addedArraysString);
            Console.WriteLine("Result array is : ");
            PrintArray(addedResultArray);
            Console.WriteLine();
        }
    }
}
