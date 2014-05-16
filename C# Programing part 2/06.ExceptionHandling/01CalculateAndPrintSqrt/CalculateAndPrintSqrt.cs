using System;

//Write a program that reads an integer number and calculates and prints
//its square root. If the number is invalid or negative, print "Invalid number".
//In all cases finally print "Good bye". Use try-catch-finally.

namespace _01CalculateAndPrintSqrt
{
    class CalculateAndPrintSqrt
    {
        //method that calculates square root
        static double SquareRoot() 
        {
            Console.Write("Enter int for square root : ");
            int num = int.Parse(Console.ReadLine());
            if (num < 0)
            {
                throw new System.ArgumentOutOfRangeException("Invalid number.");
            }
            return Math.Sqrt(num);
        }

        static void Main()
        {
            try
            {
                Console.WriteLine("Sqrt is : {0}",SquareRoot());
            }
            catch (FormatException fe)
            {
                Console.Error.WriteLine("Format exeption caught. Parsing failed." + fe);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.Error.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
