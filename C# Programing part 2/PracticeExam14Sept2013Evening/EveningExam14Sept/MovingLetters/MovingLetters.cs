using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovingLetters
{
    class MovingLetters
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();

            int maxWordLength = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Length > maxWordLength)
                {
                    maxWordLength = input[i].Length;
                }
            }

            StringBuilder extractedLetters = new StringBuilder();

            for (int i = 0; i < maxWordLength; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if (input[j].Length <= i)
                    {
                        continue;
                    }
                    extractedLetters.Append(input[j][input[j].Length - i - 1]);
                }
            }

            for (int i = 0; i < extractedLetters.Length; i++)
            {
                var letter = extractedLetters[i];

                var inputIndex = extractedLetters[i] - 'a' + 1;

                if (letter.ToString() != letter.ToString().ToLower())
                {
                    inputIndex = extractedLetters[i].ToString().ToLower()[0] - 'a' + 1;
                }

                inputIndex = GetRealIndex(inputIndex + i, extractedLetters.Length);

                extractedLetters.Remove(i, 1);

                extractedLetters.Insert(inputIndex, letter);
            }

            Console.WriteLine(extractedLetters.ToString());
        }
  
        private static int GetRealIndex(int inputIndex, int len)
        {
            if (len <= inputIndex)
            {
                inputIndex = inputIndex - len;
                inputIndex = GetRealIndex(inputIndex, len);
            }
            return inputIndex;
        }
    }
}
