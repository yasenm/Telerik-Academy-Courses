using System;

//Write a program to convert hexadecimal numbers to binary numbers (directly).

namespace _05ConvertHexadecimalToBinary
{
    class ConvertHexadecimalToBinary
    {
        //method that transforms hexadecimal to binary string
        static string ConvertHexadecimalToBinaryNumber(string hexadecimalNumber)
        {
            string result = "";

            for (int i = 0; i < hexadecimalNumber.Length; i++)
            {
                string addon;
                //check the member found and make string equal to its binary representation
                switch (hexadecimalNumber.Substring(i,1).ToLower())
	                {
                        case "0": addon = Convert.ToString(0,2)  ; break;
                        case "1": addon = Convert.ToString(1,2)  ; break;
                        case "2": addon = Convert.ToString(2,2)  ; break;
                        case "3": addon = Convert.ToString(3,2)  ; break;
                        case "4": addon = Convert.ToString(4,2)  ; break;
                        case "5": addon = Convert.ToString(5,2)  ; break;
                        case "6": addon = Convert.ToString(6,2)  ; break;
                        case "7": addon = Convert.ToString(7,2)  ; break;
                        case "8": addon = Convert.ToString(8,2)  ; break;
                        case "9": addon = Convert.ToString(9,2)  ; break;
                        case "a": addon = Convert.ToString(10, 2); break;
                        case "b": addon = Convert.ToString(11, 2); break;
                        case "c": addon = Convert.ToString(12, 2); break;
                        case "d": addon = Convert.ToString(13, 2); break;
                        case "e": addon = Convert.ToString(14, 2); break;
                        case "f": addon = Convert.ToString(15, 2); break;
                        default: addon = "false"; break;
	                }
                //if we found unexpected char terminate program as invalid hexadecimal input
                if (addon == "false")
                {
                    Console.WriteLine("Invalid input try again!");
                    break;
                }
                //as we add to result string padleft with zeros for more correct representation
                result += addon.PadLeft(4,'0');
            }

            return result;
        }

        static void Main()
        {
            //input section
            Console.Write("Enter a hexadecimal number : ");
            string hexadecimalNumber = Console.ReadLine();

            string binaryNumber;
            //convert part
            binaryNumber = ConvertHexadecimalToBinaryNumber(hexadecimalNumber);

            Console.WriteLine("The binary representation of the number is : {0};", binaryNumber.TrimStart('0'));
        }
    }
}
