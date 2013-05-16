using System;

//Declare five variables choosing for each of
//them the most appropriate of the types byte,
//sbyte, short, ushort, int, uint, long, ulong
//to represent the following values: 52130, -115,
//4825932, 97, -10000.


class DeclareFiveVariables
{
    static void Main()
    {
        ushort number1 = 52130;
        sbyte number2 = -115;
        int number3 = 4825932;
        byte number4 = 97;
        short number5 = -10000;
        Console.WriteLine("ushort = {0}\nsbyte = {1}\nint = {2}\nbyte = {3}\nshort = {4}", number1, number2, number3, number4, number5);
    }
}
