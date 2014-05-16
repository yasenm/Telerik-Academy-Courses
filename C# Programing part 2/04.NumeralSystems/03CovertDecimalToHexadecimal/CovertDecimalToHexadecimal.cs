using System;

//Write a program to convert decimal numbers to their hexadecimal representation.

namespace _03CovertDecimalToHexadecimal
{
    class CovertDecimalToHexadecimal
    {
        //reverse string method
        static string ReverseString(string inputString)
        {
            string result = "";
            for (int i = inputString.Length - 1; i >= 0; i--)
            {
                result += inputString.Substring(i, 1);
            }
            return result;
        }

        //method that converts from decimal to hexadecimal
        static string ConvertToHexadecFromDecimal(int decimalNumber)
        {
            object[] hexadecSymbols = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, "A", "B", "C", "D", "E", "F", };
            string hexadecimalResult = "";
            int remainder;
            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 16;
                decimalNumber /= 16;
                hexadecimalResult += hexadecSymbols[remainder];
            }
            hexadecimalResult = ReverseString(hexadecimalResult);
            return hexadecimalResult;
        }

        static void Main()
        {
            //input section
            Console.Write("Enter decimal value : ");
            int decimalNumber = int.Parse(Console.ReadLine());
            
            string hexadecimalNumber;
            hexadecimalNumber = ConvertToHexadecFromDecimal(decimalNumber);
            Console.WriteLine("Hexadecimal the number is : {0};",hexadecimalNumber);
        }
    }
}
