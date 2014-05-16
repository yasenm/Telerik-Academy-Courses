using System;

//Write a method that asks the user for his name and prints “Hello, <name>”
//(for example, “Hello, Peter!”). Write a program to test this method.

namespace _01HelloName
{
    public class HelloName
    {
        public static string NameHello(string name)
        {
            name = "Hello " + name;
            return name;
        }
        static void Main()
        {
            Console.WriteLine("Enter a name : ");
            string name = Console.ReadLine();
            name = NameHello(name);
            Console.WriteLine(name                                                                           );
        }
    }
}
