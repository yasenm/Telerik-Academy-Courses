namespace MobileDevices.Common
{
    using System;

    // class define for display characteristics
    public class Display
    {
        // string for size and its constructor afterwards
        private string size;

        // encapsulated
        public string Size
        {
            get { return this.size; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid display size!");
                } 
                this.size = value;
            }
        }

        // public int for the number of colors of the display and its constructor afterwards
        private int numberOfColors;

        // encapsulated
        public int NumberOfColors
        {
            get { return this.numberOfColors; }
            set { this.numberOfColors = value; }
        }
    }
}
