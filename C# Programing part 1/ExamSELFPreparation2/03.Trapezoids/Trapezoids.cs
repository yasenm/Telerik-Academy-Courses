using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Trapezoids
{
    class Trapezoids
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            string[] arr = new string[N];
            string star = "*";
            string stars = "";
            string dot = ".";
            string dots = "";
            string result = "";
            for (int i = 0; i < N; i++)
            {
                dots += dot; 
            }
            for (int i = 0; i < N; i++)
            {
                stars += star;
            }
            for (int i = 0; i < N + 1; i++)
            {
                if (i == 0)
                {
                    result = dots + stars;
                }
                else if (i == N)
                {
                    result = stars + stars;
                }
                else
                {
                    result = dots.Substring(0, N - i) + star + dots.Substring(N - i, i) + dots.Substring(0, N - 2) + star;
                }
                Console.WriteLine(result);
                result = "";
            }
        }
    }
}
