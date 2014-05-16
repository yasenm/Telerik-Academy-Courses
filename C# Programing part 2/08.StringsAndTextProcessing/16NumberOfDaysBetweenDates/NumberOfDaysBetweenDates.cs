// Write a program that reads two dates in the format: day.month.year and
// calculates the number of days between them. Example:

// Enter the first date: 27.02.2006
// Enter the second date: 3.03.2004
// Distance: 4 days

namespace _16NumberOfDaysBetweenDates
{
    using System;
    using System.Collections.Generic;

    public class NumberOfDaysBetweenDates
    {
        // method that makes string into a date to be used
        private static DateTime MakeStringToDate(string strDate) 
        {
            string[] splitedStr = strDate.Split(new char[] {'.'});
            DateTime date = new DateTime(int.Parse(splitedStr[2]), int.Parse(splitedStr[1]), int.Parse(splitedStr[0]));
            return date;
        }

        public static void Main()
        {
            Console.WriteLine("Enter date format : dd.mm.yyyy;");
            Console.Write("Enter first date : ");
            string firstDate = Console.ReadLine();
            Console.Write("Enter second date : ");
            string secondDate = Console.ReadLine();
            DateTime date1 = MakeStringToDate(firstDate);
            DateTime date2 = MakeStringToDate(secondDate);

            Console.WriteLine((date1 - date2).Days);
        }
    }
}
