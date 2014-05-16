// Write a program that reads a string from the console and lists all
// different words in the string along with information how many
// times each word is found.

namespace _22ListAllDiferentWordsFromText
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class ListAllDiferentWordsFromText
    {
        public static void Main()
        {
            Console.WriteLine("Enter your text here : ");
            string text = Console.ReadLine();

            string pattern = @"[^a-zA-Z0-9]";
            text = Regex.Replace(text, pattern, " ", RegexOptions.IgnoreCase);
            string[] words = text.Split(new char[]{' '});
            List<string> wordsAndCounts = new List<string>();
            for (int i = 0; i < words.Length; i++)
            {
                if (Regex.Matches(text, words[i]).Count > 0)
                {
                    wordsAndCounts.Add(Regex.Matches(text, words[i]).Count + " times - " + words[i] + ";");
                    text = Regex.Replace(text, words[i], string.Empty, RegexOptions.IgnoreCase);
                }
            }

            wordsAndCounts.Sort();
            foreach (var word in wordsAndCounts)
            {
                Console.WriteLine(word);
            }
        }
    }
}
