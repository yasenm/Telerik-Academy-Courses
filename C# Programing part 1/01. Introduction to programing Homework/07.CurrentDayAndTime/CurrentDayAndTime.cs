using System;

class CurrentDayAndTime
{
    static void Main()
    {
        var date = DateTime.Now;
        Console.WriteLine(DateTime.Now);
        var afterDate = DateTime.Now;
        var time = afterDate - date;
        Console.WriteLine(time);
    }
}
