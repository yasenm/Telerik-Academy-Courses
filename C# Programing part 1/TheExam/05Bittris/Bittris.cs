using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Bittris
{
    class Bittris
    {
        static void Main()
        {
            //----- Initialize main variables
            int[] bittrisMatrix = new int[3];
            int newNumber = 0;
            int num;

            //----- Set matrix
            for (int i = 0; i < 3; i++)
            {
                bittrisMatrix[i] = 0;
            }

            //----- Input data
            int N = int.Parse(Console.ReadLine());

            //----- Main solving loop
            for (int i = 0; i < N; i++)
            {
                string inputData = Console.ReadLine();
                //----- Check if it's entered a card with number value
                if (int.TryParse(inputData, out num) == true)
                {
                    newNumber = int.Parse(inputData);
                }
                else
                {
                    if (inputData == "D")
                    {
                        
                    }
                    else if (inputData == "L")
                    {
                        newNumber = newNumber << 1;
                    }
                    else if (inputData == "R")
                    {
                        newNumber = newNumber >> 1;
                    }
                }
            }
        }
    }
}
