using System;

//Write a program that exchanges bits {p, p+1, …, p+k-1) with 
//bits {q, q+1, …, q+k-1} of given 32-bit unsigned integer.

class ExchangeBitsByInputPositions
{
    static void Main()
    {
        Console.WriteLine("Enter number to modify : ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Bitwise representation of number is : {0}", Convert.ToString(number, 2).PadLeft(32, '0'));
        Console.WriteLine("Enter position of bit you would like to exchange 'p' :");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter position you would like to exchange bit with 'q' :");
        int q = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for sequence of bits to be exchanged 'k' :");
        int k = int.Parse(Console.ReadLine());
        int countOfPositionsToChange = p + k;
        int mask = 1;

        // variables for the bits on the positions found
        int bitOnFirstPos = 0;
        int bitOnSecondPos = 0;
        // temporary container
        int temp = 0;
        // loop to check the positions and if the bits are equale leave them in their current state
        // else change values
        while (p < countOfPositionsToChange)
        {
            bitOnFirstPos = number & (mask << p);        // a sequence to find the bit on the positions asked.
            bitOnFirstPos = bitOnFirstPos >> p;
            bitOnSecondPos = number & (mask << q);
            bitOnSecondPos = bitOnSecondPos >> q;
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
                    number = number | (bitOnFirstPos << p);
                    number = number & ~(bitOnSecondPos << q);
                }
                else
                {
                    bitOnFirstPos = bitOnSecondPos;
                    number = number & ~(bitOnFirstPos << p);
                    number = number | (bitOnSecondPos << q);
                }
            }
            else
            {

            }
            p++;
            q++;
        }
        Console.WriteLine(number);
        Console.WriteLine("Bitwise new representation of number is : {0}", Convert.ToString(number, 2).PadLeft(32, '0'));
    }
}

