using System;
using System.Collections.Generic;

//Write a program to convert binary numbers to their decimal representation.

namespace _02ConvertBinaryToDecimal
{
    class ConvertBinaryToDecimal
    {
        //reverse string method
        static string ReverseString(string inputString)
        {
            string result = "";
            for (int i = inputString.Length - 1; i >= 0; i--)
            {
                result += inputString.Substring(i,1);
            }
            return result;
        }

        static void Main()
        {
            //input part for binary number
            Console.Write("Enter binary number representation : ");
            string binaryNumber = Console.ReadLine();
            binaryNumber = ReverseString(binaryNumber);

            int decimalNumber = 0;
            int someInt = 0;
            //variable that will check if 
            bool invalidInput = false;
            for (int i = binaryNumber.Length - 1; i >= 0; i--)
            {
                //check if the bit input is a number if it isn't than the input is invalid
                if (!int.TryParse(binaryNumber.Substring(i, 1), out someInt))
                {
                    invalidInput = true;
                    break;
                }
                //store the bit value and check respectivly if 1 or 0 and make the math
                int bit = int.Parse(binaryNumber.Substring(i,1));
                if (bit == 1)
                {
                    decimalNumber = decimalNumber + (bit * (int)Math.Pow(2, i));
                }
                else if (bit == 0)
                {
                    decimalNumber = decimalNumber + (bit * (int)Math.Pow(2, i) );
                }
                //if the bit is diferent than 1 or 0 the input is invalid
                else
                {
                    invalidInput = true;
                    break;
                }
            }
            if (invalidInput)
            {
                Console.WriteLine("Invalid input try again!");
            }
            else
            {
                Console.WriteLine("The decimal number is : {0}",decimalNumber);
            }
        }
    }
}
