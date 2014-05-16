using System;
using System.Text.RegularExpressions;

//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d).
//Example of incorrect expression: )(a+b)).

namespace _03CheckForCorrectBrackets
{
    class CheckForCorrectBrackets
    {
        //method that will check if the brackets are correct
        static string CheckBrackets(string expression) 
        {
            //making a counter that will give us informarion for the encountered brackets
            int counter = 0;
            for (int i = 0; i < expression.Length; i++)
            {
                //each time we encounter "(" we add to the counter++ and after that each time we encounter ")"
                //we substract from counter-- that way if we have equal amounts of "(" and ")" we will have
                //correct expression otherwise it'll be incorrect
                if (expression[i] == '(')
                {
                    counter++;
                }
                else if (expression[i] == ')')
                {
                    counter--;
                }
            }
            return (counter == 0) ? "Correct expression brackets." : "Incorrect expression brackets.";
        }

        static void Main()
        {
            Console.Write("Enter a string to be reversed : ");
            string expression = Console.ReadLine();
            Console.WriteLine(CheckBrackets(expression));
        }
    }
}
