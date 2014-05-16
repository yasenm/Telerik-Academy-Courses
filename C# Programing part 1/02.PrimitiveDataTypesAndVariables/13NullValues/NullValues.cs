using System;

//Create a program that assigns null values to an
//integer and to double variables. Try to print them
//on the console, try to add some values or the null
//literal to them and see the result

class NullValues
{
    static void Main()
    {
        int? variable1 = null;
        double? variable2 = null;
        Console.WriteLine("Result from int? is : {0} \nResult from double? is : {1}", variable1, variable2);
        Console.WriteLine(variable1 + 10);
        Console.WriteLine(variable2 + 15);
        Console.WriteLine(variable1 + null);
        Console.WriteLine(variable2 + null);
    }
}
