using System;

//Write an expression that checks for given integer if its
//third digit (right-to-left) is 7. E. g. 1732  true

class CheckForThirthDigit
{
    static void Main()
    {
        Console.WriteLine("Enter a number : ");
        int number = int.Parse(Console.ReadLine());
        number = number / 100;
        Console.WriteLine((number % 10) == 7);
    }
}
