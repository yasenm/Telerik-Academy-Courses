using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    class Patterns
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            int[,] mattrix = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                string[] inputSplit = Console.ReadLine().Trim().Split();
                for (int j = 0; j < N; j++)
                {
                    mattrix[i, j] = int.Parse(inputSplit[j]);
                }
            }

            int row = -1;
            int col = 0;

            bool thereIsPattern = true;
            long bestPatternSum = 0;

            while (true)
            {
                row++;
                if (row >= N -2)
                {
                    row = 0;
                    col++;
                }
                if (col >= N - 4)
                {
                    break;
                }

                // pattern checking
                bool currentPatternAailable = true;
                long currentPathSum = 0;
                int pathRow = row;
                int pathCol = col + 1;

                for (int i = 0; i < 2; i++)
                {
                    if (mattrix[pathRow,pathCol] != mattrix[pathRow,pathCol - 1] + 1)
                    {
                        currentPatternAailable = false;
                        break;
                    }
                    currentPathSum += mattrix[pathRow, pathCol - 1];
                    pathCol++;
                }
                if (!currentPatternAailable)
                {
                    continue;
                }
                else
                {
                    currentPathSum += mattrix[pathRow, pathCol - 1];
                    pathCol--;
                    pathRow += 2;
                }

                for (int j = 0; j < 1; j++)
                {
                    if (mattrix[pathRow, pathCol] != mattrix[pathRow - 1, pathCol] + 1)
                    {
                        currentPatternAailable = false;
                        break;
                    }
                    currentPathSum += mattrix[pathRow - 1, pathCol];
                    pathRow++;
                }
                if (!currentPatternAailable)
                {
                    continue;
                }
                else
                {
                    currentPathSum += mattrix[pathRow - 1, pathCol];
                    pathRow--;
                    pathCol += 2;
                }

                for (int k = 0; k < 1; k++)
                {
                    if (mattrix[pathRow, pathCol] != mattrix[pathRow, pathCol - 1] + 1)
                    {
                        currentPatternAailable = false;
                        break;
                    }
                    currentPathSum += mattrix[pathRow, pathCol - 1];
                    pathCol++;
                }
                if (!currentPatternAailable)
                {
                    continue;
                }
                else
                {
                    currentPathSum += mattrix[pathRow, pathCol - 1];
                }

                if (currentPathSum > bestPatternSum && currentPatternAailable)
                {
                    thereIsPattern = currentPatternAailable;
                    bestPatternSum = currentPathSum;
                }
            }

            if (thereIsPattern)
            {
                Console.WriteLine("YES " + bestPatternSum);
            }
            else
            {
                Console.WriteLine("NO " + GetDiagonalSum(mattrix));
            }
        }
  
        private static long GetDiagonalSum(int[,] mattrix)
        {
            long result = 0;
            for (int i = 0; i < mattrix.GetLength(0); i++)
            {
                result += mattrix[i, i];
            }

            return result;
        }
    }
}
