using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;

//Write a program that reads a text file containing a list of strings, 
//sorts them and saves them to another text file. Example:
//    Ivan			    George
//    Peter			    Ivan
//    Maria	  ----->	Maria
//    George			Peter


namespace _06SortList
{
    class SortList
    {
        //method that the user will add the list items into a file which after that we will sort into a new .txt file
        static void MakeListFileTxt() 
        {
            using (StreamWriter sw = new StreamWriter("UnsortedUserList.txt"))
            {
                Console.Write("Chose number of items in list : ");
                int numberOfItems = int.Parse(Console.ReadLine());
                for (int i = 1; i <= numberOfItems; i++)
                {
                    Console.Write("Enter list item {0} : ",i);
                    sw.WriteLine(Console.ReadLine());
                }
            }
        }

        //method that will get all the line strings into list , sort them and then enter them into
        //a new file and free the memory after that
        static void GetListFromTextFile() 
        {
            List<string> resultString = new List<string>();
            using (StreamReader sr = new StreamReader("UnsortedUserList.txt"))
            {
                string line = sr.ReadLine();
                while (line != null)
	            {
                    resultString.Add(line);
                    line = sr.ReadLine();
	            }
            }
            //sort the list
            resultString.Sort();
            //enter list into a new .txt file
            EnterListIntoFile(resultString);
        }

        //method that enters list items into new text file
        static void EnterListIntoFile(IEnumerable list) 
        {
            using (StreamWriter sw = new StreamWriter("SortedList.txt"))
            {
                foreach (var listItem in list)
                {
                    sw.WriteLine(listItem);
                }
            }
        }

        //method for printing from sorted file if you want to print the unsorted too copy paste with different name
        //and change the file name should work fine
        static void PrintSortedTxtFile() 
        {
            using (StreamReader sr = new StreamReader("SortedList.txt"))
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
            }
        }

        static void Main()
        {
            //call the methods to enter and then make the new files
            MakeListFileTxt();
            GetListFromTextFile();
            //print the result of the sorted list of items from the SortedList.txt file
            PrintSortedTxtFile();
        }
    }
}
