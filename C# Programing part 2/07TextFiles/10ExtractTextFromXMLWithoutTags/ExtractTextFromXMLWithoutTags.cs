using System;
using System.IO;
using System.Text.RegularExpressions;

//Write a program that extracts from given XML file all the text without the tags.
//Example:
//<?xml version="1.0"><student><name>Pesho</name><age>21</age><interests count="3">
//<interest> Games</instrest><interest>C#</instrest><interest> Java</instrest>
//</interests></student>

namespace _10ExtractTextFromXMLWithoutTags
{
    class ExtractTextFromXMLWithoutTags
    {
        static void Main()
        {
            //i don't realy like my solution i think is very stupid so i would like a good comment how to improve it or make it 
            //from scratch new thanks in advance. altho that one is working as far as i tested but its very bad written in my opignion.
            //regex that will get us inside the tags to the most inner of them all
            string pattern = @"<[a-z]*>(.*)<\/[a-z]*>";
            using (StreamReader sr = new StreamReader("XMLfile.xml"))
            {
                using (StreamWriter sw = new StreamWriter("TextBetweenTags.txt"))
                {
                    string line = sr.ReadLine();
                    while (line != null)
                    {
                        string insideText = Regex.Match(line, pattern, RegexOptions.IgnoreCase).Value;
                        if (insideText != string.Empty)
                        {
                            //part that will extraxt the text between the inner tags
                            int index = insideText.IndexOf('>') + 1;
                            insideText = insideText.Substring(index, insideText.Length - index);
                            index = insideText.IndexOf('<');
                            insideText = insideText.Substring(0, index);
                            //write the line into a new text file
                            sw.WriteLine(insideText);
                            Console.WriteLine(insideText);
                        }
                        line = sr.ReadLine();
                    }
                }
            }
        }
    }
}
