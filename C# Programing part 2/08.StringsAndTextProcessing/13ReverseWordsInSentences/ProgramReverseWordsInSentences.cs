// Write a program that reverses the words in given sentence.
// Example: 
// "C# is not C++, not PHP and not Delphi!" ---> "Delphi not and PHP, not C++ not is C#!".

namespace _13ReverseWordsInSentences
{
    using System;
    using System.Text.RegularExpressions;

    public class Program
    {
        // method that will do all the work ;) joking time
        public static void DoAllTheWorkMethod(string text) 
        {
            // pattern that we will split the words by and match the separators by
            string pattern = @"\s+|,\s*|\.\s*|!\s*|$";
            string[] words = Regex.Split(text, pattern);

            // string that will hold our result
            string newText = string.Empty;
            MatchCollection separators = Regex.Matches(text, pattern);
            for (int i = words.Length - 1, j = 0; i >= 0; i--, j++)
            {
                // we check if there is empty entry we skip it else we write in the new string text
                if (words[i] != string.Empty)
                {
                    newText += words[i] + separators[j];
                }
                else
                {
                    j--;
                }
            }

            Console.WriteLine(newText.Trim());
        }

        private static void Main()
        {
            string text = "C# is not C++, not PHP and not Delphi!";

            // That method name huh? :P
            DoAllTheWorkMethod(text);

            string testText = "Pesho si sedi v kyshti, na gosti idva mu Gosho.";
            DoAllTheWorkMethod(testText);
        }
    }
}
