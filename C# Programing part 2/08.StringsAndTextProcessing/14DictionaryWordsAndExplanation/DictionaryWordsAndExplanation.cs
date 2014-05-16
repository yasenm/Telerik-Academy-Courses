// A dictionary is stored as a sequence of text lines containing words and their explanations.
// Write a program that enters a word and translates it by using the dictionary.
// Sample dictionary:

// .NET – platform for applications from Microsoft
// CLR – managed execution environment for .NET
// namespace – hierarchical organization of classes

namespace _14DictionaryWordsAndExplanation
{
    using System;
    using System.Text.RegularExpressions;

    public class DictionaryWordsAndExplanation
    {
        // method that finds the explanation and prints it
        public static void FindExplanionFromDictionary(string word, string dictionary) 
        {
            string result = string.Empty;
            string[] dictionaryArray = Regex.Split(dictionary, "\n");
            for (int i = 0; i < dictionaryArray.Length; i++)
            {
                if (Regex.IsMatch(dictionaryArray[i], word + " - "))
                {
                    result += dictionaryArray[i];
                    break;
                }
            }
            Console.WriteLine(result);
        }

        public static void Main()
        {
            string dictionary = ".NET - platform for applications from Microsoft\nCLR - managed execution environment for .NET\nnamespace - hierarchical organization of classes";
            Console.Write("Chose a word to be searched : ");
            string searchWord = Console.ReadLine();
            FindExplanionFromDictionary(searchWord,dictionary);
        }
    }
}
