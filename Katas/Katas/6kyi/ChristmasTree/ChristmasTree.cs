using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.Katas._6kyi.ChristmasTree
{
    public static class ChristmasTree
    {
        public static void Start()
        {
            Console.WriteLine("Press enter to start");
            Console.ReadLine();
            int n = Convert.ToInt32(Console.ReadLine());
            string stringout = "";
            string stars = "*";
            List<string> list = new List<string>();
            for (int i = n; i > 0; i--)
            {
                list.Add(branch(i));
                stars += "**";
            }

            for (int i = 0; i < list.Count; i++)
            {
                stringout += list[i];
            }
            Console.WriteLine(stringout);
            Console.ReadLine();

            string branch(int number)
            {
                string stringout = "";
                for (int i = 0; i < number; i++)
                {
                    stringout += " ";
                }
                stringout += stars;
                for (int i = 0; i < number; i++)
                {
                    stringout += " ";
                }

                stringout += "\n";
                return stringout;
            }
        }

        
    }
}
