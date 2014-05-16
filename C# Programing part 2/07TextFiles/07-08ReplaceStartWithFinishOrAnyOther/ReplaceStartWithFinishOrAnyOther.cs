using System;
using System.IO;
using System.Text.RegularExpressions;

//Exercise 7
//Write a program that replaces all occurrences of the substring "start" with
//the substring "finish" in a text file. Ensure it will work with large
//files (e.g. 100 MB).

//Exercise 8
//Modify the solution of the previous problem to replace only whole words (not substrings).

namespace _07_08ReplaceStartWithFinishOrAnyOther
{
    class ReplaceStartWithFinishOrAnyOther
    {
        static void Main()
        {
            string pattern = @"(start)";
            string replacer = "finish";
            string textToChange;
            //we extract the text from a file into a string you can change the text file with your own text or paste in /bin/debug/...
            //your text and change the StreamReader path to file
            using (StreamReader sr = new StreamReader("SomeText.txt"))
            {
                textToChange = sr.ReadToEnd();
            }
            //replace the word start with the word finish in the string text 
            //Cause of exercise 8 needed solution , the replacement is made with regex which can change with what ever you change
            //the pattern string and replacer string in any given text
            textToChange = Regex.Replace(textToChange, pattern, replacer, RegexOptions.IgnoreCase);
            //make new text file with the new changed text
            using (StreamWriter sw = new StreamWriter("ChangedStartWithFinish.txt"))
            {
                sw.Write(textToChange);
                sw.Flush();
            }
            //print the changed file on the console
            using (StreamReader sr = new StreamReader("ChangedStartWithFinish.txt"))
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
            }
        }
    }
}
