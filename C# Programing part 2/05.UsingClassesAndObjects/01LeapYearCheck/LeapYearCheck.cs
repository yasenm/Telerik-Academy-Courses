using System;
using System.Timers;

//Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.

namespace _01LeapYearCheck
{
    public class LeapYearCheck
    {
        static void Main()
        {
            //input section
            Console.Write("Enter year and check if it is a leap one : ");
            int year = int.Parse(Console.ReadLine());
            var leapYear = new DateTime(year,1,1);

            //check for leap year
            Console.WriteLine("Is {0} a leap year? {1}",year, DateTime.IsLeapYear(leapYear.Year));
        }
    }
}
