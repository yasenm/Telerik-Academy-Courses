using System;

//Write a program that can solve these tasks:

//Reverses the digits of a number
//Calculates the average of a sequence of integers
//Solves a linear equation a * x + b = 0

//Create appropriate methods.
//Provide a simple text-based menu for the user to choose which task to solve.

//Validate the input data:
//The decimal number should be non-negative
//The sequence should not be empty
//a should not be equal to 0

namespace _13SolveTasks
{
    class SolveTasks
    {
        //check entry and if its not valid return to the same choice
        static int MainEntryInput()
        {
            Console.Write("Enter your choice : ");
            int csEntry = int.Parse(Console.ReadLine());
            if (csEntry <= 0 || csEntry > 3)
            {
                Console.WriteLine("Invalid input entry! Try again!");
                csEntry = MainEntryInput();
            }
            Console.WriteLine("Good choice! :)");
            return csEntry;
        }

        //method that reverses digits in a given positive number
        static decimal ReverseNumberDigits(decimal number)
        {
            string stringNumber = "" + number;
            string stringReversedNumber = "";
            for (int i = stringNumber.Length - 1; i >= 0; i--)
            {
                stringReversedNumber += stringNumber[i];
            }
            decimal result = decimal.Parse(stringReversedNumber);
            return result;
        }

        //method that validates the entry for the reverse digit method
        static decimal ReverseEntryValidator() 
        {
            Console.Write("Enter a decimal number to be reversed : ");
            decimal csEntry = decimal.Parse(Console.ReadLine());
            if (csEntry < 0 )
            {
                Console.WriteLine("Pick new number that is > 0");
                csEntry = ReverseEntryValidator();
            }
            return csEntry;
        }

        //method for the second option
        static decimal AvarageOfSequence() 
        {
            decimal result = 0;
            //make sequnce and add values as you wish them to be
            Console.Write("Chose length for sequence : ");
            int len = int.Parse(Console.ReadLine());
            decimal[] array = new decimal[len];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Enter number for arr[{0}] = ",i);
                array[i] = decimal.Parse(Console.ReadLine());
            }
            //calculate avarage from all values
            for (int i = 0; i < array.Length; i++)
            {
                result += array[i];
            }
            result = result / len;
            return result;
        }

        //equation validator for 'a' input entry
        static decimal EquationAValidatorEntry()
        {
            Console.Write("a = ");
            decimal result = decimal.Parse(Console.ReadLine());
            if (result == 0)
            {
                Console.WriteLine("invalid entry should be != 0;");
                result = EquationAValidatorEntry();
            }
            return result;
        }

        //the equation calculator method
        static decimal EquationCalculator()
        {
            decimal resultX = 0;
            Console.WriteLine("Enter multiplier for : a * x");
            decimal a = EquationAValidatorEntry();
            Console.Write("b = ");
            decimal b = decimal.Parse(Console.ReadLine());
            //solve eqution a*x + b = 0
            resultX = (-b) / a;
            return resultX;
        }

        //main part of program
        static void Main()
        {
            Console.WriteLine("Welcome to the program!");
            Console.WriteLine("If you wish to : ");
            Console.WriteLine("Reverse the digits of a number. Enter : 1");
            Console.WriteLine("Calculate the average of a sequence of integers. Enter : 2");
            Console.WriteLine("Solve a linear equation a * x + b = 0. Enter : 3");
            Console.WriteLine();
            int programEntry = MainEntryInput();

            //holder of result from the different methods they will be decimal so we need 1 holder
            decimal resultHolder;

            if (programEntry == 1)
            {
                resultHolder = ReverseEntryValidator();
                resultHolder = ReverseNumberDigits(resultHolder);
                Console.WriteLine("Reversed number is : {0};",resultHolder);
            }
            else if (programEntry == 2)
            {
                resultHolder = AvarageOfSequence();
                Console.WriteLine("Avarage from the numbers chosen is : {0};", resultHolder);
            }
            else
            {
                Console.WriteLine("You entered the equation a * x + b = 0 ");
                resultHolder = EquationCalculator();
                Console.WriteLine("X = {0};", resultHolder);
            }

        }
    }
}
