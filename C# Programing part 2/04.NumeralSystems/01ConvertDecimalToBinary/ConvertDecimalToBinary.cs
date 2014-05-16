using System;
using System.Collections.Generic;
using System.Collections;

//Write a program to convert decimal numbers to their binary representation.

namespace _01ConvertDecimalToBinary
{
    class ConvertDecimalToBinary
    {
        //printing array and lists
        static void PrintCollection(IEnumerable array)
        {
            foreach (var item in array)
            {
                Console.Write("{0}", item);
            }
            Console.WriteLine();
        }

        static void Main()
        {
            //input the wanted number
            Console.Write("Enter decimal : ");
            int decimalNumber = int.Parse(Console.ReadLine());

            //set a remainder that will hold either the 1 or 0 component
            int remainder;

            // make a list that will keep the found bits
            List<int> binaryNumber = new List<int>();

            //a loop that adds the bits and then checks again with the new value for the number
            //devided by 2
            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 2;
                decimalNumber /= 2;
                binaryNumber.Add(remainder);
            }

            //reversing the list to get the apropriete bit epresentation
            binaryNumber.Reverse();
            
            //print the binary representation
            Console.Write("Binary the number is : ");
            PrintCollection(binaryNumber);
        }
    }
}
