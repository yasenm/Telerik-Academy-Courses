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
            long[] countArr = new long[N];
            List<long> newList = new List<long>();
            List<long> tempList = new List<long>();
            long result = 0;
            int tempCounter = 0;
            int counter = 1;
            bool skipNumber = false;
            //---- Enter values in array
            for (int i = 0; i < N; i++)
            {
                newList.Add(long.Parse(Console.ReadLine()));
            }
            tempList = newList;

            for (int i = 0; i < tempList.Count; i++)
            {
                for (int j = i + 1; j < tempList.Count; j++)
                {
                    if ( j == tempList.Count)
                    {
                        continue;
                    }
                    if ( tempList[i] == tempList[j])
                    {
                        counter++;
                        tempList.RemoveAt(j);
                        j--;
                    }
                }
                if ( (counter % 2) != 0 )
                {
                    //---- Check for bigger count of odd times 
                    if (tempCounter < counter)
                    {
                        tempCounter = counter;
                        result = tempList[i];
                    }
                    //---- If we have equal times engaged multiple numbers check for the lowest one
                    else if (tempCounter == counter)
                    {
                        if (result > tempList[i])
                        {
                            result = tempList[i];
                        }
                    }
                }
                counter = 1;
            }
            Console.WriteLine(result);
        }
    }
}
