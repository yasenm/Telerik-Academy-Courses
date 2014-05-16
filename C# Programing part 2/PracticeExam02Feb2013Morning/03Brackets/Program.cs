namespace _03Brackets
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());
            string taber = Console.ReadLine();
            int tabTimes = 0;
            string theCode = string.Empty;
            for (int i = 0; i < N; i++)
            {
                theCode += Console.ReadLine() + "\n";
            }
            Regex regex = new Regex(@"\s( )+");
            theCode = regex.Replace(theCode, " ");

            string tab = string.Empty;
            int startIndex = 0;
            StringBuilder formatedCode = new StringBuilder();

            for (int i = 0; i < theCode.Length; i++)
            {
                if (theCode[i] == '{')
                {
                    if (i > 0)
                    {
                        formatedCode.Append(tab + theCode.Substring(startIndex, i - 1).Replace("\n", string.Empty) + "\n");
                    }
                    formatedCode.Append(tab + '{' + "\n");
                    i++;
                    tabTimes++;
                    tab += taber;
                    startIndex = i;
                }
                else if (theCode[i] == '}')
                {
                    bool alreadyClosed = false;
                    if (theCode.Substring(startIndex, theCode.Length - i) == "\n}\n}")
                    {
                        alreadyClosed = true;
                        tabTimes--;
                        tab = tab.Substring(0, tabTimes * taber.Length);
                    }
                    if (theCode.Substring(startIndex,theCode.Length - i - 1).Replace("\n",string.Empty) != string.Empty)
                    {
                        formatedCode.Append(tab + theCode.Substring(startIndex,theCode.Length - i - 1).Replace("\n",string.Empty) + "\n");
                    }
                    if (!alreadyClosed)
                    {
                        formatedCode.Append(tab + '}' + "\n"); 
                    }
                    i++;
                    tabTimes--;
                    if (tabTimes >= 0)
                    {
                        tab = tab.Substring(0, tabTimes * taber.Length);
                    }
                    else
                    {
                        tabTimes = 0;
                        tab = string.Empty;
                    }
                    startIndex = i;
                }
                else if (theCode[i] == ';' && tabTimes > 0)
                {
                    formatedCode.Append(tab + taber + ';' + "\n");
                }
            }

            Console.WriteLine(formatedCode);
        }
    }
}
