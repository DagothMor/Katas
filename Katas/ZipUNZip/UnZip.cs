using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.ZipUNZip.Services
{
    public static class UnZip
    {
        public static void Start()
        {
            Console.WriteLine("Press Enter To Start");
            Console.ReadLine();
            Console.WriteLine("Getting the text");
            string binarycode = ReadTheFile.ReadCode();
            List<char> DecoderTable = ReadTheFile.ReadTable();
            Dictionary<string, string> DecoderDictionary = FullingDecoderDictionary.Full(DecoderTable);
            Console.WriteLine("Decoder is fulled");
            Console.ReadLine();
            Console.WriteLine("Decoding Message");
            string decoded = DecodingMessage.Decode(DecoderDictionary, binarycode);
            Console.WriteLine("The message is:");
            Console.WriteLine(decoded);
            Console.ReadLine();





        }
    }
}
