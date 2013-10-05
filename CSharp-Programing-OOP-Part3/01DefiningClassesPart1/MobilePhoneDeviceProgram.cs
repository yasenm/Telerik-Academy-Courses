// Exercise 01: Define a class that holds information about a mobile phone device: model,
// manufacturer, price, owner, battery characteristics (model, hours idle and hours talk)
// and display characteristics (size and number of colors). Define 3 separate classes
// (class GSM holding instances of the classes Battery and Display).

// Exercise 02: Define several constructors for the defined classes that take different sets
// of arguments (the full information for the class or part of it). Assume that model and
// manufacturer are mandatory (the others are optional). All unknown data fill with null.

// Exercise 03: Add an enumeration BatteryType (Li-Ion, NiMH, NiCd, …) and use it
// as a new field for the batteries.

// Exercise 04: Add a method in the GSM class for displaying all information about it.
// Try to override ToString().

// Exercise 05: Use properties to encapsulate the data fields inside the GSM, Battery
// and Display classes. Ensure all fields hold correct data at any given time.

// Exercise 06: Add a static field and a property IPhone4S in the GSM class to hold the
// information about iPhone 4S.

// Exercise 07: Write a class GSMTest to test the GSM class:
//      - Create an array of few instances of the GSM class.
//      - Display the information about the GSMs in the array.
//      - Display the information about the static property IPhone4S.

// Exercise 08: Create a class Call to hold a call performed through a GSM. It should contain
// date, time, dialed phone number and duration (in seconds).

// Exercise 09: Add a property CallHistory in the GSM class to hold a list of the performed
// calls. Try to use the system class List<Call>.

// Exercise 10: Add methods in the GSM class for adding and deleting calls from the calls history.
// Add a method to clear the call history.

// Exercise 11: Add method that calculates the total price of the calls in the call history.
// Assume the price per minute is fixed and is provided as a parameter.

// Exercise 12 : Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.
//      -   Create an instance of the GSM class.
//      -   Add few calls.
//      -   Display the information about the calls.
//      -   Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
//      -   Remove the longest call from the history and calculate the total price again.
//      -   Finally clear the call history and print it

namespace _01MobilePhoneDevice
{
    using System;
    using MobileDevices.Common;
    using System.Collections.Generic;

    public class MobilePhoneDeviceProgram
    {
        private static void Main()
        {
            // mandatory model and manufacturer added for new GSM(model, manufacturer)
            GSM mobileDevice = new GSM("EXPERIA X10i", "Sony Ericson", 540, "Some guy");
            mobileDevice.Battery.Model = "3 cells";
            mobileDevice.Battery.HoursIdle = 84;
            mobileDevice.Battery.HoursTalk = 10;
            mobileDevice.Battery.batType = BatteryType.LiPoly;
            mobileDevice.Display.Size = "3.7'";
            mobileDevice.Display.NumberOfColors = 256000;


            // exercise 04 overriding ToString()
            Console.WriteLine(mobileDevice);
            GSMTest.TestingMethod();

            // exercise 12 part printing
            GSMCallHistoryTest.CallHistoryTest();
        }
    }
}
