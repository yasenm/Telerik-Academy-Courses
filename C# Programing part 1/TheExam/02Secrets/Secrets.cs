using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _02Secrets
{
    class Secrets
    {
        static void Main()
        {
            //----- Initialize variables we will need
            BigInteger specialSum = 0;
            int oddOrEvenCounter = 1;
            BigInteger newN = 0;
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZ";
            BigInteger R = 0;
            int specialSumReamainder = 0;

            //----- input data
            BigInteger N = BigInteger.Parse(Console.ReadLine());
            if (N < 0)
            {
                N = N * (-1);
            }
            R = N;

            //----- Calculate special sum
            newN = N;
            while (N != 0)
            {
                newN = N % 10;
                if (oddOrEvenCounter % 2 == 0)
                {
                    specialSum = specialSum + (newN * newN) * oddOrEvenCounter;
                }
                else if (oddOrEvenCounter % 2 != 0)
                {
                    specialSum = specialSum + newN * (oddOrEvenCounter * oddOrEvenCounter);
                }
                N = N / 10;
                oddOrEvenCounter++;
            }
            Console.WriteLine(specialSum);
            //----- Alphabet string result solving
            specialSumReamainder = (int)(specialSum % 10);
                //----- Make 'specialSum' a number less then 26 so we could not crash
                while (specialSum > 104)
                {
                    specialSum = specialSum - 104;
                }
            if ( specialSumReamainder == 0)
            {
                Console.WriteLine("{0} has no secret alpha-sequence", R);
            }
            else
            {
                Console.WriteLine(alphabet.Substring((int)specialSum, (int)specialSumReamainder));
            }
        }
    }
}
