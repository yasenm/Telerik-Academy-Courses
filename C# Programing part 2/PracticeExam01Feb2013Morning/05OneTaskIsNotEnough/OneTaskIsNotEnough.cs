using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05OneTaskIsNotEnough
{
    class OneTaskIsNotEnough
    {
        static void Main()
        {
            #region

            int N = int.Parse(Console.ReadLine());
            string firstPath = Console.ReadLine();
            string secondPath = Console.ReadLine();

            #endregion

            #region First task

            bool[] lamps = new bool[N];
            int resultFirstTask = 0;
            int startIndex = 0;
            int stepIndex = 2;

            while (true)
            {
                int finalStep = 0;
                for (int i = startIndex; i < lamps.Length; i+=stepIndex)
                {
                    if (lamps[i] == false)
	                {
                        lamps[i] = true;
                        finalStep = i + 1;
	                }
                }
                bool checker = true;
                for (int i = 0; i < lamps.Length; i++)
                {
                    if (checker != lamps[i])
                    {
                        checker = false;
                        break;
                    }
                }
                if (checker)
                {
                    resultFirstTask = finalStep;
                    break;
                }
                startIndex++;
                stepIndex++;
            }

            Console.WriteLine(resultFirstTask);

            #endregion

            #region Second task part

            SecondTask(firstPath);
            SecondTask(secondPath);

            #endregion

        }

        private static void SecondTask(string path)
        {
            int[] dx = { 1, 0, -1, 0 };
            int[] dy = { 0, 1, 0, -1 };

            int x = 0;
            int y = 0;
            int orientation = 0;

            for (int i = 0; i < 4; i++)
            {
                foreach (var command in path)
                {
                    if (command == 'S')
                    {
                        x += dx[orientation];
                        y += dy[orientation];
                    }
                    else if (command == 'L')
                    {
                        orientation -= 1;
                        orientation += 4;
                        orientation %= 4;
                    }
                    else if (command == 'R')
                    {
                        orientation += 1;
                        orientation %= 4;
                    }
                }
            }

            if (x == 0 && y == 0)
            {
                Console.WriteLine("bounded");
            }
            else
            {
                Console.WriteLine("unbounded");
            }

        }
    }
}
