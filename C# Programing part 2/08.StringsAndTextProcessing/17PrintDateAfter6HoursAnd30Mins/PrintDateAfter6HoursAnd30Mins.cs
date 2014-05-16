// Write a program that reads a date and time given in the format: 
// day.month.year
// hour:minute:second 
// and prints the date and time after 6 hours and 30 minutes (in the
// same format) along with the day of week in Bulgarian.

namespace _17PrintDateAfter6HoursAnd30Mins
{
    using System;
    using System.Collections.Generic;

    public class PrintDateAfter6HoursAnd30Mins
    {
        public static DateTime MakeInputIntoDate(string date, string time) 
        {
            char[] spliters = new char[] {'.', ';', ',', ':' };
            string[] dateParams = date.Split(spliters);
            string[] timeParams = time.Split(spliters);
            DateTime dateTime = new DateTime(int.Parse(dateParams[2]), int.Parse(dateParams[1]), int.Parse(dateParams[0]), int.Parse(timeParams[0]), int.Parse(timeParams[1]), int.Parse(timeParams[2]));
            return dateTime;
        }

        public static string DayInBulgarian(DateTime date) 
        {
            string result = string.Empty;
            string day = date.DayOfWeek + string.Empty;
            switch (day)
            {
                case "Monday": result = "Понеделник"; break;
                case "Tuesday": result = "Вторник"; break;
                case "Wednesday": result = "Сряда"; break;
                case "Thursday": result = "Четвъртък"; break;
                case "Friday": result = "Петък"; break;
                case "Saturday": result = "Събота"; break;
                case "Sunday": result = "Неделя"; break;
                default: result = string.Empty;
                    break;
            }
            return result;
        }

        public static void Main()
        {
            Console.WriteLine("Enter date format : dd.mm.yyyy; Enter hour format : hour:minutes:seconds;");
            Console.Write("Enter first date : ");
            string date = Console.ReadLine();
            Console.Write("Enter time : ");
            string time = Console.ReadLine();
            DateTime theDate = MakeInputIntoDate(date, time);
            Console.WriteLine(theDate);
            theDate = theDate.AddHours(6).AddMinutes(30);
            Console.WriteLine(theDate);
            Console.WriteLine(DayInBulgarian(theDate));
        }
    }
}
