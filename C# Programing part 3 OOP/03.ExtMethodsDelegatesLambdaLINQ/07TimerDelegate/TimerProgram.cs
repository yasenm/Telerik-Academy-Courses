// Exercise 07 : Using delegates write a class Timer that has can execute certain method at each t seconds.

namespace _07TimerDelegate
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class TimerProgram
    {
        // Timer and the methods are in the folder TimerClass in the .cs file
        static void Main()
        {
            var methods = new Timer.TheDelegate(Timer.PrintFourRandomNumbers);
            methods += Timer.PrintCurrentDateAndTime;
            methods += Timer.TelerikLogo;
            methods();
        }

    }
}
