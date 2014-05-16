namespace _02JoroTheRabit
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {

            string[] inputPath = Console.ReadLine().Split(new string[]{", "}, int.MaxValue , StringSplitOptions.RemoveEmptyEntries);
            int[] path = new int[inputPath.Length];
            for (int i = 0; i < path.Length; i++)
            {
                path[i] = int.Parse(inputPath[i]);
            }

            int bestResult = 0;
            int step = 1;
            for (int i = 0; i < path.Length; i++)
            {
                for (int j = 0; j < path.Length; j++)
                {
                    bool[] checkingArray = new bool[path.Length];
                    int currentResult = 1;
                    checkingArray[j] = true;
                    int currentIndex = j + step;
                    int lastIndex = j;
                    bool stillJumping = true;

                    while (stillJumping)
                    {
                        if (currentIndex >= inputPath.Length)
                        {
                            currentIndex -= inputPath.Length;
                        }
                        if (checkingArray[currentIndex] != true && path[lastIndex] < path[currentIndex])
                        {
                            currentResult++;
                            checkingArray[currentIndex] = true;
                        }
                        else
                        {
                            break;
                        }
                        lastIndex = currentIndex;
                        currentIndex += step;
                    }
                    if (bestResult < currentResult)
                    {
                        bestResult = currentResult;
                    }
                }
                step++;
            }
            Console.WriteLine(bestResult);
        }
    }
}
