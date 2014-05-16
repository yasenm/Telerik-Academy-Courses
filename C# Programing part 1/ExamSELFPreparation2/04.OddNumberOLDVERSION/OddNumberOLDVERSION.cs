using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.OddNumber
{
    class OddNumber
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            long[] arr = new long[N];
            object[] countArr = new object[N];
            long result = 0;
            int tempCounter = 0;
            int counter = 0;
            //---- Enter values in array
            for (int i = 0; i < N; i++)
            {
                arr[i] = long.Parse(Console.ReadLine());
            }
            for (int i = 0; i < N; i++)
            {
                countArr[i] = arr[i];
            }
            for (int i = 0; i < N; i++)
            {
                for (int j = i; j < N; j++)
                {
                    if ( arr[i].GetType() == countArr[j].GetType() )
                    {
                        if (arr[i] == (long)countArr[j])
                        {
                            counter++;
                            countArr[j] = "-";
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
                //---- Check for counter if we engaged odd nubmer of times arr[i]
                if ((counter % 2) != 0)
                {
                    //---- Check for bigger count of odd times 
                    if (tempCounter < counter)
                    {
                        tempCounter = counter;
                        result = arr[i];
                    }
                    //---- If we have equal times engaged multiple numbers check for the lowest one
                    else if (tempCounter == counter)
                    {
                        if (result > arr[i])
                        {
                            result = arr[i];
                        }
                    }
                }
                counter = 0;
            }
            Console.WriteLine(result);
        }
    }
}
