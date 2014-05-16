// Write a program that reads a string from the console and replaces all 
// series of consecutive identical letters with a single one. Example:
// "aaaaabbbbbcdddeeeedssaa" ----> "abcdedsa".

namespace _23ReplaceConsecutiveLetterWithSingle
{
    using System;
    using System.Text.RegularExpressions;

    public class ReplaceConsecutiveLetterWithSingle
    {
        public static void Main()
        {
            Console.WriteLine("Enter your text here : ");
            string text = Console.ReadLine();
            string pattern = @"([a-zA-Z0-9])\1{1,}";
            MatchCollection consecutiveLetters = Regex.Matches(text, pattern);
            for (int i = 0; i < consecutiveLetters.Count; i++)
            {
                text = Regex.Replace(text, consecutiveLetters[i].ToString(), consecutiveLetters[i].ToString().Substring(0, 1));
            }
            Console.WriteLine(text);
        }
    }
}
