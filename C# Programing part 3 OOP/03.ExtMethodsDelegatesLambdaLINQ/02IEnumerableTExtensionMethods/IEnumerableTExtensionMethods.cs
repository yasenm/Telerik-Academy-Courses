// Exercise 02 : Implement a set of extension methods for IEnumerable<T> that implement
// the following group functions: sum, product, min, max, average.

namespace _02IEnumerableTExtensionMethods
{
    using System;
    using System.Collections.Generic;

    class IEnumerableTExtensionMethods
    {
        // All extenssions are in the folder ExtensionsIEnum in the .cs file
        static void Main()
        {
            Console.WriteLine("Test with ints : ");
            List<double> someList = new List<double>();
            someList.Add(3);
            someList.Add(3);
            someList.Add(3);
            someList.Add(8);
            someList.Add(8);
            someList.Add(3);
            someList.Add(5);
            someList.Add(3);
            someList.Add(3);
            someList.Add(1);
            someList.Add(2);
            Console.WriteLine("Sum : {0};", someList.Sum<double>());
            Console.WriteLine("Product : {0};", someList.Product<double>());
            Console.WriteLine("Min member : {0};", someList.Min<double>());
            Console.WriteLine("Max member : {0};", someList.Max<double>());
            Console.WriteLine("Avarage : {0};", someList.Avarage<double>());

            Console.WriteLine();
            Console.WriteLine("Test with strings : ");
            List<string> someStringList = new List<string>();
            someStringList.Add("Pesho");
            someStringList.Add("Gosho");
            someStringList.Add("Marijka");
            someStringList.Add("Haralampi");
            Console.WriteLine(someStringList.Sum<string>());
        }
    }
}
