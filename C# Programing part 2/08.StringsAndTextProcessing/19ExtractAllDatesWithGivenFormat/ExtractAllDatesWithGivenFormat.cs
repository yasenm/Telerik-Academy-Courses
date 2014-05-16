// Write a program that extracts from a given text all dates that match
// the format DD.MM.YYYY. Display them in the standard date format for Canada.

namespace _19ExtractAllDatesWithGivenFormat
{
    using System;
    using System.Text.RegularExpressions;

    class ExtractAllDatesWithGivenFormat
    {
        static void Main()
        {
            string text = "The date was 25.02.2013 and 1234.6342.12314 is not a date but 14.08.2014 will be next year";
            Console.WriteLine(text);
            Regex regex = new Regex(@"([0-9]{1,2}).([0-9]{1,2}).([0-9]{1,4})");
            MatchCollection allDates = regex.Matches(text);
            Console.WriteLine("Extracted dates are : ");
            foreach (var date in allDates)
            {
                Console.WriteLine(date);
            }
        }
    }
}
