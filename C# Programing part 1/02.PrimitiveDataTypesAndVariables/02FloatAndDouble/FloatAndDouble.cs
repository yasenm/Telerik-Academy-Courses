using System;

//which of the following values can be assigned 
//to a variable of type float and which to a variable
//of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?


class FloatAndDouble
{
    static void Main()
    {
        float number1 = 12.345f;
        float number2 = 3456.091f;
        double number3 = 34.567839023;
        double number4 = 8923.1234857;
        Console.WriteLine("float should be used for {0} and {1} \ndouble should be used for {2} and {3} ", number1, number2, number3, number4);
    }
}
