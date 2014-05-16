using System;
using System.Text.RegularExpressions;

// You are given a text. Write a program that changes the text in all regions
// surrounded by the tags <upcase> and </upcase> to uppercase. The tags cannot
// be nested. Example:
   
// We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.
   
// The expected result:
   
// We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.

namespace _05UpcaseTagsContentToUpperCase
{
    class UpcaseTagsContentToUpperCase
    {
        static void Main()
        {
            string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";

            // we make a regex pattern that will get all substrings starting with <upcase> and ending with </upcase>
            // for example the first match add will be <upcase>yellow submarine</upcase> with the (?<inside>.?) we 
            // make a collection named "inside" that will hold only the text between the tags only! thats how we replace
            // after wards using the group
            Regex regex = new Regex(@"(<\s*upcase\s*>)(?<inside>.*?)(<\s*/upcase\s*>)");
            MatchCollection matches = regex.Matches(text);

            foreach (Match match in matches)
            {
                text = regex.Replace(text, match.Groups["inside"].Value.ToUpper(), 1);
            }
            Console.WriteLine(text);
        }
    }
}
