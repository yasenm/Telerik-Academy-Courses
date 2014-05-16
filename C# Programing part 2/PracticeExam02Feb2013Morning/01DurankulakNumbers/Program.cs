namespace _01DurankulakNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;

    class Program
    {
        static void Main()
        {
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

            string inputDuran = Console.ReadLine();
            List<string> inputParts = new List<string>();
            for (int i = 0; i < inputDuran.Length; i++)
            {
                if (inputDuran[i].ToString() == inputDuran[i].ToString().ToLower())
                {
                    inputParts.Add(inputDuran.Substring(i, 2));
                    i++;
                }
                else
                {
                    inputParts.Add(inputDuran.Substring(i, 1));
                }
            }

            int powIndex = 0;
            decimal result = 0;
            for (int i = inputParts.Count - 1; i >= 0; i--)
            {
                for (int j = 0; j < digits.Count; j++)
                {
                    long powed = 1;
                    for (int k = 0; k < powIndex; k++)
                    {
                        powed *= 168;
                    }
                    if (inputParts[i] == digits[j])
                    {
                        result += j * powed;
                        break;
                    }
                }
                powIndex++;
            }
            Console.WriteLine(result);
        }
    }
}
