using System;

//Write a program that prints all possible cards from a standard deck of 52
//cards (without jokers). The cards should be printed with their English names.
//Use nested for loops and switch-case.

namespace _11PrintCards
{
    class PrintCards
    {
        static void Main()
        {
            //-------- Initialize array of all the possible card values from 2 to Ace
            string[] cardValues = 
                {
                    "2", "3", "4", "5", "6", "7", "8",
                    "9", "10", "J", "Q" ,"K" ,"A"
                };
            char cardSymbols;
            foreach (var item in cardValues)
            {
                // loop that generates card symbols 4 times and prints it 4 time for every
                // item in arra cardValues
                for (int i = 3; i <= 6; i++)
                {
                    cardSymbols = Convert.ToChar(i);
                    Console.Write("|{0,4} | ",item + cardSymbols);
                }
                Console.WriteLine();
            }

        }
    }
}
