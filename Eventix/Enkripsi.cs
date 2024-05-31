using System;
using System.Text;

namespace Encrypt
{
    public static class CaesarCipher
    {
        public const string PrintableChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()-_=+[]{}|;:'\",.<>?/`~ ";

        private static int _shift = 3;

        public static string Encrypt(string input)
        {
            StringBuilder encrypted = new StringBuilder();

            foreach (char c in input)
            {
                int index = PrintableChars.IndexOf(c);
                if (index != -1)
                {
                    int newIndex = (index + _shift) % PrintableChars.Length;
                    encrypted.Append(PrintableChars[newIndex]);
                }
                else
                {
                    encrypted.Append(c);
                }
            }

            return encrypted.ToString();
        }

        public static string Decrypt(string input)
        {
            StringBuilder decrypted = new StringBuilder();

            foreach (char c in input)
            {
                int index = PrintableChars.IndexOf(c);
                if (index != -1)
                {
                    int newIndex = (index - _shift + PrintableChars.Length) % PrintableChars.Length;
                    decrypted.Append(PrintableChars[newIndex]);
                }
                else
                {
                    decrypted.Append(c);
                }
            }

            return decrypted.ToString();
        }
    }
}