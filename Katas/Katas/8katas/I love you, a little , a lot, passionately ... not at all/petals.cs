using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Katas.Katas._8katas.I_love_you__a_little___a_lot__passionately_._not_at_all
{
    public static class petals
    {
        public static void start()
        {
            LinkedList<string> linkedList = new LinkedList<string>();
            linkedList.AddLast("I love you");
            linkedList.AddLast("a little");
            linkedList.AddLast("a lot");
            linkedList.AddLast("passionately");
            linkedList.AddLast("madly");
            linkedList.AddLast("not at all");

            Console.WriteLine("Enter the count");
            int n = Convert.ToInt32(Console.ReadLine());
            int indexlist = -1;
            for (int i = n; i > -1; i--)
            {
                if (indexlist == linkedList.Count - 1)
                {
                    indexlist = 0;
                }
                else indexlist++;
            }

            string[] stringout = linkedList.ToArray();
            Console.WriteLine($"{stringout}");
            Console.ReadLine();
        }

    }
}
