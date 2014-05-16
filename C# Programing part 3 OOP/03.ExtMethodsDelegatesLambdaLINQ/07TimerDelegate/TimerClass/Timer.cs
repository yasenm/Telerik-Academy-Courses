using System;
using System.Threading;

class Timer
{
    public delegate void TheDelegate();
    private const int timeInterval = 100;

    public static Random randomNumber = new Random();

    public static void PrintFourRandomNumbers()
    {
        Console.WriteLine("Method was executed in : {0}", DateTime.Now.TimeOfDay);
        Console.WriteLine("First method : print four random numbers between 1 and 100 : ");
        for (int i = 0; i < 4; i++)
        {
            Console.Write("{0,3}, ", randomNumber.Next(0, 101));
        }
        Thread.Sleep(timeInterval);
        Console.WriteLine("\n");
        
    }

    public static void PrintCurrentDateAndTime()
    {
        Console.WriteLine("Method was executed in : {0}", DateTime.Now.TimeOfDay);
        Console.WriteLine("Second method : print current date, time");
        Console.WriteLine("Date : {0};", DateTime.Now.Date);
        Console.WriteLine("Time : {0};\n", DateTime.Now.TimeOfDay);
        Thread.Sleep(timeInterval);
    }

    public static void TelerikLogo()
    {
        Console.WriteLine("Method was executed in : {0}", DateTime.Now.TimeOfDay);
        Console.WriteLine("Third method : printing telerik logo in console.");
        Console.WriteLine("..***...***.");
        Console.WriteLine(".**.**.**.**");
        Console.WriteLine(".....**.....");
        Console.WriteLine("...**..**...");
        Console.WriteLine("..**....**..");
        Console.WriteLine("...**..**...");
        Console.WriteLine(".....**.....");
        Console.WriteLine();
    }
}

