using System;
using System.Collections.Generic;
using System.Collections;

//Write a program that reads a string, reverses it and prints the result at the console.
//Example: "sample"  "elpmas".

namespace _02ReadReversePringAString
{
    class ReadReversePringAString
    {
        //method that reverses a sting
        static string ReverseString(string inputStr) 
        {
            string result = string.Empty;
            //we start from the last letter by accessing it with substring with length 1 and so on with the loop
            //from right to left we add each letter to the result string and then return it
            for (int i = inputStr.Length - 1; i >= 0; i--)
            {
                result += inputStr.Substring(i,1);
            }
            return result;
        }

        static void Main()
        {
            Console.Write("Enter a string to be reversed : ");
            string inputString = Console.ReadLine();
            Console.WriteLine(ReverseString(inputString));
        }
    }
}
