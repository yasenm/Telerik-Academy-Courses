using System;

//Write a program that, depending on the user's choice inputs 
//int, double or string variable. If the variable is integer or
//double, increases it with 1. If the variable is string, 
//appends "*" at its end. The program must show the value of 
//that variable as a console output. Use switch statement.

class CheckInput
{
    static void Main()
    {
        Console.Write("Enter variable : ");
        string str = Console.ReadLine();
        int newInt = 0;
        double newDouble = 0;
        bool resultInt = int.TryParse(str , out newInt);
        bool resultDouble = double.TryParse(str , out newDouble);
        if (resultDouble)
        {
            if (resultInt)
            {
                newInt = int.Parse(str);
                Console.WriteLine("Result is variable is type int");
                Console.WriteLine(newInt + 1);
            }
            else
            {
                newDouble = double.Parse(str);
                Console.WriteLine("Result is variable is type double");
                Console.WriteLine(newDouble + 1);
            }
        }
        else
        {
            Console.WriteLine("Input is string");
            Console.WriteLine(str + "*");
        }
    }
}
