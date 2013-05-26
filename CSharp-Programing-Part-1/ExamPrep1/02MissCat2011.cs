using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.MissCat2011
{
    class MissCat2011
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] jury = new int[N];
            int counter = 0;
            int biggestCounter = 0;
            byte finalResult = 0;

            //----- Input all the jury's vote asked in an array afterwards to examin
            for (int i = 0; i < N; i++)
            {
                byte inputNumber = byte.Parse(Console.ReadLine());
                jury[i] = inputNumber;
            }
            //----- Check which vote is the most common and chose it as result
            for (int i = 0; i < jury.Length; i++)
            {
                //----- Loop that checks how many times a given [i] element is met in the array of votes
                for (int j = i; j < jury.Length; j++)
                {
                    //----- Every time we encounter the same element we count how many times we met it
                    if (jury[i] == jury[j])
                    {
                        counter++;          // keeps the count of equal elements met
                    }
                }
                //----- Check if we met some other element more times than the last one if so we update the
                //----- biggest counter with it and check next time with it
                if (counter > biggestCounter)
                {
                    biggestCounter = counter;
                    finalResult = (byte)jury[i];
                }
                else if (counter == biggestCounter)
                {
                    var tempResult = (byte)jury[i];
                    if ( tempResult < finalResult )
                    {
                        finalResult = tempResult;
                    }
                }
                counter = 0;
            }
            Console.WriteLine(finalResult);
        }
    }
}
