using System;

//Write a program to convert binary numbers to hexadecimal numbers (directly).

namespace _06ConvertBinaryToHexadecimal
{
    class ConvertBinaryToHexadecimal
    {
        //method that turns binary into hexadecimal
        static string MakeBinaryToHexadecimal(string binaryNumber)
        {
            //result that we will return as hexadecimal number
            string hexResult = "";
            int counter = 0;
            //we make binary input balid to check
            //with the counter we will find how much we need to pad left so the code 
            //doesent trow exeption out of range
            while (counter < binaryNumber.Length)
            {
                counter += 4;
            }
            //padding left
            binaryNumber = binaryNumber.PadLeft(counter, '0');

            for (int i = 0; i < binaryNumber.Length; i+=4)
            {
                //we examin the cases of every 4 bits represented and add the corect hexa symbol
                switch (binaryNumber.Substring(i,4))
                {
                    case "0000": hexResult += "0"; break;
                    case "0001": hexResult += "1"; break;
                    case "0010": hexResult += "2"; break;
                    case "0011": hexResult += "3"; break;
                    case "0100": hexResult += "4"; break;
                    case "0101": hexResult += "5"; break;
                    case "0110": hexResult += "6"; break;
                    case "0111": hexResult += "7"; break;
                    case "1000": hexResult += "8"; break;
                    case "1001": hexResult += "9"; break;
                    case "1010": hexResult += "A"; break;
                    case "1011": hexResult += "B"; break;
                    case "1100": hexResult += "C"; break;
                    case "1101": hexResult += "D"; break;
                    case "1110": hexResult += "E"; break;
                    case "1111": hexResult += "F"; break;
                    default: Console.WriteLine("Invalid input");
                        break;
                }
            }

            return hexResult;
        }

        static void Main()
        {
            //input part
            Console.Write("Chose your bits wisely : ");
            string binaryNumber = Console.ReadLine();

            //result part
            string hexaNumber;
            hexaNumber = MakeBinaryToHexadecimal(binaryNumber);
            Console.WriteLine("Hexadecimal representation of {0} is : {1}",binaryNumber,hexaNumber);
        }
    }
}
