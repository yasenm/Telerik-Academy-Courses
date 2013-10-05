namespace MobileDevices.Common
{
    using System;

    // class for the battery characteristics 
    public class Battery
    {
        // string for model that has getter and setter as all other properties of the defined classes for the exercise it is etc. for the other properties as hours idle and hours talk
        private string model;

        // encapsulated
        public string Model
        {
          get { return this.model; }
          set 
          {
              if (String.IsNullOrEmpty(value))
              {
                  throw new ArgumentException("Invalid battery model!");
              }
              this.model = value;
          }
        }

        private int hoursIdle;

        // encapsulated
        public int HoursIdle
        {
            get { return this.hoursIdle; }
            set { this.hoursIdle = value; }
        }

        private int hoursTalk;

        // encapsulated
        public int HoursTalk
        {
            get { return this.hoursTalk; }
            set { this.hoursTalk = value; }
        }

        // added BatteryType from exercise 03
        public BatteryType batType;

        public Battery(BatteryType batType) 
        {
            this.batType = batType;
        }

        public BatteryType BatType 
        {
            get { return this.batType; }
        }
    }
}
