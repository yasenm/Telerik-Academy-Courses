namespace _02MagicWords
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class MagicWords
    {
        private static List<string> permutedResults = new List<string>();
        private static string lastPermut = string.Empty;
        private static int count = 0;

        static void Main()
        {
            string input = Console.ReadLine();
            Permutation(input);
            Console.WriteLine(count);
        }
        /// <summary>
        /// Wrapper function
        /// </summary>
        /// <param name="input"></param>
        public static void Permutation(string input)
        {
            RecPermutation("", input);
        }

        private static void RecPermutation(string soFar, string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                if (IsMatch(soFar) && lastPermut != soFar)
                {
                    lastPermut = soFar;
                    count++;
                }
                return;
            }
            else
            {
                for (int i = 0; i < input.Length; i++)
                {
                    string remaining = input.Substring(0, i) + input.Substring(i + 1);
                    RecPermutation(soFar + input[i], remaining);
                }
            }
        }

        private static bool IsMatch(string word) 
        {
            for (int i = 1; i < word.Length; i++)
            {
                if (word[i] == word[i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
