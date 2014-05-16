// Write a program for extracting all email addresses from given text.
// All substrings that match the format <identifier>@<host>…<domain>
// should be recognized as emails.

namespace _18ExtractEmailFromString
{
    using System;
    using System.Text.RegularExpressions;

    public class ExtractEmailFromString
    {
        public static void Main()
        {
            string text = "pustinqk@typ.com there are also others like shibanqka.maina@golemsym.net and typa_pacha@abv.bg or piron123@mail2.bg";
            Console.WriteLine(text);
            Regex regex = new Regex(@"([a-zA-Z0-9]+)@([a-zA-Z0-9]+).([a-zA-Z]{2,5})");
            MatchCollection emails = regex.Matches(text);
            foreach (var mail in emails)
            {
                Console.WriteLine(mail);
            }
        }
    }
}
