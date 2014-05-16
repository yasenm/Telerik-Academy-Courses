using System;
using System.IO;

//Write a program that concatenates two text files into another text file.

namespace _02ConcatinateTwoTextFiles
{
    class ConcatinateTwoTextFiles
    {
        //method that will make two text files which we will concatinate in the main method
        static void MakeTwoTextFiles() 
        {
            for (int i = 1; i < 3; i++)
            {
                using (StreamWriter sw = new StreamWriter("Text" + i + ".txt"))
                {
                    for (int j = 0; j < 10; j++)
                    {
                        sw.WriteLine("This is line from Text{0}.txt {0},{0},{0};",i);
                    }
                }
            }
        }

        static void Main()
        {
            MakeTwoTextFiles();
            //string that will hold the concatinated text's
            string wholeTextString = null;
            using (StreamReader streamReader1 = new StreamReader("Text1.txt"))
            {
                using (StreamReader streamReader2 = new StreamReader("Text2.txt"))
                {
                    string text1 = streamReader1.ReadToEnd();
                    string text2 = streamReader2.ReadToEnd();
                    wholeTextString = text1 + text2;
                }
            }
            //we write the concatinated text into a new file
            using (StreamWriter sw = new StreamWriter("TextConcatinate.txt"))
            {
                sw.Write(wholeTextString);
            }
            using (StreamReader sr = new StreamReader("TextConcatinate.txt"))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
        }
    }
}
