using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SubsetSums
{
    class SubsetSums
    {
        static void Main()
        {
            long S = long.Parse(Console.ReadLine());
            byte N = byte.Parse(Console.ReadLine());
            long[] setOfN = new long[N];
            byte result = 0;
            long sum = 0;
            //----- For loop to input the set ofnumbers
            for (int i = 0; i < N; i++)
            {
                setOfN[i] = long.Parse(Console.ReadLine());
            }
            //----- For loop to check the sums and if they are equal to S result gets + 1
            for (int i = 0; i < setOfN.Length; i++)
            {
                //----- For loop for subset sequence of numbers 
                for (int j = i; j < setOfN.Length; j++)
                {
                    sum = sum + setOfN[j];
                    if (sum == S)
                    {
                        result++;
                    }
                }
                //----- For loop for if two integers are equal
                for (int j = 0; j < setOfN.Length; j++)
                {
                    if ( (setOfN[i] + setOfN[j]) == S )
                    {
                        result++;
                    }
                }
                sum = 0;
            }
            Console.WriteLine(result);
        }
    }
}
