using System;

//Write an expression that extracts from a given integer i the
//value of a given bit number b. Example: i=5; b=2  value=1.

class GetBitValue
{
    static void Main()
    {
        Console.WriteLine("Enter position for bit to be checked : ");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number to examinate : ");
        int i = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        int result = i & mask;
        result = result >> p;
        Console.WriteLine(result);
    }
}
