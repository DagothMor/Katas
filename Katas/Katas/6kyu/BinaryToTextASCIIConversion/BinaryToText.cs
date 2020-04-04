using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.Katas._6kyi.BinaryToTextASCIIConversion
{
    public static class BinaryToText
    {
        public static void Start()
        {
            Console.WriteLine("Press enter to start");
            Console.ReadLine();
            string binarystring = "0100100001100101011011000110110001101111";
            string result = "";
            while (binarystring.Length > 0)
            {
                var first8 = binarystring.Substring(0, 8);
                binarystring = binarystring.Substring(8);
                var number = Convert.ToInt32(first8, 2);
                result += (char)number;

            }
            Console.WriteLine(result);
            Console.WriteLine("Press enter to end");
            Console.ReadLine();
        }
    }
}
