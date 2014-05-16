using System;
using System.Text;
using System.Collections.Generic;

//Creating a password generator example from lecture Niki
namespace _999PublicPasswordGenerator
{
    public class PublicPasswordGenerator
    {
        static void Main()
        {
            PasswordsGenerator passwordGenerator = new PasswordsGenerator();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(passwordGenerator.Generate(12));
            }
        }
    }

    public static class RandomNumbers
    {
        public static Random Generator = new Random();
    }

    public static class ListExtensions 
    {
        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = RandomNumbers.Generator.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }

    public class PasswordsGenerator
    {
        private readonly string alphabetLower = "abcdefghijklmnopqrstuvwxyz";
        private readonly string alphabetUpper;
        private readonly string digits = "-123456789";
        private readonly string specialCharacters = "!@№$%€§*()–+=-";

        private const int persentAlphabetLower = 25;
        private const int persentAlphabetUpper = 25;
        private const int persentDigits = 25;

        public PasswordsGenerator() 
        {
            alphabetUpper = alphabetLower.ToUpper();
        }

        public string Generate(int length = 10)
        {
            int alphaLowerCount = length * persentAlphabetLower / 100;
            int alphaUpperCount = length * persentAlphabetUpper / 100;
            int digitsCount = length * persentDigits / 100;
            int specialCount = length - alphaLowerCount - alphaUpperCount - digitsCount;

            List<char> randomPassword = new List<char>();

            for (int i = 1; i <= alphaLowerCount; i++)
            {
                int randomIndex = RandomNumbers.Generator.Next(0, alphabetLower.Length);
                char randomChar = alphabetLower[randomIndex];
                randomPassword.Add(randomChar);
            }

            for (int i = 1; i <= alphaUpperCount; i++)
            {
                int randomIndex = RandomNumbers.Generator.Next(0, alphabetUpper.Length);
                char randomChar = alphabetUpper[randomIndex];
                randomPassword.Add(randomChar);
            }

            for (int i = 1; i <= digitsCount; i++)
            {
                int randomIndex = RandomNumbers.Generator.Next(0, digits.Length);
                char randomChar = digits[randomIndex];
                randomPassword.Add(randomChar);
            }

            for (int i = 1; i <= specialCount; i++)
            {
                int randomIndex = RandomNumbers.Generator.Next(0, specialCharacters.Length);
                char randomChar = specialCharacters[randomIndex];
                randomPassword.Add(randomChar);
            }

            randomPassword.Shuffle();

            return string.Concat(randomPassword);
        }
    }
}