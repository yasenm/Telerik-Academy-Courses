using System;

//Write a method that returns the last digit of given integer as an 
//English word. Examples: 512  "two", 1024  "four", 12309  "nine".

namespace _03ReturnLastIntegerWord
{
    class ReturnLastIntegerWord
    {
        static string GetLastInteger(long argument)
        {
            long lastInt = argument % 10;
            string result;
            switch (lastInt)
            {
                case 0: result = "zero"; break;
                case 1: result = "one"; break;
                case 2: result = "two"; break;
                case 3: result = "three"; break;
                case 4: result = "four"; break;
                case 5: result = "five"; break;
                case 6: result = "six"; break;
                case 7: result = "seven"; break;
                case 8: result = "eight"; break;
                case 9: result = "nine"; break;
                default:
                    result = "default";
                    break;
            }
            return result;
        }
        static void Main()
        {
            Console.Write("Enter integer : ");
            long inputInt = long.Parse(Console.ReadLine());
            string lastIntString = GetLastInteger(inputInt);
            Console.WriteLine("Last int word is {0}",lastIntString);
        }
    }
}
