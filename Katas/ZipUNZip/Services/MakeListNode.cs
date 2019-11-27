using System;
using System.Collections.Generic;
using System.Text;
using Katas.ZipUNZip.Models;

namespace Katas.ZipUNZip.Services
{
    public static class MakeListNode
    {
        public static List<BTNode> ListNode(Dictionary<char, int> dictionary)
        {
            List<BTNode> ListOfNodes = new List<BTNode>();

            foreach (KeyValuePair<char, int> entry in dictionary)
            {
                ListOfNodes.Add(new BTNode(entry.Key.ToString(),entry.Value,default,default));
            }

            return ListOfNodes;
        }
    }
}
