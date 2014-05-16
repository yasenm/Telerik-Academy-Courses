// Write a program that reads a number and prints it as a decimal number,
// hexadecimal number, percentage and in scientific notation. Format the
// output aligned right in 15 symbols.

namespace _11ReadAndPrintNumberInWays
{
    using System;

    public class ReadAndPrintNumberInWays
    {
        public static void Main()
        {
            Console.WriteLine("Enter a int : ");
            int number = int.Parse(Console.ReadLine());

            // Decimal
            Console.WriteLine("{0,15}|", number);

            // Hexadecimal
            Console.WriteLine("{0,15}|", Convert.ToString(number, 16));

            // Percentage
            Console.WriteLine("{0,15}|", (number * 100) + " %");

            // Scientific notation
            Console.WriteLine("{0,15}|", (decimal)(number / Math.Pow(10, number.ToString().Length)) + "x 10^" + number.ToString().Length);
        }
    }
}
