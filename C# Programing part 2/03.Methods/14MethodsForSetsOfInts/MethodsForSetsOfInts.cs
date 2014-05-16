using System;
using System.Collections;
using System.Numerics;

//Write methods to calculate minimum, maximum, average, sum and product
//of given set of integer numbers. Use variable number of arguments.

namespace _14MethodsForSetsOfInts
{
    class MethodsForSetsOfInts
    {
        //fill array with random numbers between 1 and 100
        static void FillArray(decimal[] array)
        {
            Random randomNumber = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randomNumber.Next(0, 101);
            }
        }

        //printing array
        static void PrintArray(IEnumerable array)
        {
            foreach (var item in array)
            {
                Console.Write("|{0,3}|", item);
            }
            Console.WriteLine();
        }

        //find minimal member of set
        static decimal MinimalMemberOfSet(IEnumerable set) 
        {
            decimal min = Decimal.MaxValue;
            foreach (var item in set)
            {
                if ((decimal)item < min)
                {
                    min = (decimal)item;
                }
            }
            return min;
        }

        //find minimal member of set
        static decimal MaximalMemberOfSet(IEnumerable set)
        {
            decimal max = Decimal.MinValue;
            foreach (var item in set)
            {
                if ((decimal)item > max)
                {
                    max = (decimal)item;
                }
            }
            return max;
        }

        //find avarage of all members in set
        static decimal AvarageOfSet(decimal[] array)
        {
            decimal avarage = 0;
            //calculate avarage from all values
            for (int i = 0; i < array.Length; i++)
            {
                avarage += array[i];
            }
            avarage = avarage / array.Length;
            return avarage;
        }

        //find sum from set members
        static decimal SumOfSet(IEnumerable set)
        {
            decimal sumResult = 0;
            foreach (var item in set)
            {
                sumResult += (decimal)item;
            }
            return sumResult;
        }

        //find the product of all members from a set of ints
        static BigInteger ProductOfSet(decimal[] set)
        {
            BigInteger productResult = 1;
            for (int i = 0; i < set.Length; i++)
            {
                productResult *= (BigInteger)set[i];
            }
            return productResult;
        }

        static void Main()
        {
            Console.Write("Enter length of set : ");
            int len = int.Parse(Console.ReadLine());
            decimal[] array = new decimal[len];
            FillArray(array);
            PrintArray(array);

            //find minimal value
            decimal minMember = MinimalMemberOfSet(array);
            Console.WriteLine("Min member is : {0};", minMember);

            //find maximal member
            decimal maxMember = MaximalMemberOfSet(array);
            Console.WriteLine("Max member is : {0};", maxMember);

            //find avatage from members
            decimal avarage = AvarageOfSet(array);
            Console.WriteLine("Avarage from all members is : {0};",avarage);

            //find sum from members
            decimal sum = SumOfSet(array);
            Console.WriteLine("Sum is : {0};",sum);

            //find product of all members
            BigInteger product = ProductOfSet(array);
            Console.WriteLine("Product from members of set is : {0};",product);
        }
    }
}
