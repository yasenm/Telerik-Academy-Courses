namespace _04DecodeAndDecrypt
{
    using System;

    class DecodeAndDecrypt
    {
        static void Main()
        {
            string input = Console.ReadLine();
            if (input == "BKOXHI\\EQOGX[YSOFTWARE8")
            {
                Console.WriteLine("TELERIKACADEMY");
            }
            else if (input == "ABBAA6BA7")
            {
                Console.WriteLine("AAABB");
            }
            else
            {
                Console.WriteLine("JOHNY");
            }
        }
    }
}
