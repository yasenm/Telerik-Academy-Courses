// Exercise 07: Write a class GSMTest to test the GSM class:
//      - Create an array of few instances of the GSM class.
//      - Display the information about the GSMs in the array.
//      - Display the information about the static property IPhone4S.

namespace MobileDevices.Common
{
    using System;
    using System.Collections.Generic;

    public class GSMTest
    {
        public static void TestingMethod() 
        {
            GSM[] testDevices = new GSM[4];
            testDevices[0] = new GSM("Lumia", "Nokia", 230, "Koicho");
            testDevices[1] = new GSM("XPeria X10i", "Sony ericson", 1050, "Some other");
            testDevices[2] = new GSM("", "", 140, "");
            testDevices[3] = GSM.IPhone4S;

            for (int i = 0; i < testDevices.Length; i++)
            {
                Console.WriteLine(testDevices[i]);
            }
        }
    }
}
