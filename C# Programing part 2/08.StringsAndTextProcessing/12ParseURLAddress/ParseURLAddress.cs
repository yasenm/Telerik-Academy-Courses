// Write a program that parses an URL address given in the format:

// [protocol]://[server]/[resource]

// and extracts from it the [protocol], [server] and [resource] elements.
// For example from the URL http://www.devbg.org/forum/index.php the following 
// information should be extracted:
//        [protocol] = "http"
//        [server] = "www.devbg.org"
//        [resource] = "/forum/index.php"

namespace _12ParseURLAddress
{
    using System;

    public class ParseURLAddress
    {
        // method that gets the string URL or file directory and prints its main conponents
        public static void ExtractInformation(string strURL) 
        {
            int exampleIndex = strURL.IndexOf(":/");
            Console.WriteLine("{0,14} : {1};", "[protocol]", strURL.Substring(0, exampleIndex));
            Console.WriteLine("{0,14} : {1};", "[server]", strURL.Substring(exampleIndex + 3, strURL.IndexOf("/", exampleIndex + 3) - exampleIndex - 3));
            exampleIndex = strURL.IndexOf("/", exampleIndex + 3) + 1;
            Console.WriteLine("{0,14} : {1};", "[resource]", strURL.Substring(exampleIndex, strURL.Length - exampleIndex));
        }

        public static void Main()
        {
            string exampleString = "http://www.devbg.org/forum/index.php";
            ExtractInformation(exampleString);

            Console.Write("Enter your own URL : ");
            string userURL = Console.ReadLine();
            ExtractInformation(userURL);
        }
    }
}
