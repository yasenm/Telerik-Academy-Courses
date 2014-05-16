namespace _02MagicWordsSecondEdition
{
    using System;
    using System.Text;
    using System.Collections.Generic;

    class MagicWordsSecondEdition
    {
        static void Main()
        {
            int numberOfWords = int.Parse(Console.ReadLine());

            int wordMaxLength = 0;

            List<string> wordList = new List<string>();

            for (int i = 0; i < numberOfWords; i++)
            {
                wordList.Add(Console.ReadLine());
                if (wordMaxLength < wordList[i].Length)
                {
                    wordMaxLength = wordList[i].Length;
                }
            }

            for (int i = 0; i < wordList.Count; i++)
            {
                string temp = wordList[i];
                wordList[i] = null;
                wordList.Insert(temp.Length % (numberOfWords + 1), temp);
                wordList.Remove(null);
            }

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < wordMaxLength; i++)
            {
                for (int j = 0; j < wordList.Count; j++)
                {
                    if (i >= wordList[j].Length)
                    {
                        continue;
                    }
                    result.Append(wordList[j][i]);
                }
            }

            Console.WriteLine(result.ToString());
        }
    }
}
