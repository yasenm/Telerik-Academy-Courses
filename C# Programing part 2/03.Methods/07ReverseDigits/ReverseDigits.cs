using System;

//Write a method that reverses the digits of given decimal number. Example: 256  652

namespace _07ReverseDigits
{
    class ReverseDigits
    {
        static decimal ReverseNumberDigits(decimal number)
        {
            string stringNumber = "" + number;
            string stringReversedNumber = "";
            for (int i = stringNumber.Length - 1; i >= 0; i--)
            {
                stringReversedNumber += stringNumber[i];
            }
            decimal result = decimal.Parse(stringReversedNumber);
            return result;
        }
        static void Main()
        {
            Console.Write("Enter a decimal number : ");
            decimal number = decimal.Parse(Console.ReadLine());
            decimal reversedNumber = ReverseNumberDigits(number);
            Console.WriteLine("Reversed the number is : {0}",reversedNumber);
        }
    }
}
