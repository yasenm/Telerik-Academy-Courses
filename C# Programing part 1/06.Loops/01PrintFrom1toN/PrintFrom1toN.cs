using System;

//Write a program that prints all the numbers from 1 to N.

class PrintFrom1toN
{
    static void Main()
    {
        // making sure user puts correct type of data when asked
        string consoleInput;
        int n;
        do
        {
            Console.Write("N = ");
            consoleInput = Console.ReadLine();
        }
        while (!int.TryParse(consoleInput, out n) || n < 1);
        n = int.Parse(consoleInput);
        Console.Write("Number from 1 to N are : ");
        for (int i = 1; i <= n; i++)
        {
            Console.Write(i + ", ");
        }
        Console.WriteLine();
    }
}
