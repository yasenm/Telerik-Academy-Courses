//Write a program that replaces in a HTML document given as
//string all the tags <a href="…">…</a> with corresponding
//tags [URL=…]…/URL]. Sample HTML fragment:

//<p>Please visit <a href="http://academy.telerik. com">our site</a> to
//choose a training course. Also visit <a href="www.devbg.org">our
//forum</a> to discuss the courses.</p>

//                    \/

//<p>Please visit [URL=http://academy.telerik. com]our site[/URL] to 
//choose a training course. Also visit [URL=www.devbg.org]our forum[/URL]
//to discuss the courses.</p>

namespace _15ReplaceAnchorTagInHtml
{
    using System;
    using System.Text.RegularExpressions;

    public class ReplaceAnchorTagInHtml
    {
        // method that will replace the anchor HTML tags <a href=.....></a> with [URL=...][/URl]
        public static void ReplaceAnchorTags(string text) 
        {
            // we have two string patterns the first one will match the opening tags to the "address"
            string openPatternPart1 = @"<\s*a.*?\shref";
            // string openPatternPart2 = @"\""\s*?>";
            Regex pattern2 = new Regex(@"\""\s*?>");
            string closingPattern = @"<\s*/a.*?>";
            string result = Regex.Replace(text, openPatternPart1, "[URL=");
            // result = Regex.Replace(text, openPatternPart2, "\"]");
            result = pattern2.Replace(result, "\"]");
            result = Regex.Replace(result, closingPattern, "[/URL]");
            Console.WriteLine(result);
        }

        public static void Main()
        {
            string text = "<p>Please visit <a href=\"http://academy.telerik. com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";
            Console.WriteLine(text);

            ReplaceAnchorTags(text);
        }
    }
}
