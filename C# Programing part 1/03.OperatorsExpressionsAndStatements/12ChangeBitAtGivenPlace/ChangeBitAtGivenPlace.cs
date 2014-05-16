using System;

//We are given integer number n, value v (v=0 or 1) and a position p.
//Write a sequence of operators that modifies n to hold the value v at
//the position p from the binary representation of n.

//Examples: 
//n = 5 (00000101), p=3, v=1  13 (00001101)
//n = 5 (00000101), p=2, v=0  1 (00000001)

class ChangeBitAtGivenPlace
{
    static void Main()
    {
        Console.WriteLine("Enter number to modify : ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter position for bit to be modified : ");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter new falue for bit: ");
        int v = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        int result = 0;
        if ( v == 1 )
        {
            result = n | mask;
        }
        else if ( v == 0 )
        {
            result = n & ~mask;
        }
        else
        {
            Console.WriteLine("Wrong input for 'v'!");
        }
        Console.WriteLine(result);
    }
}
