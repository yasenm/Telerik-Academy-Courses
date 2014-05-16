using System;
using System.IO;

//Write a program that reads a text file and inserts line numbers in front of
//each of its lines. The result should be written to another text file.

namespace _03AddLineNumbersToTextFiles
{
    class AddLineNumbersToTextFiles
    {
        static void Main()
        {
            //first we enter the text file we need to get the lines from you can try with your own text file
            //by changing path of the stream reader and then in the 'NewTextFile.txt' it'll be your text with
            //its line numbering in the directory of the program /bin/debug/NewTextFile.txt
            using (StreamReader sr = new StreamReader("SomeTextFile.txt"))
            {
                //then we make a new streamwriter that will write the lines with their numbers into a new .txt file
                using (StreamWriter sw = new StreamWriter("NewTextFile.txt"))
                {
                    //lineNumber holds our line progretion
                    int lineNumber = 1;
                    string line = sr.ReadLine();
                    //while we have actual lines until we find the end of text we add numbers to the lines
                    while (line != null)
	                {
                        sw.WriteLine("Line " + lineNumber + ": " + line);
                        lineNumber++;
                        line = sr.ReadLine();
	                }
                }
            }

            using (StreamReader sr = new StreamReader("NewTextFile.txt"))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
        }
    }
}
