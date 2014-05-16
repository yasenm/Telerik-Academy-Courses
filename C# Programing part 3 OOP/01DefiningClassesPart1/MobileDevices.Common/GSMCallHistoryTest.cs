// Exercise 12 : Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.
//      -   Create an instance of the GSM class.
//      -   Add few calls.
//      -   Display the information about the calls.
//      -   Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
//      -   Remove the longest call from the history and calculate the total price again.
//      -   Finally clear the call history and print it
namespace MobileDevices.Common
{
    using System;
    using System.Text;

    public class GSMCallHistoryTest
    {
        public static void CallHistoryTest()
        {
            GSM mobileDevice = new GSM("EXPERIA X10i", "Sony Ericson", 540, "Some guy");
            decimal theBill = 0;

            // add calls to device
            mobileDevice.AddCall(new Call(DateTime.Now.Date, DateTime.Now.TimeOfDay, "0888321654", 75));
            mobileDevice.AddCall(new Call(DateTime.Now.Date, DateTime.Now.TimeOfDay, "0888321123", 124));
            mobileDevice.AddCall(new Call(DateTime.Now.Date, DateTime.Now.TimeOfDay, "0888321665", 432));
            mobileDevice.AddCall(new Call(DateTime.Now.Date, DateTime.Now.TimeOfDay, "0888321684", 50));
            mobileDevice.PrintCallHistory();
            theBill = mobileDevice.GetTheBill();

            // remove longest call
            mobileDevice.RemoveLongestCall();
            mobileDevice.PrintCallHistory();
            theBill = mobileDevice.GetTheBill();

            // remove call from device by inserting call index
            mobileDevice.RemoveCall(0);
            mobileDevice.PrintCallHistory();
            theBill = mobileDevice.GetTheBill();

            // clear all calls
            mobileDevice.ClearCallHistory();
            mobileDevice.PrintCallHistory();
            theBill = mobileDevice.GetTheBill();
        }
    }
}
