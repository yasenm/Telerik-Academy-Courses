using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Collections;

//Write a program that removes from a text file all words listed in given 
//another text file. Handle all possible exceptions in your methods.

namespace _12RemoveAllListedWordsFromFile
{
    class RemoveAllListedWordsFromFile
    {
        //method that will get all the words from a given text file list and return that list as a List<string>
        static List<string> GetListOfWordsToBeRemoved() 
        {
            List<string> listOfWords = new List<string>();
            //you can change path for streamreader if you want to read the list of words from other file
            using (StreamReader sr = new StreamReader("ListOfWords.txt"))
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    listOfWords.Add(line);
                    line = sr.ReadLine();
                }
            }
            return listOfWords;
        }

        //method that gets the list and returs it as a string pattern for RegEx's
        static string MakeListIntoARegExPattern(IEnumerable list) 
        {
            string resultPattern = @"\w*(";
            foreach (var listItem in list)
            {
                resultPattern += listItem + "|";
            }
            resultPattern = resultPattern.Substring(0,resultPattern.Length - 1) + ")\\w*";
            return resultPattern;
        }

        //method that will remove all the items from the given list from TextFile.txt (you can change path again
        //to make it so itll work with your files)
        static void RemoveItemsFromText(Regex regex) 
        {
            //first we make a list for each line
            List<string> listOfTextLines = new List<string>();
            using (StreamReader sr = new StreamReader("TextFile.txt"))
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    //add each line with the words deleted into the string list
                    listOfTextLines.Add(regex.Replace(line,string.Empty));
                    line = sr.ReadLine();
                }
            }
            //than we write the new lines into the same .txt file
            using (StreamWriter sw = new StreamWriter("TextFile.txt"))
            {
                for (int i = 0; i < listOfTextLines.Count; i++)
                {
                    sw.WriteLine(listOfTextLines[i]);
                }
            }
        }

        static void Main()
        {
            List<string> listOfWords = GetListOfWordsToBeRemoved();
            Regex regex = new Regex(MakeListIntoARegExPattern(listOfWords));
            RemoveItemsFromText(regex);
        }
    }
}
