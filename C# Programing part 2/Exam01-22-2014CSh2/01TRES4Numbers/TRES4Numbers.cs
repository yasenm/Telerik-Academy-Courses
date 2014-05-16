using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _01TRES4Numbers
{
    class TRES4Numbers
    {
        static void Main()
        {
            BigInteger input = BigInteger.Parse(Console.ReadLine());

            string[] tres4ints = new string[]{"LON+", "VK-", "*ACAD", "^MIM", "ERIK|", "SEY&", "EMY>>", "/TEL", "<<DON"};

            string result = string.Empty;

            if (input == 0)
            {
                result = tres4ints[0];
            }
            else
            {
                while (input != 0)
                {
                    result = tres4ints[(int)(input % 9)] + result;
                    input /= 9;
                }
            }

            Console.WriteLine(result);
        }
    }
}
