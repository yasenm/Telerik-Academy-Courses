using System;

////Write a program that generates and prints to the console 10 random values in the range [100, 200].

namespace _02Print10RandomValues
{
    public class Print10RandomValues
    {
        ////random number generator
        public static class RandomNumbers
        {
            public static Random Generator = new Random();
        }

        static void Main()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(RandomNumbers.Generator.Next(100,200));
            }
        }
    }
}
