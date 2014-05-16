using System;
using System.Net;

//Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg)
//and stores it the current directory. Find in Google how to download files in C#. Be sure to catch
//all exceptions and to free any used resources in the finally block.

namespace _04DownloadFileAndStoreIt
{
    class DownloadFileAndStoreIt
    {
        //method that will give us the file name
        static string[] FindFileNameAndFolder(string fileAddress) 
        {
            string[] fileComponents = new string[2];
            for (int i = fileAddress.Length - 1; i >= 0; i--)
            {
                if (fileAddress.Substring(i,1) == "/")
                {
                    fileComponents[0] = fileAddress.Substring(0, i + 1);
                    fileComponents[1] = fileAddress.Substring(i + 1, fileAddress.Length - i - 1);
                    break;
                }
            }
            return fileComponents;
        }

        //method that will download the file to the current folder in which the program.cs is
        static void DownloadFileWithURL() 
        {
            WebClient downloadClient = new WebClient();

            //comment and ucoment other part to test both methods

            ////part with default chosen file
            //string fileAddressFolder = "http://www.devbg.org/img/";
            //string fileName = "Logo-BASD.jpg";

            //part with user entering URL
            Console.Write("Enter URL address : ");
            string fileAddress = Console.ReadLine();
            string fileAddressFolder = FindFileNameAndFolder(fileAddress)[0];
            string fileName = FindFileNameAndFolder(fileAddress)[1];

            downloadClient.DownloadFile(fileAddressFolder + fileName, fileName);
        }

        static void Main()
        {
            try
            {
                DownloadFileWithURL();
            }
            catch (ArgumentNullException ex)
            {
                Console.Error.WriteLine("The address parameter is null." + ex.Message);
            }
            catch (WebException ex)
            {
                Console.Error.WriteLine("The URI formed by combining BaseAddress and address is invalid." + ex.Message);
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine("The method has been called simultaneously on multiple threads." + ex.Message);
            }
            finally 
            {
                Console.WriteLine("Check in /bin/debug/ folder for the file.");
                Console.WriteLine("Thank you.");
            }
        }
    }
}
