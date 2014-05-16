using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04ConsoleJustification
{
    class ConsoleJustification
    {
        static void Main()
        {
            #region Input reading part

            int N = int.Parse(Console.ReadLine());
            int W = int.Parse(Console.ReadLine());
            string rawTextInput = string.Empty;
            for (int i = 0; i < N; i++)
            {
                rawTextInput += Console.ReadLine() + " ";
            }

            #endregion

            // removing all sequences of white spaces with a single one
            Regex regex = new Regex(@"\W+");
            rawTextInput = regex.Replace(rawTextInput, " ");
            string[] wordArray = rawTextInput.Split();
            int wordIndexer = 0;
            List<string> resultTextList = new List<string>();
            StringBuilder resultLine = new StringBuilder();

            // solving loop
            while (wordIndexer < wordArray.Length)
            {
                if (resultLine.Length + wordArray[wordIndexer].Length > W)
	            {
		            resultLine.Length -= 1;
                    int wsNeeded = W - resultLine.Length;
                    string[] resultLineFixingSpacesArray = resultLine.ToString().Split();
                    int wsWordIndex = 0;
                    if (resultLineFixingSpacesArray.Length > 1)
                    {
                        for (int i = 0; i < wsNeeded; i++)
                        {
                            if (wsWordIndex >= resultLineFixingSpacesArray.Length - 1)
                            {
                                wsWordIndex = 0;
                            }
                            resultLineFixingSpacesArray[wsWordIndex] += " ";
                            wsWordIndex++;
                        }
                    }

                    resultLine.Clear();
                    for (int i = 0; i < resultLineFixingSpacesArray.Length; i++)
                    {
                        resultLine.Append(string.Format("{0} ", resultLineFixingSpacesArray[i]));
                    }
                    resultLine.Length -= 1;
                    resultTextList.Add(resultLine.ToString());
                    resultLine.Clear();
	            }
                resultLine.Append(string.Format("{0} ", wordArray[wordIndexer]));
                wordIndexer++;

                if (wordIndexer == wordArray.Length - 1)
                {
                    resultLine.Length -= 1;
                    resultTextList.Add(resultLine.ToString());
                }
            }

            for (int i = 0; i < resultTextList.Count; i++)
            {
                Console.WriteLine(resultTextList[i]);
            }
        }
    }
}
