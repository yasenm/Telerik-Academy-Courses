using System;
using System.Text.RegularExpressions;

//Write a program that finds how many times a substring is contained in
//a given text (perform case insensitive search).
//Example: The target substring is "in". The text is as follows:
//"We are living in an yellow submarine. We don't have anything else.
//Inside the submarine is very tight. So we are drinking all the day.
//We will move out of it in 5 days."
//The result is: 9.

namespace _04TimesSubstringIsContained
{
    class TimesSubstringIsContained
    {
        //method that will return the number of times of encountered substring with RegEx
        static int SubstringEncounterRegex(string text, string substr) 
        {
            string regex = @"(" + substr + ")";
            return Regex.Matches(text, regex, RegexOptions.IgnoreCase).Count;
        }

        //method without RegEx
        static int SubstringEncounterSubstring(string text, string substr) 
        {
            int counter = 0;
            for (int i = 0; i < text.Length - substr.Length; i++)
            {
                if (text.Substring(i,substr.Length).ToLower() == substr.ToLower())
                {
                    counter++;
                }
            }
            return counter;
        }

        static void Main()
        {
            Console.WriteLine("The text we are testing is");
            string text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            Console.WriteLine(text);
            Console.Write("Enter substring to count times it's encountered : ");
            string substr = Console.ReadLine();

            //first way to solve
            Console.WriteLine(SubstringEncounterRegex(text,substr));
            Console.WriteLine();
            //second way to solve
            Console.WriteLine(SubstringEncounterSubstring(text,substr));
        }
    }
}
