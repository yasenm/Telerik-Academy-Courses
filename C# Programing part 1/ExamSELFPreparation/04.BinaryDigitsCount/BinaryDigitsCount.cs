using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.BinaryDigitsCount
{
    class BinaryDigitsCount
    {
        static void Main()
        {
            string bit = Console.ReadLine();
            int N = int.Parse(Console.ReadLine());
            byte result = 0;
            for (int i = 0; i < N; i++)
            {
                uint number = uint.Parse(Console.ReadLine());
                string binaryNumber = Convert.ToString(number, 2);
                for (int j = 0; j < binaryNumber.Length; j++)
                {
                    if ( binaryNumber.Substring(j, 1) == bit )
                    {
                        result++;
                    }
                }
                Console.WriteLine(result);
                result = 0;
            }
        }
    }
}
