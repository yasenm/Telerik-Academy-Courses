using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02GreedyDwarf
{
    class GreedyDwarf
    {
        static void Main()
        {
            #region Input reading part

            string[] stringNumArray = Console.ReadLine().Split(new char[]{','}, StringSplitOptions.None);
            int[] valley = new int[stringNumArray.Length];
            for (int i = 0; i < valley.Length; i++)
            {
                valley[i] = int.Parse(stringNumArray[i]);
            }

            int m = int.Parse(Console.ReadLine());
            int[][] jaggedPatterns = new int[m][];
            for (int i = 0; i < jaggedPatterns.LongLength; i++)
            {
                string[] pattern = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.None);
                jaggedPatterns[i] = new int[pattern.Length];
                for (int j = 0; j < jaggedPatterns[i].Length; j++)
                {
                    jaggedPatterns[i][j] = int.Parse(pattern[j]);
                }
            }
            #endregion

            long bestResult = long.MinValue;
            for (int i = 0; i < jaggedPatterns.LongLength; i++)
            {
                bool notEscaped = true;
                bool[] valleyChecker = new bool[valley.Length];
                int patternPath = 0;
                long currentResult = valley[patternPath];
                valleyChecker[patternPath] = true;

                while (notEscaped)
                {
                    for (int j = 0; j < jaggedPatterns[i].Length; j++)
                    {
                        patternPath += jaggedPatterns[i][j];
                        if (patternPath >= valley.Length || patternPath < 0)
                        {
                            notEscaped = false;
                            break;
                        }
                        if (valleyChecker[patternPath] == true)
                        {
                            notEscaped = false;
                            break;
                        }
                        currentResult += valley[patternPath];
                        valleyChecker[patternPath] = true;
                    }
                }

                if (bestResult < currentResult)
                {
                    bestResult = currentResult;
                }
            }

            Console.WriteLine(bestResult);
        }
    }
}
