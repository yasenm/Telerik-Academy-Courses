using System;

//Write a program that creates an array containing all letters from the
//alphabet (A-Z). Read a word from the console and print the index of
//each of its letters in the array.

namespace _12WordAndItsLetterPositionsInAlphabet
{
    class WordAndItsLetterPositionsInAlphabet
    {
        static void Main()
        {
            Console.Write("Enter a word : ");
            string inputWord = Console.ReadLine();
            string[] alphabetArray = {"a","b","c","d","e","f","g","h","i","j","k","l","m",
                                      "n","o","p","q","r","s","t","u","v","w","x","y","z"};
            
            //---- print alphabet
            Console.WriteLine("Alphabet : ");
            for (int i = 0; i < alphabetArray.Length; i++)
            {
                Console.Write("'{0}'|",alphabetArray[i]);
            }

            //---- start examining the word and checking for the indexes of characters
            Console.WriteLine();
            for (int i = 0; i < inputWord.Length; i++)
            {
                for (int j = 0; j < alphabetArray.Length; j++)
                {
                    if (inputWord.Substring(i,1).ToLower() == alphabetArray[j])
                    {
                        Console.WriteLine("'{0}' index in alphabet array is : {1}", inputWord.Substring(i, 1), j);
                    }
                }
            }
        }
    }
}
