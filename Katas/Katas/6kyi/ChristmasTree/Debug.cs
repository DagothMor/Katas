using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Katas.Katas._6kyi.ChristmasTree
{
    public static class Debug
    {
        public static void Start()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string tree = "";
            int count = 1;

            for (int i = 0;i<8001;i++)
            {
                tree += new String(' ', i);
                tree += new String('*', count);
                tree += new String(' ', i);
                tree += "\n";
                count += 2;
            }
            tree += new String('*', count);
            string writePath = @"C:\debugtree.txt";

            try
            {
                using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine(tree);
                }

                using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine("Дозапись");
                    sw.Write(4.5);
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
