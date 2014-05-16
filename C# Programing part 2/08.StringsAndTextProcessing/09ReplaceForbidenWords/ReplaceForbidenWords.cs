// We are given a string containing a list of forbidden words and a text 
// containing some of these words. Write a program that replaces the 
// forbidden words with asterisks. Example:

// Microsoft announced its next generation PHP compiler today. It is based 
// on .NET Framework 4.0 and is implemented as a dynamic language in CLR.

// Words: "PHP, CLR, Microsoft"

// The expected result:

// ********* announced its next generation *** compiler today. It is based 
// on .NET Framework 4.0 and is implemented as a dynamic language in ***.

namespace _09ReplaceForbidenWords
{
    using System;

    public class ReplaceForbidenWords
    {
        public static void Main()
        {
            // i'm to tired to explain :S its very simple
            string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            Console.WriteLine(text);

            string[] words = new string[]{"PHP", "CLR", "Microsoft"};
            string resultText = text;
            string tempText = string.Empty;

            for (int i = 0; i < words.Length; i++)
            {
                string replacer = string.Empty;
                for (int j = 0; j < words[i].Length; j++)
			    {
			        replacer += '*';
			    }

                tempText = resultText.Replace(words[i], replacer);
                resultText = tempText;
            }

            Console.WriteLine(resultText);
        }
    }
}
