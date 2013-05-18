using System;

//Write a program that gets a number n and after that gets
//more n numbers and calculates and prints their sum. 

class SumOfNumbersN
{
    static void Main()
    {
        Console.Write("Enter value for 'n'");
        int n = int.Parse(Console.ReadLine());
        double sum = 0; 
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter new number for sumary : ");
            double x = double.Parse(Console.ReadLine());
            sum += x;
            Console.WriteLine("Sum is {0}", sum);
        }
    }
}
