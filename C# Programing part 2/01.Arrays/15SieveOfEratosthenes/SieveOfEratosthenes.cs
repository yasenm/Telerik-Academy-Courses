using System;
using System.Collections.Generic;

//Write a program that finds all prime numbers in the range [1...10 000 000]. 
//Use the sieve of Eratosthenes algorithm (find it in Wikipedia).

namespace _15SieveOfEratosthenes
{
    class SieveOfEratosthenes
    {
        static void Main()
        {
            //First since we need an array with length of 10 000 001 because we will
            //work with its indexes as results then we fill the array with 1's
            int[] workingArray = new int[10000001];
            for (int i = 0; i < workingArray.Length; i++)
            {
                workingArray[i] = 1;
            }
            workingArray[0] = 0;
            workingArray[1] = 0;
            //the positions at which we will have 0's are the prime numbers we are looking for

            //then we need to impliment the he sieve of Eratosthenes algorithm and
            //find all the prime numbers from that array and we assume all numbers are prime in begining.
            //We start from 2 as a first prime number
            for (int i = 2; i < workingArray.Length; i++)
            {
                //if we find a prime number we start to find its multiples and fill them with 0's
                if (workingArray[i] == 1)
                {
                    //filling the multiples of primes with 0's
                    for (int j = 2; j*i < workingArray.Length; j++)
                    {
                        workingArray[j * i] = 0;
                    }
                }
            }
            //Since we found the prime numbers ( in this case the positions which have in them 1)
            //we fill a result array with the prime numbers and print it
            int counter = 0; //to count the amount of prime numbers will be used to determin resutArray length
            for (int i = 2; i < workingArray.Length; i++)
            {
                if (workingArray[i] == 1)
                {
                    counter++;
                }
            }
            int[] resultArray = new int[counter];
            for (int i = 0, j = 0; i < workingArray.Length; i++)
            {
                if (workingArray[i] == 1)
                {
                    resultArray[j] = i;
                    j++;
                }
            }
            //print resultArray
            Console.WriteLine("All prime numbers to 10 000 000 array is : ");
            for (int i = 0; i < resultArray.Length; i++)
            {
                Console.Write("{0,0:000},", resultArray[i]);
            }
            Console.WriteLine();
        }
    }
}
