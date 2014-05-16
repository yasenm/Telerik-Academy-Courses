namespace _03Tron3D
{
    using System;

    class Tron3D
    {
        static void Main()
        {
            DateTime old = DateTime.Now;
            TimeSpan duration = old.Subtract(DateTime.Now);
            Console.WriteLine(duration);
        }
    }
}
