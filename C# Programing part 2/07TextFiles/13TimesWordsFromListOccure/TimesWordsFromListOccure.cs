using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Collections;

//Write a program that reads a list of words from a file words.txt and finds
//how many times each of the words is contained in another file test.txt. 
//The result should be written in the file result.txt and the words should
//be sorted by the number of their occurrences in descending order. Handle
//all possible exceptions in your methods.

namespace _13TimesWordsFromListOccure
{
    class TimesWordsFromListOccure
    {
        //method that will print any text file by entering its location in the method param as a string
        static void PrintTxtFile(string file) 
        {
            using (StreamReader sr = new StreamReader(file))
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
            }
            Console.WriteLine();
        }

        //method that lets the user chose wich words should there be in the list and their count
        static void EnterListInWordsTxt() 
        {
            using (StreamWriter sw = new StreamWriter("words.txt"))
            {
                Console.Write("Enter number of words : ");
                int numberOfItems = int.Parse(Console.ReadLine());
                for (int i = 1; i <= numberOfItems; i++)
                {
                    Console.Write("Word No:{0} : ",i);
                    sw.WriteLine(Console.ReadLine());
                }
            }
        }

        //method that words.txt as a List<string> for us to work with
        static List<string> MakeListFromWordsTxt() 
        {
            List<string> listOfWords = new List<string>();
            using (StreamReader sr = new StreamReader("words.txt"))
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

        //method that will count every word and after that sort the list and put in result.txt file
        static void EnterTestTxtAndCountEachWordIntoResultTxt(IEnumerable listOfWords) 
        {
            List<string> resultList = new List<string>();
            using(StreamReader sr = new StreamReader("test.txt"))
	        {
                string text = sr.ReadToEnd();
                foreach (var listItem in listOfWords)
                {
                    //make regex with each word from list
                    Regex regex = new Regex(@"\b(" + listItem + ")\\b");
                    //get all matches into collection
                    MatchCollection arrayWithAllOccurances = regex.Matches(text);
                    //take count of collection concatinate it with the list item and add it to a list the string should be
                    //this format "{number of times word occures in test} {word}"
                    resultList.Add(arrayWithAllOccurances.Count + " \"" + listItem + "\";");
                }
	        }
            //this list.Sort() function will sort our list by number of times word occures since we have that format of string
            //in each resultList member
            resultList.Sort();
            //now we only need to write the result into a new result.txt file
            using (StreamWriter sw = new StreamWriter("result.txt"))
            {
                foreach (var listItem in resultList)
                {
                    sw.WriteLine(listItem);
                }
            }
            Console.WriteLine();
        }

        static void Main()
        {
            //print the text we are looking for words in
            PrintTxtFile("test.txt");
            //enter the words we would wish to search for
            EnterListInWordsTxt();
            List<string> listOfWords = MakeListFromWordsTxt();
            //finds all occurances and writes em down in the result.txt file
            EnterTestTxtAndCountEachWordIntoResultTxt(listOfWords);
            //print result
            PrintTxtFile("result.txt");
        }
    }
}
