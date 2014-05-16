// Write a program that encodes and decodes a string using given encryption key 
// (cipher). The key consists of a sequence of characters. The encoding/decoding
// is done by performing XOR (exclusive or) operation over the first letter of 
// the string with the first of the key, the second – with the second, etc. When
// the last key character is reached, the next is the first.

namespace _07EncodeAndDecode
{
    using System;
    using System.Collections.Generic;

    class EncodeAndDecode
    {
        // method that will return encoded result
        public static string EncodeTextWithCipher(string text, string cipher) 
        {
            string result = string.Empty;
            int cipherIndex = 0;
            for (int i = 0; i < text.Length; i++)
            {
                result += ((char)(text[i] ^ cipher[cipherIndex]));
                cipherIndex++;
                if (cipherIndex == cipher.Length)
                {
                    cipherIndex = 0;
                }
            }
            return result;
        }

        // method that will return decoded result
        public static string DecodeTextWithCipher(string text, string cipher)
        {
            string result = string.Empty;
            int cipherIndex = 0;
            for (int i = 0; i < text.Length; i++)
            {
                result += ((char)(text[i] ^ cipher[cipherIndex]));
                cipherIndex++;
                if (cipherIndex == cipher.Length)
                {
                    cipherIndex = 0;
                }
            }
            return result;
        }

        // Both methods are absolutely identical in every line but i left them like that because of different names
        // so when you call the method its called by a proper name dont know if its good would like a feed back on that for sure
        static void Main()
        {
            Console.Write("Enter your text here : ");
            string text = Console.ReadLine();
            Console.Write("Enter your cipher here : ");
            string cipher = Console.ReadLine();

            string encodedText = EncodeTextWithCipher(text, cipher);
            Console.WriteLine(encodedText);
            string decodedText = DecodeTextWithCipher(encodedText, cipher);
            Console.WriteLine(decodedText);
        }
    }
}
