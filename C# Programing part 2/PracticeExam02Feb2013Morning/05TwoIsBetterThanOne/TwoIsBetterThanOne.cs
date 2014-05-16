using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05TwoIsBetterThanOne
{
    class TwoIsBetterThanOne
    {
        private static void FirstTask(string[] inputArray) 
        {
            bool possiblePalindrome = true;
            int resultCounter = 0;
            int[] interval = new int[2];
            interval[0] = int.Parse(inputArray[0]);
            interval[1] = int.Parse(inputArray[1]);
            for (int i = interval[0]; i <= interval[1]; i++)
            {
                if (i.ToString().Substring(0,1) == i.ToString().Substring(i.ToString().Length - 1,1)
                    && (i.ToString().Substring(0, 1) == "3" || i.ToString().Substring(0, 1) == "5"))
                {
                    for (int j = 0; j < i.ToString().Length; j++)
                    {
                        if (i.ToString()[j] != '3' && i.ToString()[j] != '5')
                        {
                            possiblePalindrome = false;
                        }
                    }
                    if (possiblePalindrome && i.ToString() == string.Concat(Enumerable.Reverse(i.ToString())))
                    {
                        resultCounter++;
                    }
                }
            }
            Console.WriteLine(resultCounter);
        }

        private static void SecondTask(string[] array, int percentage) 
        {
            int[] intArray = new int[array.Length];
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = int.Parse(array[i]);
            }

            int result = int.MinValue;
            int[] sortedArray = intArray.OrderBy(x => x).ToArray();
            int counter = 0;
            int percent = percentage * (array.Length / 100);
            for (int i = 0; i <= percent; i++)
            {
                if (sortedArray[i] <= sortedArray[(int)percent] && counter <= (int)percent)
                {
                    counter++;
                    result = sortedArray[i];
                }
            }
            Console.WriteLine(result);
        }

        static void Main()
        {
            string[] inputArray = Console.ReadLine().Split();
            string[] secondTaskArray = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            int percentage = int.Parse(Console.ReadLine());

            // Call method first task
            FirstTask(inputArray);
            SecondTask(secondTaskArray,percentage);

        }
    }
}
