using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Katas.ZipUNZip.Services
{
    public static class CreateFile
    {
        public static void Start<T,T2>(string textout,Dictionary<T,T2> dictionary)
        {
            string writePath = @"c:\BinaryCode.txt";
            try
            {
                using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine(textout);
                    foreach (KeyValuePair<T,T2> entry in dictionary)
                    {
                        sw.Write($"{entry.Value}");
                        sw.Write($"=");
                        sw.Write($"{entry.Key}");
                        sw.Write($";");
                    }
                }
                Console.WriteLine("Запись выполнена");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
