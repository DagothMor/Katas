using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.ZipUNZip.Models
{
    public class BTNode
    {
        public string Symbol;
        public BTNode Left;
        public BTNode Right;
        public int Count;

        public BTNode(string data,int count,BTNode left,BTNode right) {
            Symbol = data;
            Count = count;
            Left = left;
            Right = right;
        }

        public BTNode()
        {
            Symbol = default;
            Left = null;
            Right = null;
            Count = 0;
        }
    }
}
