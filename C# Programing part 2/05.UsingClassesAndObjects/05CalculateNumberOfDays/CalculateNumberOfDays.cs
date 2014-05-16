using System;
using System.Collections.Generic;

//Write a method that calculates the number of workdays between today and given date,
//passed as parameter. Consider that workdays are all days from Monday to Friday
//except a fixed list of public holidays specified preliminary as array.

namespace _05CalculateNumberOfDays
{
    class CalculateNumberOfDays
    {
        //entered all fixed date bulgarian holidays as first int month second day of month
        static int[,] holidaysDates = new int[,] { { 1, 1 }, { 1, 2 }, { 3, 3 }, { 5, 1 }, { 5, 6 }, { 5, 24 }, { 9, 6 }, { 9, 22 }, { 11, 1 }, { 12, 24 }, { 12, 25 }, { 12, 26 } };

        //check if the day is indeed a holiday
        static bool CheckIfNotHoliday(DateTime day)
        {
            bool isntHoliday = true;
            for (int i = 0; i < holidaysDates.GetLength(0); i++)
            {
                //since we are actualising the start date we are actualising and its year thats why 
                //we use day.Year and int[,] array with fixed dates as ints for using them for every next
                //year passed as the check is goin throuout
                if (new DateTime(day.Year, holidaysDates[i, 0], holidaysDates[i, 1]) == day)
                {
                    isntHoliday = false;
                }
            }
            return isntHoliday;
        }

        //method that will count the working days
        static int CalculateWorkingDays(DateTime startDate, DateTime endDate) 
        {
            //counter that will hold the number of working days
            int numberOfWorkDaysInPeriod = 0;
            //counter that will hold all the days that we are through
            int numberOfDaysThrough = 0;
            //loop that will check every single day from startdate to enddate
            do
            {
                if (startDate.DayOfWeek != DayOfWeek.Saturday && startDate.DayOfWeek != DayOfWeek.Sunday && CheckIfNotHoliday(startDate))
                {
                    numberOfWorkDaysInPeriod++;
                }
                //we actualize the start date to be a next day
                numberOfDaysThrough++;
                startDate = startDate.AddDays(1);

            } while (startDate <= endDate);

            return numberOfWorkDaysInPeriod;
        }

        //input part for end date of sequence of working days
        static DateTime EnterAndValidateInputDate()
        {
            
            Console.Write("Enter year : ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Chose month : ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Day of month : ");
            int date = int.Parse(Console.ReadLine());

            DateTime endDate = new DateTime(year, month, date);
            if (endDate < DateTime.Today)
	        {
		        Console.WriteLine("Enter new date that is in future.");
                endDate = EnterAndValidateInputDate();
	        }
            return endDate;
        }

        static void Main()
        {
            Console.WriteLine("Enter end date to calculate all workdays from today to it.");
            Console.WriteLine("If you wish to enter more holidays enter the code and add them");
            DateTime endDate = EnterAndValidateInputDate();
            DateTime startDate = DateTime.Today;

            Console.WriteLine("{0} workind days from {1} to {2}",CalculateWorkingDays(startDate, endDate),startDate,endDate);
        }
    }
}
