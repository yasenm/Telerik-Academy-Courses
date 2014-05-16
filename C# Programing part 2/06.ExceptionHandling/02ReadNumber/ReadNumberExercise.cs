using System;
using System.Collections.Generic;
using System.Collections;

//Write a method ReadNumber(int start, int end) that enters an integer number
//in given range [start…end]. If an invalid number or non-number text is entered,
//the method should throw an exception. Using this method write a program that
//enters 10 numbers:
//a1, a2, … a10, such that 1 < a1 < … < a10 < 100

namespace _02ReadNumber
{
    class ReadNumberExercise
    {
        private static Random randomNumber = new Random();

        //method ReadNumber as in exercise specifications
        static int ReadNumber(int start, int end) 
        {
            //part with user input of numbers between the interval
            Console.Write("Enter int : ");
            int num = int.Parse(Console.ReadLine());
            //uncoment and coment parts to use them
            ////part with random generated numbers for the interval
            //int num = randomNumber.Next(start,end);

            //check part of the method
            if (num < start || num > end)
            {
                throw new System.ArgumentOutOfRangeException("Invalid number not in specified range.");
            }

            return num;
        }

        //method for printing the list with the values input
        static void PrintCollection(IEnumerable collection) 
        {
            foreach (var member in collection)
            {
                Console.Write("{0},",member);
            }
        }

        static void Main()
        {
            Console.WriteLine("Enter starting point : ");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter ending point : ");
            int end = int.Parse(Console.ReadLine());
            List<int> listOfInts = new List<int>();

            try
            {
                for (int i = 0; i < 10; i++)
                {
                    listOfInts.Add(ReadNumber(start, end));
                }
            }
            catch (FormatException fe)
            {
                Console.Error.WriteLine("Invalid format of input. Parsing failed." + fe.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.Error.WriteLine("Error : " + ex.Message);
            }
            finally 
            {
                Console.WriteLine("Thank you and good bye.");
            }

            PrintCollection(listOfInts);
        }
    }
}
