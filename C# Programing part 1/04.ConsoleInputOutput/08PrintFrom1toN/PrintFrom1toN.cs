﻿using System;

//Write a program that reads an integer number n from the console and prints
//all the numbers in the interval [1..n], each on a single line.

class PrintFrom1toN
{
    static void Main()
    {
        Console.WriteLine("See numbers from 1 to 'n'.");
        Console.Write("Enter value for 'n' : ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}