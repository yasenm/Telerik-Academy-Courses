using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _05.SubsetSecond
{
    class SubsetSecond
    {
        static void Main()
        {
            BigInteger S = BigInteger.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            long[] setOfN = new long[N];
            int result = 0;
            BigInteger targetSum = S;
            //----- For loop to input the set ofnumbers
            for (int i = 0; i < N; i++)
            {
                setOfN[i] = long.Parse(Console.ReadLine());
            }
            //---- Sets
            int limit = (2 << (N-1)) - 1;
            for (int i = 1; i <= limit; i++)
            {
                BigInteger currentSum = 0;
                for (int bitIndex = 0; bitIndex < N; bitIndex++)
                {
                    if (((i >> bitIndex) & 1) == 1)
                    {
                        currentSum += setOfN[bitIndex];
                    }
                }
                if ( currentSum == targetSum )
                {
                    result++;
                }
            }
            Console.WriteLine(result);

        }
    }
}
