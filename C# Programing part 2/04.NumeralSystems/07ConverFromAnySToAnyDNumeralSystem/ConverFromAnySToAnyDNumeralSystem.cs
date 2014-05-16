using System;

//Write a program to convert from any numeral system of given base s to 
//any other numeral system of base d (2 ≤ s, d ≤  16).

namespace _07ConverFromAnySToAnyDNumeralSystem
{
    class ConverFromAnySToAnyDNumeralSystem
    {
        //validation method for entering values S and D
        static int EnterSOrDValueValidation() 
        {
            int resultSOrD = int.Parse(Console.ReadLine());
            if (resultSOrD < 2 || resultSOrD > 16)
            {
                Console.Write("Invalid input try again : ");
                resultSOrD = EnterSOrDValueValidation();
            }
            return resultSOrD;
        }

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
        static string ConvertNumber(string aNumber,int aNumSystemCoef, int numSystemCoef)
        {
            //first we convert to decimal every type of number in any type of numeral system
            object[] hexadecSymbols = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, "A", "B", "C", "D", "E", "F", };
            int decimalNumber = 0;
            string result;
            aNumber = ReverseString(aNumber);

            for (int i = aNumber.Length - 1; i >= 0; i--)
            {
                int multiplicator = 0;
                for (int j = 0; j < aNumSystemCoef; j++)
                {
                    if (aNumber.Substring(i, 1).ToLower() == "" + hexadecSymbols[j])
                    {
                        multiplicator = j;
                    }
                }
                decimalNumber += (multiplicator * (int)Math.Pow(aNumSystemCoef, i));
            }
            //after we got the decimal number we convert it to the next wanted numeral system
            result = ConvertToAnyFromDecimal(decimalNumber, numSystemCoef);
            return result;
        }

        //method that converts from decimal to hexadecimal
        static string ConvertToAnyFromDecimal(int decimalNumber, int numSystemCoef)
        {
            object[] hexadecSymbols = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, "A", "B", "C", "D", "E", "F", };
            string anyNumSys = "";
            int remainder;
            while (decimalNumber > 0)
            {
                remainder = decimalNumber % numSystemCoef;
                decimalNumber /= numSystemCoef;
                anyNumSys += hexadecSymbols[remainder];
            }
            anyNumSys = ReverseString(anyNumSys);
            return anyNumSys;
        }

        static void Main()
        {
            Console.WriteLine("Program to convert from any numeral system of given base s to any other numeral" +
                " system of base d (2 ≤ s, d ≤  16)");
            Console.WriteLine();
            Console.Write("Enter value for s : ");
            int S = EnterSOrDValueValidation();
            Console.WriteLine();
            Console.Write("Enter value for d : ");
            int D = EnterSOrDValueValidation();

            //input values for diferent numberal systems
            Console.Write("Enter number in S : {0} numberal system : ",S);
            string sNumber = Console.ReadLine();
            //Console.Write("Enter number in D : {0} numberal system : ", D);
            //string dNumber = Console.ReadLine();

            //find result
            string result;
            result = ConvertNumber(sNumber,S, D);
            Console.WriteLine("Number in D : {0} system is = {1};",D,result);
        }
    }
}
