// Write a program that reads from the console a string of maximum 20 characters. If the
// length of the string is less than 20, the rest of the characters should be filled with '*'.
// Print the result string into the console.

namespace _06StringOfMax20Chars
{
    using System;
    using System.Linq;

    public class StringOfMax20Chars
    {
        /// <summary>
        /// method that will return us if the string entered is more than 20 chars
        /// </summary>
        /// <returns></returns>
        private static string EntryValidationForExercise() 
        {
            Console.Write("Enter your text : ");
            string result = Console.ReadLine();
            if (result.Length > 19)
            {
                result = EntryValidationForExercise();
            }

            return result;
        }

        /// <summary>
        /// method that will either return the same string if it has 20 chars or return the string + "*" until it has 20 chars
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private static string ModifyTextEntered(string text) 
        {
            string result = string.Empty;
            if (text.Length < 19)
            {
                result = text;
                for (int i = text.Length - 1; i < 20; i++)
                {
                    result += "*";
                }

                return result;
            }
            else
            {
                return result;
            }
        }

        private static void Main()
        {
            Console.WriteLine("Enter text that is <= 20chars.");
            string enteredText = EntryValidationForExercise();
            string resultText = ModifyTextEntered(enteredText);
            Console.WriteLine(resultText);
        }
    }
}
