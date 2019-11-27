using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Katas.ZipUNZip.Services
{
    public static class ReadTheFile
    {
        public static string Read()
        {
            string path = @"c:\BinaryCode.txt";
            string stringout;
            using (StreamReader sr = File.OpenText(path))
            {
                stringout = sr.ReadLine();
            }

            return stringout;
        }
    }
}
