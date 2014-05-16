using System;
using System.IO;
using System.Collections.Generic;

//Write a program that deletes from given text file all odd lines.
//The result should be in the same file.

namespace _09RemoveAllOddLinesFromFile
{
    class RemoveAllOddLinesFromFile
    {
        //method that will make our file that we will delete the odd lines from
        static void MakeSomeTextFile() 
        {
            using (StreamWriter sw = new StreamWriter("SomeText.txt"))
            {
                int lineNumber = 1;
                while (lineNumber <= 15)
                {
                    if (lineNumber % 2 != 0)
                    {
                        sw.WriteLine("This is a odd number line with some text in it.");
                    }
                    else
                    {
                        sw.WriteLine("This is a even number line with some text in it.");
                    }
                    lineNumber++;
                }
            }
        }

        //method that will remove the odd lines and pull null strings in them
        static void RemoveOddLineFromTextFile(string textFile) 
        {
            //we make a text list with the new lines that will hold our result without the odd lines
            List<string> newTextLines = new List<string>();
            using (StreamReader sr = new StreamReader(textFile))
            {
                int lineCounter = 1;
                string line = sr.ReadLine();
                while (line != null)
                {
                    //every even line is added with its string and every odd with empty string by removing the else
                    //statement will skip the odd lines and add only the even ones i left it like that because its 
                    //easier personaly to see where are the removed lines but you can comment is or remove it
                    if (lineCounter % 2 == 0)
                    {
                        newTextLines.Add(line);
                    }
                    else
                    {
                        newTextLines.Add(string.Empty);
                    }
                    lineCounter++;
                    line = sr.ReadLine();
                }
            }
            //overwrite the same text file without its odd number lines
            using (StreamWriter sw = new StreamWriter(textFile))
            {
                for (int i = 0; i < newTextLines.Count; i++)
                {
                    sw.WriteLine(newTextLines[i]);
                }
            }
        }

        static void Main()
        {
            MakeSomeTextFile();
            //chose file by user and default uncomment the one with console.readline for you to chose path to
            //other file and remove its odd number lines
            string textFile = "SomeText.txt";
            //for console user input of file location
            //string textFile = Console.ReadLine();
            RemoveOddLineFromTextFile(textFile);
        }
    }
}
