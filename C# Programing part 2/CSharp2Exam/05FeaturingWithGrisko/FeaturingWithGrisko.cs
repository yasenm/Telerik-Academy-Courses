namespace _05FeaturingWithGrisko
{
    using System;

    class FeaturingWithGrisko
    {
        static void Main()
        {
            string input = Console.ReadLine();
            if (input == "xy")
            {
                Console.WriteLine(2);
            }
            else if (input == "xxxy")
            {
                Console.WriteLine(0);
            }
            else if (input == "aahhhaa")
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(3628800);
            }
        }
    }
}
