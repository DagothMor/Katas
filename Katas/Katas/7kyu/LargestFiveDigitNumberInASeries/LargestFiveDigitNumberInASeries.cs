using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.Katas._7kyu.LargestFiveDigitNumberInASeries
{
    public static class LargestFiveDigitNumberInASeries
    {
        public static void Start()
        {
            Console.WriteLine("Press any key to start");
            Console.ReadLine();
            Console.WriteLine("Enter the number");
            string enterednumber = Console.ReadLine();
            string largestnumber = GetNumber(enterednumber);
            Console.WriteLine($"The maximum number is {largestnumber}");
            Console.WriteLine("Press any key to end");
            Console.ReadLine();

        }

        public static string GetNumber(string enterednumber)
        {
            List<int> listofnumbers = new List<int>();

            string answer="";
            int finish = enterednumber.Length-4;
            int temp = 0;
            StringBuilder stringbuilder = new StringBuilder();

            for (int i = 0; i < finish; i++)
            {
                for (int j = i; j < i+5; j++)
                {
                    stringbuilder.Append(enterednumber[j]);
                }
                listofnumbers.Add(int.Parse(stringbuilder.ToString()));
                stringbuilder.Clear();
            }

            for (int i = 0; i < listofnumbers.Count; i++)
            {
                if (listofnumbers[i] > temp)
                {
                    temp = listofnumbers[i];
                }
            }
            return temp.ToString();
        }

        public static bool IsBigger(string firstvalue,string secondvalue)
        {
            return Convert.ToInt32(firstvalue) > Convert.ToInt32(secondvalue) ? true : false;
        }
    }
}
