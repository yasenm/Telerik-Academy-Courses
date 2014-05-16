// Write a program that reads a list of words, separated by spaces
// and prints the list in an alphabetical order.

namespace _24AlphabeticalListOfWords
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class AlphabeticalListOfWords
    {
        public static void Main()
        {
            string text = "Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.";
            Console.WriteLine(text);

            string pattern = @"[^a-zA-Z0-9]";
            text = Regex.Replace(text, pattern, " ", RegexOptions.IgnoreCase);

            Console.WriteLine("The text with only spaces between words : ");
            Console.WriteLine(text);

            string[] words = Regex.Split(text, " ");
            List<string> listOfWords = new List<string>();
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 1)
                {
                    listOfWords.Add(words[i]);
                }
            }

            listOfWords.Sort();
            Console.WriteLine("The list of words is : ");
            foreach (var word in listOfWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}
