using System;
using System.Collections.Generic;
using System.Text;
using Katas.WorkWithSingleLinkedLists.Models;

namespace Katas.WorkWithSingleLinkedLists
{
    public static class WorkWithSingleLinkedLists
    {
        public static void Start()
        {
            SingleLinkedList<int> List = new SingleLinkedList<int>();

            List.Add(3);
            List.Add(1);
            List.Add(89);
            List.ShowNodes();
            Console.ReadLine();


        }
    }
}
