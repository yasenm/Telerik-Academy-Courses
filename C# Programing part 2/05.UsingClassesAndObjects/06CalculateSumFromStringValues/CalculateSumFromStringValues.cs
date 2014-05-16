using System;

//You are given a sequence of positive integer values written into a string,
//separated by spaces. Write a function that reads these values from given
//string and calculates their sum.
//Example:
//        string = "43 68 9 23 318"  result = 461

namespace _06CalculateSumFromStringValues
{
    class CalculateSumFromStringValues
    {
        //method that will calculate the sum from the string sequence put as argument to the same method
        static int CalculateValuesFromString(string intStr) 
        {
            //split the string by empty spaces and make array out of it, after that just parse the members
            //of the splited array and add them to the result
            string[] strInts = intStr.Split(' ');
            int result = 0;
            foreach (var member in strInts)
            {
                result += int.Parse(member);
            }
            return result;
        }

        static void Main()
        {
            //input part of exercise
            Console.WriteLine("Enter string with int values separated by spaces");
            string inputValues = Console.ReadLine();

            Console.WriteLine("Sum from the string is {0}",CalculateValuesFromString(inputValues));
        }
    }
}
