namespace _02SpecialValues
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[][] matrixPaths = new int[N][];
            bool[][] matrixCheck = new bool[N][];

            // manage the input data into two matrixes one for checkings a booll one and one with the inouted integers as values after spliting the entered strings
            for (int i = 0; i < N; i++)
            {
                string[] rawInput = Console.ReadLine().Split(new string[]{", "}, StringSplitOptions.RemoveEmptyEntries);
                int[] intLines = new int[rawInput.Length];
                bool[] checkLines = new bool[rawInput.Length];
                for (int j = 0; j < intLines.Length; j++)
                {
                    intLines[j] = int.Parse(rawInput[j]);
                }

                matrixPaths[i] = intLines;
                matrixCheck[i] = checkLines;
            }

            int result = int.MinValue;
            for (int i = 0; i < matrixPaths[0].Length; i++)
            {
                for (int j = 0; j < matrixCheck.Length; j++)
                {
                    for (int k = 0; k < matrixCheck[j].Length; k++)
                    {
                        matrixCheck[j][k] = false;
                    }
                }

                int steps = 1;
                int cell = matrixPaths[0][i];
                int row = 0;
                int column = i;

                // check if the next cell is positive if yes continue doing the checks below if not stop and calc tha new answer
                while (cell >= 0 || matrixCheck[row][column] != true)
                {
                    if (cell < 0)
                    {
                        break;
                    }
                    else if (matrixCheck[row][column] == true)
                    {
                        break;
                    }
                    // make the check matrix cell true so if we reach her again we stop the sequence and start another one stoping the sequence
                    matrixCheck[row][column] = true;
                    steps++;
                    row++;

                    // nulling the row if we are at the line after the last one
                    if (row >= matrixPaths.GetLength(0))
                    {
                        row = 0;
                    }
                    column = cell;
                    cell = matrixPaths[row][column];
                }

                int path = steps + Math.Abs(cell);

                // if the path ended at a positive cell make path min values
                if (cell >= 0)
                {
                    path = int.MinValue;
                }

                if (path > result)
                {
                    result = path;
                }
            }
            Console.WriteLine(result);
        }
    }
}
