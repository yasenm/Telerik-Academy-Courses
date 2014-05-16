using System;
using System.Collections.Generic;

//See BGCoder for exercise specification

namespace _01KaspichanNumbers
{
    class KaspichanNumbers
    {
        static void Main()
        {
            ulong n = ulong.Parse(Console.ReadLine());
            List<string> digits = new List<string>();

            for (char i = 'A'; i <= 'Z'; i++)
            {
                digits.Add(i.ToString());
            }

            for (char i = 'a'; i <= 'z'; i++)
            {
                for (char j = 'A'; j < 'Z'; j++)
                {
                    digits.Add(i.ToString() + j.ToString());
                }
                digits.Add(i.ToString());
            }

            string result = "";
            if (n == 0)
            {
                result = "A";
            }
            while (n != 0)
            {
                result = digits[(int)(n % 256)] + result;
                n /= 256;
            }

            Console.WriteLine(result);
        }
    }
}
