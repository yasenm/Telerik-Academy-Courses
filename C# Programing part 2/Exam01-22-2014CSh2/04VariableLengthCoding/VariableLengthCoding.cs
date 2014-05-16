using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace _04VariableLengthCoding
{
    class VariableLengthCoding
    {
        static void Main()
        {
            //Console.WriteLine(8 - 13%8);

            // input part
            string[] encodedText = Console.ReadLine().Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);

            int tableLen = int.Parse(Console.ReadLine());

            List<string> table = new List<string>();
            for (int i = 0; i < tableLen; i++)
            {
                table.Add(Console.ReadLine());
            }

            // solving part
            // sort the occurances of chars
            Dictionary<int, string> newTable = new Dictionary<int, string>();
            for (int i = 0; i < table.Count; i++)
            {
                newTable.Add(int.Parse(table[i].Substring(1, table[i].Length - 1)), table[i][0].ToString());
            }
            var sortedDict = from entry in newTable
                             orderby entry.Key ascending
                             select entry;

            // get all the 1's and 0's
            StringBuilder message = new StringBuilder();
            for (int i = 0; i < encodedText.Length; i++)
            {
                message.Append(ConvertToBits(encodedText[i]));
            }
            string[] newMessage = message.ToString().Split(new char[]{'0'} , StringSplitOptions.RemoveEmptyEntries);

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < newTable.Count; i++)
            {
                for (int j = 0; j < newMessage.Length; j++)
                {
                    if (newMessage[j].Length - 1 == i)
                    {
                        newMessage[j] = sortedDict.ElementAt(i).Value;
                    }
                }
            }

            for (int i = 0; i < newMessage.Length; i++)
            {
                result.Append(newMessage[i]);
            }
            Console.WriteLine(result);
        }

        private static string ConvertToBits(string integer) 
        {
            int decimalNumber = int.Parse(integer);
            int remainder;
            StringBuilder result = new StringBuilder();

            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 2;
                decimalNumber /= 2;
                result.Insert(0,remainder);
            }
            
            return result.ToString().PadLeft(8,'0');
        }
    }
}
