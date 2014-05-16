using System;

//Write a program that prints to the console which day of the week is today. Use System.DateTime.

namespace _03PrintDayWhichDayOfWeekItIS
{
    class PrintDayWhichDayOfWeekItIS
    {
        //static 

        static void Main()
        {
            Console.Write("Enter year : ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Chose month : ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Day of month : ");
            int date = int.Parse(Console.ReadLine());

            DateTime dt = new DateTime(year, month, date);
            Console.WriteLine("The day you've chosen was/it's gonna be {0}",dt.DayOfWeek);
            Console.WriteLine("Today is {0}",DateTime.Today.DayOfWeek);
        }
    }
}
