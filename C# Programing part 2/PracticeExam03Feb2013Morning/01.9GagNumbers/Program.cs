namespace _01._9GagNumbers
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            string inputValue = Console.ReadLine();

            string[] gagSymbols = new string[] {"-!", "**", "!!!", "&&", "&-", "!-", "*!!!", "&*!", "!!**!-"};
            string nineNumber = string.Empty;
            //List<string> resultList = new List<string>();
            int newStartIndex = 0;
            while (newStartIndex < inputValue.Length - 2)
	        {
                for (int i = 0; i < gagSymbols.Length; i++)
			    {
                    int startIndex = inputValue.IndexOf(gagSymbols[i]);
                    if (startIndex == newStartIndex)
                    {
                        nineNumber += i;
                        newStartIndex = startIndex + gagSymbols[i].Length;
                        break;
                    }
                }
	        }
            Console.WriteLine(nineNumber);


        }
    }
}
