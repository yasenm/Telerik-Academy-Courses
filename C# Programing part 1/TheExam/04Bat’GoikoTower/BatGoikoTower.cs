using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Bat_GoikoTower
{
    class Program
    {
        static void Main()
        {
            //----- Initialize main drawing chars
            string dot = ".";
            string dash = "-";
            string rightSlash = "/";
            string leftSlash = "\\";
            string dots = "";
            string dashes = "";
            string result = "";

            //----- Input data
            int H = int.Parse(Console.ReadLine());

            //----- Some string builds
            for (int i = 0; i < 2*H; i++)
            {
                dots = dots + dot;
            }
            for (int i = 0; i < 2*H; i++)
            {
                dashes = dashes + dash;
            }

            //----- Drawing loop
            for (int i = 0; i < H; i++)
            {
                if ( i == 1 || i == 3 || i == 6 || i == 10 || i == 15 || i == 21 || i == 28 || i == 36)
                {
                    result = result + dots.Substring(0, H - i - 1) + rightSlash + dashes.Substring(0, i*2) + leftSlash + dots.Substring(0, H - i - 1);
                }
                else
                {
                    result = result + dots.Substring(0, H - i - 1) + rightSlash + dots.Substring(0, i * 2) + leftSlash + dots.Substring(0, H - i - 1);
                }
                Console.WriteLine(result);
                result = "";
            }

        }
    }
}
