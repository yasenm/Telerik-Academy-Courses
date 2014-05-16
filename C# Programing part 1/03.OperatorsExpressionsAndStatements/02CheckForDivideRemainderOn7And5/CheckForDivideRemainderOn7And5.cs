using System;

//Write a boolean expression that checks for given integer if it 
//can be divided (without remainder) by 7 and 5 in the same time.

class CheckForDivideRemainderOn7And5
{
    static void Main()
    {
        Console.WriteLine("Enter a number : ");
        int number = int.Parse(Console.ReadLine());
        bool check = ( (number % 7 == 0) && (number % 5 == 0) );
        Console.WriteLine(check ? "Number is divisible without by 7 and 5!" : "Number is not divisible without by 7 and 5!");
    }
}
