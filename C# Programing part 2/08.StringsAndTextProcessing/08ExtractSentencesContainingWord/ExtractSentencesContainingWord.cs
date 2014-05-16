// Write a program that extracts from a given text all sentences containing given word.
// Example: The word is "in". The text is:

// We are living in a yellow submarine. We don't have anything else. Inside the submarine
// is very tight. So we are drinking all the day. We will move out of it in 5 days.

// The expected result is:

// We are living in a yellow submarine.
// We will move out of it in 5 days.

// Consider that the sentences are separated by "." and the words – by non-letter symbols.

namespace _08ExtractSentencesContainingWord
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class ExtractSentencesContainingWord
    {
        public static void Main()
        {
            string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            Console.WriteLine(text);
            Console.Write("Chose a word and find the sentences containg it : ");
            string word = " " + Console.ReadLine() + " ";

            // first we split the text by sentences by using '.' as a spliter
            string[] textSentences = text.Split('.');

            // to hold the sentences with the chosen word we will need a list to add them as soon as we find one
            List<string> resultList = new List<string>();

            for (int i = 0; i < textSentences.Length; i++)
            {
                // we trim the useless blank spaces in begining and edn of sentences
                string sentence = textSentences[i].Trim();

                // if we find the word using the regex funcion using .IsMatch returning true we add the sentence else we skip it
                if (Regex.IsMatch(sentence, word))
                {
                    resultList.Add(sentence);
                }
            }

            // print the result sentences
            Console.WriteLine("The senteces number is {0} and they are : ", resultList.Count);
            foreach (var sentence in resultList)
            {
                Console.WriteLine(sentence);
            }
        }
    }
}
