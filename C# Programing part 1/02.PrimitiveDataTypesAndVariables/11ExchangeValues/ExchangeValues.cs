using System;

//Declare  two integer variables and assign them
//with 5 and 10 and after that exchange their values.


class ExchangeValues
{
    static void Main()
    {
        int firstNum = 5;
        int secondNum = 10;
        int temp = 0;
        Console.WriteLine("firstNum = {0} and secondNum = {1}", firstNum, secondNum);
        temp = firstNum;
        firstNum = secondNum;
        secondNum = temp;
        Console.WriteLine("After assigning new values...");
        Console.WriteLine("firstNum = {0} and secondNum = {1}", firstNum, secondNum);
    }
}
