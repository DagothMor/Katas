using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Katas.Сrypt_GOST28147_89
{
    public static class EncryptionAnlgorythm_GOST28147_89
    {
        public static void Start()
        {
            Console.WriteLine("Enter the word");
            string word = Convert.ToString(Console.ReadLine());
            Int64 CHISLO = 42;
            kek();

            Console.WriteLine("press any key to end");
            Console.ReadLine();



        }
        public static void kek()
        {
            // Define a byte array.
            byte[] bytes = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
            Console.WriteLine("The byte array: ");
            Console.WriteLine("   {0}\n", BitConverter.ToString(bytes));

            // Convert the array to a base 64 string.
            string s = Convert.ToBase64String(bytes);
            Console.WriteLine("The base 64 string:\n   {0}\n", s);

            // Restore the byte array.
            byte[] newBytes = Convert.FromBase64String(s);
            Console.WriteLine("The restored byte array: ");
            Console.WriteLine("   {0}\n", BitConverter.ToString(newBytes));
        }

    }
}
