using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01KaspichanNumbers
{
    class KaspichanNumbers
    {
        static void Main(string[] args)
        {
            ulong n = ulong.Parse(Console.ReadLine());
            List<string> digits = new List<string>();

            for (char i = 'A'; i <= 'Z'; i++)
            {
                digits.Add(i.ToString());
            }

            int end = 256;
            int counter = 0;
            for (char i = 'a'; i < 'z'; i++)
            {
                for (char j = 'A'; j <= 'Z'; j++)
                {
                    counter++;
                    digits.Add(i.ToString() + j.ToString());
                }
                if (counter >= end)
                {
                    break;
                }
            }

            string result = string.Empty;
            if (n == 0)
            {
                result = "A";
            }
            else
            {
                while (n != 0)
                {
                    result = digits[(int)(n % 256)] + result;
                    n /= 256;
                }
            }

            Console.WriteLine(result);
        }
    }
}
