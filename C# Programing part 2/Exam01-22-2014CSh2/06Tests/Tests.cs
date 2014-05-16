using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Tests
{
    class Tests
    {
        private static string GetResultFromSB(List<int> cages)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < cages.Count; i++)
            {
                result.Append(cages[i] + " ");
            }
            return result.ToString();
        }

        static void Main()
        {
            List<int> cagesWithBunnies = new List<int>();

            while (true)
            {
                var temp = Console.ReadLine();
                if (temp == "END")
                {
                    break;
                }
                cagesWithBunnies.Add(int.Parse(temp));
            }

            string result = string.Empty;

            int counter = 1;

            while (true)
            {
                int s = 0;

                if (counter >= cagesWithBunnies.Count)
                {
                    result = GetResultFromSB(cagesWithBunnies);
                    break;
                }

                for (int i = 0; i < counter; i++)
                {
                    s += int.Parse(cagesWithBunnies[i].ToString());
                }

                if (cagesWithBunnies.Count - counter < s)
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

                cagesWithBunnies.RemoveRange(0, counter + s);
                StringBuilder next = new StringBuilder();
                next.Append(sum);
                next.Append(product);

                for (int i = next.Length -1; i >= 0; i--)
                {
                    if (next[i] == '1' || next[i] == '0')
                    {
                        continue;
                    }
                    cagesWithBunnies.Insert(0, int.Parse(next[i].ToString()));
                }

                ReformatCages(cagesWithBunnies);

                counter++;

            }

            Console.WriteLine(result.Trim());

            
        }

        private static void ReformatCages(List<int> cagesWithBunnies)
        {
            StringBuilder cagesAndBunnies = new StringBuilder();

            for (int i = 0; i < cagesWithBunnies.Count; i++)
            {
                cagesAndBunnies.Append(cagesWithBunnies[i]);
            }

            cagesWithBunnies.Clear();

            for (int i = 0; i < cagesAndBunnies.Length; i++)
            {
                cagesWithBunnies.Add(int.Parse(cagesAndBunnies[i].ToString()));
            }
        }
    }
}
