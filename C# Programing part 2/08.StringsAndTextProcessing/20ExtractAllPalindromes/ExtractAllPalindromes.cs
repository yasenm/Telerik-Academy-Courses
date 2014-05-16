// Write a program that extracts from a given text all palindromes,
// e.g. "ABBA", "lamal", "exe".

namespace _20ExtractAllPalindromes
{
    using System;
    using System.Collections.Generic;

    public class ExtractAllPalindromes
    {
        // method that reverses a sting
        public static string ReverseString(string inputStr)
        {
            string result = string.Empty;

            // we start from the last letter by accessing it with substring with length 1 and so on with the loop
            // from right to left we add each letter to the result string and then return it
            for (int i = inputStr.Length - 1; i >= 0; i--)
            {
                result += inputStr.Substring(i, 1);
            }

            return result;
        }

        public static void Main()
        {
            string text = "Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.";
            Console.WriteLine(text);

            // we make a char array that consinst of all (at least the one i though of maybe there are more) chars that palindrome must not
            // consist in their selfs and after that split all words by them in array
            char[] notPartsOfWordsSpliters = new char[] { '.', ' ', ';', ',', ':', '\'', '"', '[', ']', '-', '<', '>', '?', '}', '{', '_', '=', '+', '!', '@', '#', '$', '^', '&', '*', '(', ')', '~', '`' };
            string[] words = text.Split(notPartsOfWordsSpliters, StringSplitOptions.RemoveEmptyEntries);

            // make list that will hold the resulted palindomes
            List<string> palindromes = new List<string>();

            // with the loop we check every word from the splited array and if the word is palindome we added to the result
            for (int i = 0; i < words.Length; i++)
            {
                // if the word is equal to itself in reverse and the word is with more then one char then its a palindrome so add it for result
                // i've took the method from exercise 2 for reversing string, make it case insensitive by making all toLower characters
                if (words[i].ToLower() == ReverseString(words[i].ToLower()) && words[i].Length > 1)
                {
                    palindromes.Add(words[i]);
                }
            }

            Console.WriteLine("The palindomes are : ");
            foreach (var palindome in palindromes)
            {
                Console.WriteLine(palindome);
            }
        }
    }
}
