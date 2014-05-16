using System;
using System.IO;

//Write a program that compares two text files line by line and prints the
//number of lines that are the same and the number of lines that are different.
//Assume the files have equal number of lines.

namespace _04CompareTwoTextFilesLines
{
    class CompareTwoTextFilesLines
    {
        static void Main()
        {
            int numberOfEqualLines = 0;
            int numberOfDifferendLines = 0;
            //I've made two text files for the exercise as always in the /bin/debug/.... file of the exercise in the solution
            //if you wish to check with your owns you can always write in them or change the sreamreaders paths ;) don't forget
            //when checking the result that the empty lines will be counted as equal also and they are 2 in both of mine files
            //First we enter the first text file
            using (StreamReader sr1 = new StreamReader("FirstTextFile.txt"))
            {
                //then the second one and start comparing the string of the lines if equal ++ to equal coef else ++ to the different one
                using (StreamReader sr2 = new StreamReader("SecondTextFile.txt"))
                {
                    string firstLine = sr1.ReadLine();
                    string secondLine = sr2.ReadLine();
                    while (firstLine != null)
                    {
                        if (firstLine == secondLine)
                        {
                            numberOfEqualLines++;
                        }
                        else
                        {
                            numberOfDifferendLines++;
                        }
                        firstLine = sr1.ReadLine();
                        secondLine = sr2.ReadLine();
                    }
                }
                //works with the files i've tested and made test with more of your own ill apretiate a feedback in comments thanks
                Console.WriteLine("Number of equal lines is : {0}", numberOfEqualLines);
                Console.WriteLine("Number of different lines is : {0}", numberOfDifferendLines);
            }
        }
    }
}
