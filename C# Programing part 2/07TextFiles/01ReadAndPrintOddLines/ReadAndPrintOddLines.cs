using System;
using System.IO;

//Write a program that reads a text file and prints on the console its odd lines.

namespace _01ReadAndPrintOddLines
{
    class ReadAndPrintOddLines
    {
        static void Main()
        {
            //part that we make text file with every odd line writen "odd line" and every even "Even line"
            using (StreamWriter sw = new StreamWriter("text.txt"))
            {
                for (int i = 0; i < 15; i++)
                {
                    if (i % 2 == 0)
                    {
                        sw.WriteLine("even line.");
                    }
                    else
                    {
                        sw.WriteLine("odd line.");
                    }
                }
            }
            //part of code for the exercise printing odd lines with streamreader
            using (StreamReader sr = new StreamReader("text.txt"))
            {
                for (int lineNumber = 0; lineNumber < 15; lineNumber++)
                {
                    string line = sr.ReadLine();
                    if (lineNumber % 2 != 0)
                    {
                        Console.WriteLine("Line {0}: {1}", lineNumber, line);
                    }
                    else
                    {
                        Console.WriteLine("Line {0}: {1}", lineNumber, null);
                    }
                }
            }
        }
    }
}
