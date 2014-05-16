using System;
using System.Text;

class BracketsTask
{
    static StringBuilder sb = new StringBuilder();
    static string tabs;
    static int tabsCount = 0;
    static bool shouldPrintNewLine = false;
    static bool isFirstSymbol = true;

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        tabs = Console.ReadLine();

        for (int i = 0; i < n; i++)
        {
            string line = Console.ReadLine().Trim();

            HandleLine(line);
        }

        Console.WriteLine(sb);
    }

    private static void HandleLine(string line = "")
    {
        for (int i = 0; i < line.Length; i++)
        {
            char currentCharacter = line[i];

            if (shouldPrintNewLine && char.IsWhiteSpace(currentCharacter))
            {
                continue;
            }

            if (shouldPrintNewLine)
            {
                sb.AppendLine();
                shouldPrintNewLine = false;
                isFirstSymbol = true;

            }

            if (currentCharacter == '{')
            {
                if (!shouldPrintNewLine)
                {
                    if (!isFirstSymbol)
                    {
                        if (char.IsWhiteSpace(line[i - 1]))
                        {
                            sb.Remove(sb.Length - 1, 1);
                        }

                        sb.AppendLine();
                    }
                }

                AppendTabs();
                sb.Append(currentCharacter);
                tabsCount++;
                shouldPrintNewLine = true;
            }
            else if (currentCharacter == '}')
            {
                tabsCount--;
                if (!shouldPrintNewLine)
                {

                    if (!isFirstSymbol)
                    {
                        if (char.IsWhiteSpace(line[i - 1]))
                        {
                            sb.Remove(sb.Length - 1, 1);
                        }
                        sb.AppendLine();
                    }
                }
                AppendTabs();
                sb.Append(currentCharacter);
                shouldPrintNewLine = true;
            }
            else
            {
                if (isFirstSymbol)
                {
                    AppendTabs();
                }

                if (!(isFirstSymbol
                    && char.IsWhiteSpace(currentCharacter)))
                {
                    if (!(i < line.Length - 1 
                        && char.IsWhiteSpace(line[i]) 
                        && char.IsWhiteSpace(line[i + 1])))
                    {
                        sb.Append(currentCharacter);
                    }
                }

                isFirstSymbol = false;
            }
        }
        shouldPrintNewLine = true;
        isFirstSymbol = true;
    }

    private static void AppendTabs()
    {
        for (int i = 0; i < tabsCount; i++)
        {
            sb.Append(tabs);
        }
    }
}
