using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.FallDown
{
    class FallDown
    {
        static void Main()
        {
            int N = 8;
            int[] inputArray = new int[N];
            int[] resultArray = new int[N];
            //------- Input values in array
            for (int i = 0; i < N; i++)
            {
                inputArray[i] = int.Parse(Console.ReadLine());
            }
            //for (int i = 0; i < N; i++)
            //{
            //    Console.Write("{0,0:000}",inputArray[i]);
            //    Console.WriteLine(" ---> |" + Convert.ToString(inputArray[i], 2).PadLeft(8, '0') + "|");
            //}
            //------- Set the result array start values of 0
            for (int i = 0; i < N; i++)
            {
                resultArray[i] = 0;
            }
            //------- Start solving
            for (int bitPosition = 0; bitPosition < N; bitPosition++)
            {
                //------- add mask to change numbers in resultArray
                int mask = 1 << bitPosition;
                int counter = 0;
                for (int index = 0; index < N; index++)
                {
                    if ( ( (inputArray[index] >> bitPosition) % 2 ) != 0 )
                    {
                        counter++;
                    }
                }
                //------- change with 1 the bits of the numbers in the last positions in resultArray counter from bottom - up they are
                //------- equal to 'counter'
                if (counter != 0)
                {
                    for (int i = N - counter; i < N; i++)
                    {
                        resultArray[i] = resultArray[i] | mask;
                    }
                }
            }
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(resultArray[i]);
            }
            //for (int i = 0; i < N; i++)
            //{
            //    Console.Write("{0,0:000}", resultArray[i]);
            //    Console.WriteLine(" ---> |" + Convert.ToString(resultArray[i], 2).PadLeft(8, '0') + "|");
            //}
        }
    }
}
