// Exercise 08 : * Read in MSDN about the keyword event in C# and how
// to publish events. Re-implement the above using .NET events and 
// following the best practices.

namespace _08EventExercise
{
    using System;

    class EventExercise
    {
        static void Main()
        {
            Timer someTimer = new Timer();
            Listener theListener = new Listener();
            theListener.Subscribe(someTimer);

            someTimer.Start();
        }
    }
}
