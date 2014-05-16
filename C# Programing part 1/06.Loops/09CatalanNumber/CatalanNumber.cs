using System;
using System.Numerics;

//In the combinatorial mathematics, the Catalan numbers are calculated 
//by the following formula:
//           1     | 2n |       (2n)!
// Cn =  --------- |    | =  -----------     for n >= 0
//         n + 1   |  n |    (n + 1)!n!
//Write a program to calculate the Nth Catalan number by given N.


namespace _09CatalanNumber
{
    class CatalanNumber
    {
        static void Main()
        {
            Console.Write("Enter value for 'N' = ");
            int N = int.Parse(Console.ReadLine());
            int factN = 1;
            int factNmultiBy2 = 1;
            int factNplus1 = 1;
            int resultCn = 1;
            if ( N >= 0 )
	        {
                // loop for N!
                for (int i = 1; i <= N; i++)
                {
                    factN *= i;
                }
                // loop for (2*N)!
                for (int i = 1; i <= 2 * N; i++)
                {
                    factNmultiBy2 *= i;
                }
                // loop for (N + 1)!
                for (int i = 1; i <= N + 1; i++)
                {
                    factNplus1 *= i;
                }
                resultCn = factNmultiBy2 / (factNplus1 * factN);
                Console.WriteLine("Result = {0}", resultCn);
	        }
            else
	        {
                Console.WriteLine("N should be >= 0 ");
	        }
        }
    }
}
