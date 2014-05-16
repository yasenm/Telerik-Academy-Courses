// Write a program that extracts from given HTML file its title (if available),
// and its body text without the HTML tags. Example:
// <html>
//   <head><title>News</title></head>
//   <body><p><a href="http://academy.telerik.com">Telerik
//     Academy</a>aims to provide free real-world practical
//     training for young people who want to turn into
//     skillful .NET software engineers.</p></body>
// </html>
// Write a program that extracts from given HTML file its title
// (if available), and its body text without the HTML tags. Example:

// <html>
//   <head><title>News</title></head>
//   <body><p><a href="http://academy.telerik.com">Telerik
//     Academy</a>aims to provide free real-world practical
//     training for young people who want to turn into
//     skillful .NET software engineers.</p></body>
// </html>

namespace _25ExtractHtmlTextWithoutTags
{
    using System;
    using System.Text.RegularExpressions;
    using System.IO;

    class ExtractHtmlTextWithoutTags
    {
        static void Main()
        {
            string text = string.Empty;
            using (StreamReader sr = new StreamReader("ExampleHTML.html"))
            {
                text = sr.ReadToEnd();
            }
            Console.WriteLine(text);
            string pattern = @"<.*?>";
            text = Regex.Replace(text, pattern, string.Empty);
            text = text.Trim();
            Console.WriteLine(text);
        }
    }
}
