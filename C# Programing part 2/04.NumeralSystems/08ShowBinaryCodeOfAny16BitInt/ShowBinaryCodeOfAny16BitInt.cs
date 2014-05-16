using System;
using System.Collections.Generic;
using System.Collections;

namespace _08ShowBinaryCodeOfAny16BitInt
{
    class ShowBinaryCodeOfAny16BitInt
    {
        static void Main()
        {
            //input the wanted number
            Console.Write("Enter signed 16bit number : ");
            int decimalNumber = int.Parse(Console.ReadLine());
            string binaryResult = "";

            //set a remainder that will hold either the 1 or 0 component
            int remainder;

            // make a list that will keep the found bits
            List<int> binaryNumber = new List<int>();

            if (decimalNumber >= 0)
            {
                //a loop that adds the bits and then checks again with the new value for the number
                //devided by 2
                while (decimalNumber > 0)
                {
                    remainder = decimalNumber % 2;
                    decimalNumber /= 2;
                    binaryNumber.Add(remainder);
                }

                //reversing the list to get the apropriete bit epresentation
                binaryNumber.Reverse();

                //save value in string
                for (int i = 0; i < binaryNumber.Count; i++)
                {
                    binaryResult += binaryNumber[i];
                }

                //padleft with 0 to 16 bits sinse its >= 0
                binaryResult = binaryResult.PadLeft(16,'0');
            }
            else
            {
                //if the number is negative we make it positive - 1 so we can work with it
                decimalNumber = Math.Abs(decimalNumber) - 1;

                //same algorithm basicly with a few changes
                while (decimalNumber > 0)
                {
                    remainder = decimalNumber % 2;
                    decimalNumber /= 2;
                    binaryNumber.Add(remainder);
                }

                //reversing the list to get the apropriete bit epresentation
                binaryNumber.Reverse();

                //after we found out the primal bit representation for it to be corect we have 
                //change the 0's to 1's and the 1's to 0's sinse thats the nature of the negative numbers bit representation
                for (int i = 0; i < binaryNumber.Count; i++)
                {
                    if (binaryNumber[i] == 0)
                    {
                        binaryNumber[i] = 1;
                    }
                    else
                    {
                        binaryNumber[i] = 0;
                    }
                }

                //save value in string
                for (int i = 0; i < binaryNumber.Count; i++)
                {
                    binaryResult += binaryNumber[i];
                }

                //padleft with 1 to 16 bits since its < 0
                binaryResult = binaryResult.PadLeft(16, '1');
            }

            //print the binary representation
            Console.Write("Binary the number is : {0}", binaryResult);
            Console.WriteLine();
        }
    }
}
