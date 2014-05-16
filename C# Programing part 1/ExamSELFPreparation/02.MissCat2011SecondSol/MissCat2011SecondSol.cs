using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.MissCat2011
{
    class MissCat2011
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] jury = new int[N];
            int[] resultArr = new int[10];
            int finalResult = 0;
            int result = 0;

            //----- Input all the jury's vote asked in an array afterwards to examin
            for (int i = 0; i < N; i++)
            {
                byte inputNumber = byte.Parse(Console.ReadLine());
                jury[i] = inputNumber;
            }
            for (int i = 0; i < N; i++)
            {
                var j = jury[i];
                resultArr[j - 1] = resultArr[j - 1] + 1;
            }
            finalResult = resultArr[0];
            result = 1;
            for (int i = 0; i < resultArr.Length; i++)
            {
                if (finalResult < resultArr[i])
                {
                    finalResult = resultArr[i];
                    result = i + 1;
                }
            }
            Console.WriteLine(result);
        }
    }
}
