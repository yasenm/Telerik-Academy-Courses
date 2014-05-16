using System;

//We are given 5 integer numbers. Write a program that checks if
//the sum of some subset of them is 0. Example: 3, -2, 1, 1, 8  1+1-2=0.

class SumSubset0
{
    static void Main()
    {
        Console.Write("Enter length for set of numbers : ");
        int len = int.Parse(Console.ReadLine());
        int[] set = new int[len];
        int sum = 0;
        // count will get +1 every time we find a subset that equals 0
        int count = 0;
        for (int i = 0; i < len ; i++)
        {
            Console.Write("Enter integers in set : ");
            set[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("The set you entered is : " + String.Join(",", set));
        // a loop to enter array
        for (int i = 0; i < len; i++)
        {
            int[] result = new int[len];
            // this loop starts to calculate sums from a given start point of the
            // 'set' array to the last member of the array a.k.a. the subsets
            for (int j = i; j < len; j++)
            {
                result[j] = set[j];
                sum = sum + set[j];
                // when we find a subset that sum is 0 we count it and print the set
                if (sum == 0)
                {
                    count++;
                    Console.WriteLine(String.Join(",", result));
                }
            }
            // reset of sum so on next loop starts from 0 again
            sum = 0;
        }
        Console.WriteLine("Count of subsets that equal 0 is {0}", count);
    }
}
