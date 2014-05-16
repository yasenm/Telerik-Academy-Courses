using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02BunnyFactory
{
    class BunnyFactory
    {
        private static string GetResultFromSB(StringBuilder cages) 
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < cages.Length; i++)
            {
                result.Append(cages[i] + " ");
            }
            return result.ToString();
        }

        static void Main()
        {
            StringBuilder cagesWithBunnies = new StringBuilder();

            while (true)
            {
                var temp = Console.ReadLine();
                if (temp == "END")
                {
                    break;
                }
                cagesWithBunnies.Append(temp);
            }

            string result = string.Empty;

            int counter = 1;

            while (true)
            {
                int s = 0;

                if (counter >= cagesWithBunnies.Length)
                {
                    result = GetResultFromSB(cagesWithBunnies);
                    break;
                }

                for (int i = 0; i < counter; i++)
                {
                    s += int.Parse(cagesWithBunnies[i].ToString());
                }

                if (cagesWithBunnies.Length - counter < s)
                {
                    result = GetResultFromSB(cagesWithBunnies);
                    break;
                }

                int sum = 0;
                ulong product = 1;

                for (int i = 0; i < s; i++)
                {
                    sum += int.Parse(cagesWithBunnies[counter + i].ToString());
                    product *= ulong.Parse(cagesWithBunnies[counter + i].ToString());
                }

                cagesWithBunnies.Remove(0, counter + s);
                StringBuilder next = new StringBuilder();
                next.Append(sum);
                next.Append(product);

                cagesWithBunnies.Insert(0, next.ToString());
                for (int i = 0; i < cagesWithBunnies.Length; i++)
                {
                    if (cagesWithBunnies[i] == '1' || cagesWithBunnies[i] == '0')
                    {
                        cagesWithBunnies.Remove(i, 1);
                        i--;
                    }
                }
                counter++;
            }

            Console.WriteLine(result.Trim());

        }
    }
}
