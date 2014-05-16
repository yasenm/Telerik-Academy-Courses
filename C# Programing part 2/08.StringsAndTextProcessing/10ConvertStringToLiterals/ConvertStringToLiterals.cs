// Write a program that converts a string to a sequence of C# Unicode
// character literals. Use format strings. Sample input:

// Hi!

// Expected output:

// \u0048\u0069\u0021

namespace _10ConvertStringToLiterals
{
    using System;
    using System.Linq;

    public class ConvertStringToLiterals
    {
        public static void Main()
        {
            Console.WriteLine("Enter a string to see its unicode character literals.");
            Console.Write("Chose wisely : ");
            var str = Console.ReadLine();
            string resultSTR = string.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                resultSTR += "\\u" + Convert.ToString(str[i], 16).PadLeft(4, '0');
            }

            //// second way to make it
            // for (int i = 0; i < str.Length; i++)
            // {
            //     resultSTR += string.Format("\\u{0:X4}", (int)str[i]);
            // }
            Console.WriteLine(resultSTR);
        }
    }
}
