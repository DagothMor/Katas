using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Katas.ZipUNZip.Services
{
    public static class ReadTheFile
    {
        public static string ReadCode()
        {
            string path = @"c:\BinaryCode.txt";
            string stringout;
            using (StreamReader sr = File.OpenText(path))
            {
                stringout = sr.ReadLine();

            }
            return stringout;
        }

        public static List<char> ReadTable()
        {
            string path = @"c:\BinaryCode.txt";
            string stringout;
            using (StreamReader sr = File.OpenText(path))
            {
                stringout = GetLine(path,2);

            }
            return stringout.ToCharArray().ToList();
        }
        public static string GetLine(string fileName, int line)
        {
            using (var sr = new StreamReader(fileName))
            {
                for (int i = 1; i < line; i++)
                    sr.ReadLine();
                return sr.ReadLine();
            }
        }
    }
}
