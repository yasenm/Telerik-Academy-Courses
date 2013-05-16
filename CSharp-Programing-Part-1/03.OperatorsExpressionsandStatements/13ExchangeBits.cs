using System;

//Write a program that exchanges bits 3, 4 and 5 
//with bits 24, 25 and 26 of given 32-bit unsigned integer.

class ExchangeBits
{
    static void Main()
    {
        Console.WriteLine("Enter number to modify : ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Bitwise representation of number is : {0}", Convert.ToString(number, 2).PadLeft(32, '0'));
        int firstposition = 3;
        int secondposition = 24;
        int countofpos = 6;
        int mask = 1;

        // variables for the bits on the positions found
        int bitOnFirstPos = 0;
        int bitOnSecondPos = 0;
        // temporary container
        int temp = 0;
        // loop to check the positions and if the bits are equale leave them in their current state
        // else change values
        while (firstposition < countofpos)
        {
            bitOnFirstPos = number & (mask << firstposition);        // a sequence to find the bit on the positions asked.
            bitOnFirstPos = bitOnFirstPos >> firstposition;
            bitOnSecondPos = number & (mask << secondposition);
            bitOnSecondPos = bitOnSecondPos >> secondposition;
            // exchange values between positions usint temp as a temporary value holder
            temp = bitOnFirstPos;
            bitOnFirstPos = bitOnSecondPos;
            bitOnSecondPos = temp;
            //check if the two bits we want to swap are diferent
            if (bitOnFirstPos != bitOnSecondPos)
            {
                if (bitOnFirstPos == 1)
                {
                    bitOnSecondPos = bitOnFirstPos;
                    number = number | (bitOnFirstPos << firstposition);
                    number = number & ~(bitOnSecondPos << secondposition);
                }
                else
                {
                    bitOnFirstPos = bitOnSecondPos;
                    number = number & ~(bitOnFirstPos << firstposition);
                    number = number | (bitOnSecondPos << secondposition);
                }
            }
            else
            {

            }
            firstposition++;
            secondposition++;
        }
        Console.WriteLine(number);
        Console.WriteLine("Bitwise new representation of number is : {0}", Convert.ToString(number, 2).PadLeft(32, '0'));
    }
}
