using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03FirTree
{
    class FirTree
    {
        static void Main()
        {
            //----- Input height of fir tree
            int N = int.Parse(Console.ReadLine());
            int treePick = N / 2;
            //----- Initiate strings for tree use
            string dot = ".";
            string star = "*";
            string background = "";
            string tree = "";
            string result = "";
            for (int i = 0; i < N + N - 3; i++)
			{
                tree = tree + star;
			}
            for (int i = 0; i < N + N - 3; i++)
			{
			    background = background + dot;
			}
            //for (int i = 0; i < N; i++)
            //{
            //    result = result + background;			 
            //}
            for (int i = 0; i < N; i++)
            {
                if ( i == N - 1)
                {
                    result = result + background.Substring(0, (N + N - 3) / 2) + tree.Substring(0, 1) + background.Substring(0, (N + N - 3)/2);
                }
                else
                {
                    result = result + background.Substring(0, (N + N - 3) / 2 - i) + tree.Substring(0, i * 2 + 1) + background.Substring(0, (N + N - 3) / 2 - i);
                }
                Console.WriteLine(result);
                result = "";
            }
        }
    }
}
