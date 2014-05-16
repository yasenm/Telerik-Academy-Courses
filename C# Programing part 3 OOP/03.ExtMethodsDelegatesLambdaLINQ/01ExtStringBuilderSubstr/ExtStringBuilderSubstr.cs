// Exercise 01 : Implement an extension method Substring(int index, int length) 
// for the class StringBuilder that returns new StringBuilder and has the same 
// functionality as Substring in the class String.

namespace _01ExtStringBuilderSubstr
{
    using System;
    using System.Linq;
    using System.Text;

    class ExtStringBuilderSubstr
    {
        // All extenssions are in the folder Extensions in the .cs file
        static void Main()
        {
            StringBuilder someText = new StringBuilder("There is some text in here!");
            Console.WriteLine("The text before Substring() : ");
            Console.WriteLine(someText);
            Console.WriteLine();

            for (int i = 0; i < someText.Length; i+=8)
            {
                Console.WriteLine("The text after Substring({0}) : ", i);
                Console.WriteLine(someText.Substring(i));
                Console.WriteLine();
            }

            Console.WriteLine("The text after Substring(4, 8) : ");
            Console.WriteLine(someText.Substring(4, 8));
            Console.WriteLine();
        }
    }
}
