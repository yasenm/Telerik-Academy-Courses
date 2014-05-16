// Exercise 05 : Define a class BitArray64 to hold 64 bit values inside an ulong value.
// Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.

namespace _05BitArray64Exercise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class BitArray64Exercise
    {
        static void Main()
        {
            BitArray64 number = new BitArray64(7);
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(number[i]);
            }
            Console.WriteLine(number);
        }
    }
}
