using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _02Tribonacci
{
    class Tribonacci
    {
        static void Main()
        {
            //----- First three members of tribonacci sequence
            int T1 = int.Parse(Console.ReadLine());
            int T2 = int.Parse(Console.ReadLine());
            int T3 = int.Parse(Console.ReadLine());
            //----- 'N' member position we are trying to find
            int TN = int.Parse(Console.ReadLine());
            //----- Initiate array with 'N' members the answer will be the last member of array
            BigInteger[] tribonacciArray = new BigInteger[TN];
            //----- Input the first three members
            tribonacciArray[0] = T1;
            tribonacciArray[1] = T2;
            tribonacciArray[2] = T3;
            //----- Start calculating to the last member
            for (int i = 3; i < TN; i++)
            {
                tribonacciArray[i] = tribonacciArray[i - 3] + tribonacciArray[i - 2] + tribonacciArray[i - 1];
            }
            Console.WriteLine(tribonacciArray[TN-1]);
        }
    }
}
