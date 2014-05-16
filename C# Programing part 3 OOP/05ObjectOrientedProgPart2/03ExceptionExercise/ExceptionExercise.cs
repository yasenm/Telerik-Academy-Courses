// Exercise 03 : Define a class InvalidRangeException<T> that holds information about an
// error condition related to invalid range. It should hold error message
// and a range definition [start … end].

// Write a sample application that demonstrates the InvalidRangeException<int>
// and InvalidRangeException<DateTime> by entering numbers in the range [1..100]
// and dates in the range [1.1.1980 … 31.12.2013].

namespace _03ExceptionExercise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ExceptionExercise
    {
        static void Main()
        {
            Console.WriteLine("Press 1 to check number press 2 to check date!");
            int userChoice = UserChoice();
            if (userChoice == 1)
            {
                ChoosingInt();
            }
            else if (userChoice == 2)
            {
                ChoosingDate();
            }
            else
            {
                throw new InvalidRangeException<int>("Invalid input choice please chose between 1 (for int check) and 2 (for date check)");
            }
        }

        public static int UserChoice() 
        {
            return int.Parse(Console.ReadLine());
        }

        public static void ChoosingInt() 
        {
            int choosedInt = int.Parse(Console.ReadLine());
            if (choosedInt <= 1 && choosedInt >= 100)
            {
                throw new InvalidRangeException<int>("You should enter integer between [1...100]");
            }
            else
            {
                Console.WriteLine("Integer {0} is correct!", choosedInt);
            }
        }

        public static void ChoosingDate() 
        {
            Console.WriteLine("Enter date in the format DD-MM-YYYY");
            string[] dateComponents = Console.ReadLine().Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
            DateTime enteredDate = new DateTime(int.Parse(dateComponents[2]), int.Parse(dateComponents[1]), int.Parse(dateComponents[0]));
            if (enteredDate < InvalidRangeException<DateTime>.OldestDateRelieble || enteredDate > InvalidRangeException<DateTime>.NewestDateRelieble )
            {
                throw new InvalidRangeException<DateTime>(String.Format("Invalid date chosen should be between [{0}...{1}]", InvalidRangeException<DateTime>.OldestDateRelieble, InvalidRangeException<DateTime>.NewestDateRelieble));
            }
            else
            {
                Console.WriteLine("Chosen date is valid!");
            }
        }
    }
}
