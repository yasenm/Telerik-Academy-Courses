namespace _01MultiverseCommunication
{
    using System;
    using System.Numerics;

    class MultiverseCommunication
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

        static string ConvertMultiStringToNumber(string digit)
        {
            string result = string.Empty;
            switch (digit)
            {
                case "CHU": result = "0"; break;
                case "TEL": result = "1"; break;
                case "OFT": result = "2"; break;
                case "IVA": result = "3"; break;
                case "EMY": result = "4"; break;
                case "VNB": result = "5"; break;
                case "POQ": result = "6"; break;
                case "ERI": result = "7"; break;
                case "CAD": result = "8"; break;
                case "K-A": result = "9"; break;
                case "IIA": result = "A"; break;
                case "YLO": result = "B"; break;
                case "PLA": result = "C"; break;
                default:
                    break;
            }

            return result;
        }

        static BigInteger PowerOfThirteen(int power)
        {
            BigInteger result = 1;

            for (int i = 0; i < power; i++)
            {
                result *= 13;
            }

            return result;
        }

        //method to convert the values
        static BigInteger ConvertThirteenToDecimal(string hexadecimalNumber)
        {
            BigInteger result = 0;
            hexadecimalNumber = ReverseString(hexadecimalNumber);

            for (int i = hexadecimalNumber.Length - 1; i >= 0; i--)
            {
                int index;
                switch (hexadecimalNumber.Substring(i, 1).ToLower())
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
                result += (index * PowerOfThirteen(i));
            }
            return result;
        }

        static void Main()
        {
            string input = Console.ReadLine();

            string thirteenSystemNumber = string.Empty;

            for (int i = 0; i < input.Length; i+=3)
            {
                string partialInput = input.Substring(i, 3);

                string currentDigit = ConvertMultiStringToNumber(partialInput);

                thirteenSystemNumber += currentDigit;
            }

            BigInteger result = ConvertThirteenToDecimal(thirteenSystemNumber);

            //for (int i = 0; i < thirteenSystemNumber.Length; i++)
            //{
            //    BigInteger digit = BigInteger.Parse(thirteenSystemNumber[i].ToString());

            //    result += digit * PowerOfThirteen(thirteenSystemNumber.Length - i - 1);
            //}

            Console.WriteLine(result);

        }
    }
}
