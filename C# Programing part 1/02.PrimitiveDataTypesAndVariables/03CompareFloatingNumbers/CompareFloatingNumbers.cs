using System;

//Write a program that safely compares floating-point
//numbers with precision of 0.000001. Examples:
//(5.3 ; 6.01) -> false;  (5.00000001 ; 5.00000003) -> true


class CompareFloatingNumbers
{
    static void Main()
    {
        float number1 = 5.3f;
        float number2 = 6.01f;

        float number3 = 5.00000001f;
        float number4 = 5.00000003f;
        Console.WriteLine( number1 == number2 );
        Console.WriteLine( number3 == number4 );
    }
}
