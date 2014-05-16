namespace ConsoleJustification
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            Queue<string> words = new Queue<string>();
            Queue<string> outputLineWords = new Queue<string>();

            int linesCount = int.Parse(Console.ReadLine());
            int maximumAllowedLineLength = int.Parse(Console.ReadLine());

            string inputLine = Console.ReadLine();
            int inputLineNumber = 1;

            ExtractWordsFromLine(inputLine, words);

            int currentWordsLength = 0;
            int gapSize = 0;
            int additionalWhiteSpacesNeeded = 0;
            bool singleWordOnLine = false;
            bool shouldPrint = false;

            StringBuilder output = new StringBuilder();
            string currentOutputWord = String.Empty;
            string currentWord = String.Empty;

            while (words.Count > 0 || outputLineWords.Count > 0)
            {
                if (words.Count > 0)
                {
                    currentWord = words.Peek();

                    if (currentWordsLength + outputLineWords.Count + currentWord.Length <= maximumAllowedLineLength)
                    {
                        outputLineWords.Enqueue(words.Dequeue());
                        currentWordsLength += currentWord.Length;

                        if (currentWordsLength + outputLineWords.Count - 1 == maximumAllowedLineLength)
                        {
                            shouldPrint = true;
                        }
                        else
                        {
                            shouldPrint = false;
                        }
                    }
                    else
                    {
                        shouldPrint = true;
                        // maximumAllowedLineLength - (currentWordsLength + outputLineWords.Count - 1)
                        int symbolsRemaining = maximumAllowedLineLength - currentWordsLength - outputLineWords.Count + 1;

                        if (outputLineWords.Count > 1)
                        {
                            singleWordOnLine = false;
                            gapSize = symbolsRemaining / (outputLineWords.Count - 1);
                            additionalWhiteSpacesNeeded = symbolsRemaining % (outputLineWords.Count - 1);
                        }
                        else
                        {
                            singleWordOnLine = true;
                        }
                    }
                }
                else
                {
                    shouldPrint = true;
                    // maximumAllowedLineLength - (currentWordsLength + outputLineWords.Count - 1)
                    int symbolsRemaining = maximumAllowedLineLength - currentWordsLength - outputLineWords.Count + 1;

                    if (outputLineWords.Count > 1)
                    {
                        singleWordOnLine = false;
                        gapSize = symbolsRemaining / (outputLineWords.Count - 1);
                        additionalWhiteSpacesNeeded = symbolsRemaining % (outputLineWords.Count - 1);
                    }
                    else
                    {
                        singleWordOnLine = true;
                    }
                }                

                if (shouldPrint)
                {
                    if (singleWordOnLine)
                    {
                        currentOutputWord = outputLineWords.Dequeue();
                        output.Append(currentOutputWord);
                        singleWordOnLine = false;
                    }
                    else
                    {
                        while (outputLineWords.Count > 1)
                        {
                            currentOutputWord = outputLineWords.Dequeue();

                            output.Append(currentOutputWord);
                            output.Append(new String(' ', gapSize + 1));

                            if (additionalWhiteSpacesNeeded > 0)
                            {
                                output.Append(' ');
                                additionalWhiteSpacesNeeded--;
                            }
                        }

                        currentOutputWord = outputLineWords.Dequeue();

                        output.Append(currentOutputWord);
                    }

                    output.AppendLine();
                    currentWordsLength = 0;
                    gapSize = 0;
                    additionalWhiteSpacesNeeded = 0;
                }                

                if (words.Count == 0 && inputLineNumber < linesCount)
                {
                    inputLine = Console.ReadLine();
                    inputLineNumber++;
                    ExtractWordsFromLine(inputLine, words);
                }
            }

            Console.Write(output.ToString());
        }
  
        private static void ExtractWordsFromLine(string inputLine, Queue<string> words)
        {
            string[] wordsOnLine = Regex.Split(inputLine, @"\s+");
            for (int index = 0; index < wordsOnLine.Length; index++)
            {
                string word = wordsOnLine[index];
                if (word != String.Empty)
                {
                    words.Enqueue(word);
                }
            }
        }
    }
}
