using System;

//Write a method GetMax() with two parameters that returns the bigger
//of two integers. Write a program that reads 3 integers from the 
//console and prints the biggest of them using the method GetMax().

namespace _02GetMaxMethod
{
    class GetMaxMethod
    {
        static int GetMax(int lower, int higher)
        {
            if (lower < higher)
            {
                lower = higher;
            }
            return lower;
        }
        static void Main()
        {
            Console.Write("Enter first int = ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Enter second int = ");
            int second = int.Parse(Console.ReadLine());
            Console.Write("Enter thirt int = ");
            int thirt = int.Parse(Console.ReadLine());
            int maxOfTwo = GetMax(first,second);
            int result = GetMax(maxOfTwo,thirt);
            Console.WriteLine("The biggest one is : {0}",result);
        }
    }
}
