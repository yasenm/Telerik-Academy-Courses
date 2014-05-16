using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;

//Write a program that deletes from a text file all words that start with the
//prefix "test". Words contain only the symbols 0...9, a...z, A…Z, _.

namespace _11DeletePrefixWords
{
    class DeletePrefixWords
    {
        static void Main()
        {
            //this pattern will select all the words with the prefix test in them and we add it to a new RegEx
            string pattern = @"\w*test\w*";
            Regex regex = new Regex(pattern);
            //list that will hold the new lines for the text without the words with the test prefix because we cant
            //enter reading and writing mode at the same time in one file and after that we will write the new lines
            //into the same file
            List<string> text = new List<string>();
            using (StreamReader sr = new StreamReader("TextWithTestWords.txt"))
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    //the regex here since it has in it the pattern will autamticaly with the .Replace function replace/delete
                    //the test prefix words with empty stiring
                    text.Add(regex.Replace(line,string.Empty));
                    line = sr.ReadLine();
                }
            }
            //we write the new text format into the same file
            using (StreamWriter sw = new StreamWriter("TextWithTestWords.txt"))
            {
                for (int i = 0; i < text.Count; i++)
                {
                    sw.WriteLine(text[i]);
                }
            }
        }
    }
}
