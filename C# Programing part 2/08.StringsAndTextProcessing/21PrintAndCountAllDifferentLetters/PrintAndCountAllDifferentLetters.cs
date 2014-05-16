// Write a program that reads a string from the console and prints all 
// different letters in the string along with information how many times
// each letter is found.

namespace _21PrintAndCountAllDifferentLetters
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class PrintAndCountAllDifferentLetters
    {
        public static void Main()
        {
            Console.WriteLine("Enter your text here : ");
            string text = Console.ReadLine();
            List<string> lettersInSentence = new List<string>();
            List<int> timesLetterInSentence = new List<int>();
            for (int i = 0; i < text.Length; i++)
            {
                bool letterNotChecked = true;
                for (int j = 0; j < lettersInSentence.Count; j++)
                {
                    if (text[i].ToString() == lettersInSentence[j] || text[i] == ' ')
                    {
                        letterNotChecked = false;
                    }
                }
                if (letterNotChecked)
                {
                    lettersInSentence.Add(text[i].ToString().ToLower());
                    timesLetterInSentence.Add(Regex.Matches(text.ToLower(), text[i].ToString().ToLower()).Count);
                }
            }
            string result = string.Empty;
            for (int i = 0; i < lettersInSentence.Count; i++)
            {
                result += lettersInSentence[i] + " : " + timesLetterInSentence[i] + "; ";
            }
            Console.WriteLine(result);
        }
    }
}
