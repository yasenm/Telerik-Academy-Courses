using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _02.LeastMajorityMultiply
{
    class LeastMajorityMultiply
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int[] arr = { a, b, c, d, e };
            int multiplied = 1;
            int counter = 0;
            int result = 0;
            while (true)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if ( (multiplied % arr[j]) == 0 )
                    {
                        counter++;
                    }
                    if ( counter >= 3 )
                    {
                        result = multiplied;
                    }
                    if (result != 0)
                    {
                        break;
                    }
                }
                if (result != 0)
                {
                    break;
                }
                counter = 0;
                multiplied++;
            }
            Console.WriteLine(result);
        }
    }
}
