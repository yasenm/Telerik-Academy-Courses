namespace MobileDevices.Common
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class GSM
    {
        // model
        private string model;

        // Manufacturer
        private string manufacturer;

        // price
        private decimal price;

        // owner
        private string owner;

        // added constructor for exercise 02 as model and manufacturer are mandatory for it adding more constructors will only make more arguments to put in at initializing the new GSM type
        public GSM(string model, string manufacturer, decimal price, string owner)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
        }

        // encapsulated
        public string Model
        {
            get { return this.model; }
        }

        // encapsulated
        public string Manufacturer
        {
            get { return this.manufacturer; }
        }

        // encapsulated
        public decimal Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        // encapsulated
        public string Owner
        {
            get { return this.owner; }
            set 
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid owner name!");
                }
                this.owner = value;
            }
        }

        // TODO: battery characteristics (model, hours idle and hours talk)
        public Battery Battery = new Battery(BatteryType.Lilon);

        // display characteristics (size and number of colors)
        public Display Display = new Display();

        #region Exercise 06 : IPhone4S
        // Iphone static field
        private static GSM iPhone4S = new GSM("IPhone4S", "Apple", 500, "Apple guy");

        // IPhone information
        public static GSM IPhone4S 
        {
            get 
            {
                return iPhone4S;
            }
        }
        #endregion

        #region Exercises 09 and 10 : CallHistory
        // callHistory
        private List<Call> callHistory = new List<Call>();

        public List<Call> CallHistory
        {
            get { return this.callHistory; }
        }

        // add a call
        public void AddCall(Call call) 
        {
            this.callHistory.Add(call);
        }

        // remove call by index and off call in history
        public void RemoveCall(int callIndex) 
        {
            this.callHistory.RemoveAt(callIndex);
        }

        // remove longest call method
        public void RemoveLongestCall()
        {
            int index = 0;
            int longestUntillNow = int.MinValue;
            for (int i = 0; i < callHistory.Count; i++)
            {
                if (callHistory[i].Duration > longestUntillNow)
                {
                    longestUntillNow = callHistory[i].Duration;
                    index = i;
                }
            }
            RemoveCall(index);
        }

        // clear call history
        public void ClearCallHistory() 
        {
            this.callHistory.Clear();
        }

        // print call history
        public void PrintCallHistory() 
        {
            if (callHistory.Count == 0)
            {
                Console.WriteLine("Call history is empty!");
            }
            else
            {
                for (int i = 0; i < callHistory.Count; i++)
                {
                    Console.WriteLine("Call :{0}; Date of call : {1}; Time : {2};\n Number dialed : {3}; Duration of call : {4}", i, callHistory[i].Date, callHistory[i].Time, callHistory[i].Number, callHistory[i].Duration);
                }
            }
        }
        #endregion

        public decimal GetTheBill() 
        {
            decimal pricePerMinute = 0.37m;
            decimal totalBill = 0;
            for (int i = 0; i < callHistory.Count; i++)
            {
                if (callHistory[i].Duration % 60 == 0)
                {
                    totalBill += (callHistory[i].Duration / 60) * pricePerMinute;
                }
                else
                {
                    totalBill += (callHistory[i].Duration / 60) * pricePerMinute + pricePerMinute;
                }
            }
            Console.WriteLine("The total bill is : {0,10}$;", totalBill);
            return totalBill;
        }

        // exercise 04 : overriding ToString() method
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(String.Format("*  {0} -\n","GSM Characteristics"));
            result.Append(String.Format("|{0} : {1,15};\n", "GSM Model".PadRight(20, ' '), this.model));
            result.Append(String.Format("|{0} : {1,15};\n", "Manufacturer".PadRight(20, ' '), this.manufacturer));
            result.Append(String.Format("|{0} : {1,14}$;\n", "Price".PadRight(20, ' '), this.price));
            result.Append(String.Format("|{0} : {1,15};\n", "Owner".PadRight(20, ' '), this.owner));
            result.Append(String.Format("\n*    {0} -\n","Battery characteristics"));
            result.Append(String.Format("|{0} : {1,15};\n", "Type".PadRight(20, ' '), this.Battery.BatType));
            result.Append(String.Format("|{0} : {1,15};\n", "Model".PadRight(20, ' '), this.Battery.Model));
            result.Append(String.Format("|{0} : {1,15};\n", "Hours idle".PadRight(20, ' '), this.Battery.HoursIdle));
            result.Append(String.Format("|{0} : {1,15};\n", "Hours talk".PadRight(20, ' '), this.Battery.HoursTalk));
            result.Append(String.Format("\n*    {0} -\n", "Display characteristics"));
            result.Append(String.Format("|{0} : {1,15};\n", "Size".PadRight(20, ' '), this.Display.Size));
            result.Append(String.Format("|{0} : {1,15};\n", "Number of colors".PadRight(20, ' '), this.Display.NumberOfColors));
            return result.ToString();
        }
    }
}
