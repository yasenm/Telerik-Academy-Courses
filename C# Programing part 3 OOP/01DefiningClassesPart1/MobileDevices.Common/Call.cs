// Create a class Call to hold a call performed through a GSM. It should contain
// date, time, dialed phone number and duration (in seconds).

namespace MobileDevices.Common
{
    using System;
using System.Text;

    public class Call
    {
        // property to be added the number to call
        private string number;

        private DateTime date;

        private TimeSpan time;

        private int duration;

        public Call(DateTime date, TimeSpan time, string number, int duration) 
        {
            this.date = date;
            this.time = time;
            this.number = number;
            this.duration = duration;
        }

        // encapsulate all parameters with get{} so you can get to their values for next method 
        // for calculating price
        public string Number
        {
            get { return this.number; }
        }

        public DateTime Date
        {
            get { return date; }
        }

        public int Duration
        {
            get { return this.duration; }
        }

        public TimeSpan Time
        {
            get { return this.time; }
        }

    }
}
