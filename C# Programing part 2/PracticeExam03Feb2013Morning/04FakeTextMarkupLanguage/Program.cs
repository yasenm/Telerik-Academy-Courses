namespace _04FakeTextMarkupLanguage
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static string ReverseString(string str) 
        {
            string result = string.Empty;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                result += str[i];
            }
            return result;
        }

        static string ToggleMethod(string str) 
        {
            string result = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].ToString().ToLower() == str[i].ToString())
                {
                    result += str[i].ToString().ToUpper();
                }
                else
                {
                    result += str[i].ToString().ToLower();
                }
            }
            return result;
        }

        static string ReformatBetweenTags(string text)
        {
            string[] tagArr = new string[] { "<upper>", "<lower>", "<toggle>", "<del>", "<rev>" };
            string result = string.Empty;
            int firstIndex = text.IndexOf("<", 1);
            int secondIndex = text.IndexOf("</", 1);
            if (firstIndex == secondIndex)
            {
                for (int i = 0; i < tagArr.Length; i++)
                {
                    if (text.IndexOf(tagArr[i]) >= 0)
                    {
                        switch (i)
                        {
                            case 0: result = text.Substring(tagArr[i].Length, text.Length - (2 * tagArr[i].Length) - 1).ToUpper(); break;
                            case 1: result = text.Substring(tagArr[i].Length, text.Length - (2 * tagArr[i].Length) - 1).ToLower(); break;
                            case 2: result = ToggleMethod(text.Substring(tagArr[i].Length, text.Length - (2 * tagArr[i].Length) - 1)); break;
                            case 3: result = " "; break;
                            case 4: result = ReverseString(text.Substring(tagArr[i].Length, text.Length - (2 * tagArr[i].Length) - 1)); break;
                            default:
                                break;
                        }
                        break;
                    }
                }
            }
            else
            {
                string newInput = text.Substring(text.IndexOf('>') + 1, text.LastIndexOf("</") - text.IndexOf('>') - 1);
                result = text.Substring(0, text.IndexOf('<')) + ReformatBetweenTags(newInput.Substring(text.IndexOf('>') + 1, newInput.LastIndexOf("</") - 1 - newInput.IndexOf('>'))) + newInput.Substring(newInput.LastIndexOf(">"), newInput.LastIndexOf(">") - newInput.Length);
            }
            return result;
        }

        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            List<string> textlist = new List<string>();
            for (int i = 0; i < N; i++)
            {
                textlist.Add(Console.ReadLine());
            }

            for (int i = 0; i < textlist.Count; i++)
            {
                int firstIndex = textlist[i].IndexOf('<');
                if (firstIndex >= 0)
                {
                    textlist[i] = ReformatBetweenTags(textlist[i]);
                    Console.WriteLine(textlist[i]);
                }
            }
        }
    }
}
