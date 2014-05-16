using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05HelpDoge
{
    class HelpDoge
    {
        private static int counter = 0;

        static void Main()
        {
            string[] matrixDims = Console.ReadLine().Split();

            int N = int.Parse(matrixDims[0]);
            int M = int.Parse(matrixDims[1]);

            string[] boneCoords = Console.ReadLine().Split();

            int numberOfEnemies = int.Parse(Console.ReadLine());

            List<string[]> enemies = new List<string[]>();
            for (int i = 0; i < numberOfEnemies; i++)
            {
                enemies.Add(Console.ReadLine().Split());
            }

            int[,] yard = new int[N, M];

            yard[int.Parse(boneCoords[0].ToString()), int.Parse(boneCoords[1])] = 3;

            for (int i = 0; i < enemies.Count; i++)
            {
                yard[int.Parse(enemies[i][0]), int.Parse(enemies[i][1])] = 2;
            }

            Console.WriteLine(yard[1,1]);

        }

        private static void Move(int nextRow, int nextCol, int[,] matrix) 
        {
            if (nextRow >= matrix.GetLength(0) || matrix[nextRow, nextCol] == 4)
            {
                Move(nextRow - 1, nextCol + 1, matrix);
            }
            if (nextCol >= matrix.GetLength(1))
            {
                Move(nextRow + 1, nextCol - 1, matrix);
            }
            if (matrix[nextRow, nextCol] == 2)
            {
                return;
            }
            if (matrix[nextRow,nextCol] == 3)
            {
                counter++;
                return;
            }
        }

        private static void MoveDownCombinations(int nextRow, int nextCol, int[,] matrix) 
        {
            
        }

    }
}
