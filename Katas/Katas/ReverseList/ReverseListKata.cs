using System;
using System.Collections.Generic;
using System.Text;
using Katas.Katas.ReverseList.Services;

namespace Katas
{
    public static class ReverseListKata
    {
        public static void Start()
        {
            List<int> list = MakeList.Make();

            list.Reverse();

            
            List<int> listR = list;

            for (int i = 0; i < listR.Count; i++)
            {
                Console.WriteLine(listR[i]);
            }
        }
    }
}
