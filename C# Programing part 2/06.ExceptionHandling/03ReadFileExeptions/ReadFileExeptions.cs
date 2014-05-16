using System;
using System.IO;

//Write a program that enters file name along with its full file path
//(e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the 
//console. Find in MSDN how to use System.IO.File.ReadAllText(…). Be
//sure to catch all possible exceptions and print user-friendly
//error messages.

namespace _03ReadFileExeptions
{
    class ReadFileExeptions
    {
        //method that will read file name and will print file text
        static void ReadAndPrintFile() 
        {
            Console.Write("Enter file path : ");
            string filePath = Console.ReadLine();
            string fileText = File.ReadAllText(@"" + filePath);
            Console.WriteLine(fileText);
        }

        static void Main()
        {
            try
            {
                ReadAndPrintFile();
            }
            catch (ArgumentNullException ex)
            {
                Console.Error.WriteLine("Path is null. " + ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.Error.WriteLine("Path is zero-length string, contains only white space, or one or more invalid characters as defined by InvalidPathChars. " + ex.Message);
            }
            catch (PathTooLongException ex)
            {
                Console.Error.WriteLine("Path must be less than 248 characters. " + ex.Message);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.Error.WriteLine("Specified path is invalid. " + ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                Console.Error.WriteLine("The file specified in path was not found. " + ex.Message);
            }
            catch (IOException ex)
            {
                Console.Error.WriteLine("An I/O error occurred while opening the file. " + ex.Message);
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.Error.WriteLine("Unauthorized access exception. " + ex.Message);
            }
            catch (NotSupportedException ex)
            {
                Console.Error.WriteLine("Path is in invalid format. " + ex.Message);
            }

        }
    }
}
