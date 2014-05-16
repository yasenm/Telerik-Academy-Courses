using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ForrestRoad
{
    class ForrestRoad
    {
        static void Main()
        {
            //------ Input length of start string
            byte N = byte.Parse(Console.ReadLine());
            string person = "*";
            string road = "";
            string points = ".";
            string result = "";
            for (int i = 0; i < N - 1; i++)
            {
                road = road + points;
            }
            for (int i = 0; i <= road.Length; i++)
            {
                result = road.Substring(0, i) + person + road.Substring(i, road.Length - i);
                Console.WriteLine(result);
                result = "";
            }

            for (int i = road.Length - 1; i >= 0; i--)
            {
                result = road.Substring(0, i) + person + road.Substring(i, road.Length - i);
                Console.WriteLine(result);
                result = "";
            }
        }
    }
}
