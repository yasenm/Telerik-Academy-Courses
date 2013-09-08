namespace _03Brackets
{
    using System;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string tabAdder = Console.ReadLine();
            string tab = string.Empty;
            string textContent = string.Empty;
            for (int i = 0; i < N; i++)
            {
                textContent += Console.ReadLine();
            }
            textContent = Regex.Replace(textContent, " {2,}", " ");
            textContent = textContent.Replace("}", "\n}\n");
            textContent = textContent.Replace("{", "\n{\n");
            textContent = textContent.Replace("=", "\n=");

            string[] lines = textContent.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i] == "}")
                {
                    tab = tab.Substring(0, tab.Length - tabAdder.Length);
                }
                Console.WriteLine("{0}{1}", tab, lines[i].Trim());
                if (lines[i] == "{")
                {
                    tab += tabAdder;
                }
            }
        }
    }
}
