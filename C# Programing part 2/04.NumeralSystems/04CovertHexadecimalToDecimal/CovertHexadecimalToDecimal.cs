using System;

//Write a program to convert hexadecimal numbers to their decimal representation.

namespace _04CovertHexadecimalToDecimal
{
    class CovertHexadecimalToDecimal
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

        //method to convert the values
        static int ConvertHexadecimalToDecimal(string hexadecimalNumber)
        {
            int result = 0;
            hexadecimalNumber = ReverseString(hexadecimalNumber);

            for (int i = hexadecimalNumber.Length - 1; i >= 0; i--)
            {
                int index;
                switch (hexadecimalNumber.Substring(i,1).ToLower())
	                {
                    case "0": index = 0; break;
                    case "1": index = 1; break;
                    case "2": index = 2; break;
                    case "3": index = 3; break;
                    case "4": index = 4; break;
                    case "5": index = 5; break;
                    case "6": index = 6; break;
                    case "7": index = 7; break;
                    case "8": index = 8; break;
                    case "9": index = 9; break;
                    case "a": index = 10; break;
                    case "b": index = 11; break;
                    case "c": index = 12; break;
                    case "d": index = 13; break;
                    case "e": index = 14; break;
                    case "f": index = 15; break;
		            default: index = -1; break;
	                }
                if (index == - 1)
	            {
		            Console.WriteLine("Invalid input try again!");
                    break;
	            }
                else
	            {
                    result += (index * (int)Math.Pow(16,i));
	            }
            }
            return result;
        }

        static void Main()
        {
            //input section
            Console.Write("Enter a hexadecimal number : ");
            string hexadecimalNumber = Console.ReadLine();

            int decimalNumber;
            //convert part
            decimalNumber = ConvertHexadecimalToDecimal(hexadecimalNumber);

            Console.WriteLine("The decimal number is : {0};",decimalNumber);
        }
    }
}
