using System;

//Write a program that calculates the greatest common divisor (GCD) of given 
//two numbers. Use the Euclidean algorithm (find it in Internet).

namespace _08GDCEuclideanAlgorithm
{
    class GDCEuclideanAlgorithm
    {
        static void Main()
        {
            Console.WriteLine("Enter two numbers and find their gdc(A/B)!");
            Console.Write("A = ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("B = ");
            int B = int.Parse(Console.ReadLine());
            int gdcBigger = 0;
            int gdcLower = 0;
            int result = 0;
            int gdcTemp = 0;    // temp variable for holding values temporary
            //-------- Checking which of the input values is bigger so
            //         so we can divide by the lesser one
            if ( A > B )
            {
                gdcBigger = A;
                gdcLower = B;
            }
            else
            {
                gdcLower = A;
                gdcBigger = B;
            }
            while (true)
            {
                // if the remaider after the % dividing is 0 the greatest common divisor is the last divider
                // which remainder was != 0 gdcTemp ot gdcBigger
                if (gdcLower == 0)
                {
                    result = gdcBigger;
                    break;
                }
                // we give to the temp the last divider
                gdcTemp = gdcLower;
                // dividing with % to get remainder with the last devider
                gdcLower = gdcBigger % gdcLower;
                gdcBigger = gdcTemp;
            }
            Console.WriteLine("gdc({0}/{1}) = {2}", A, B, result);
        }
    }
}
