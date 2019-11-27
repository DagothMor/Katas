using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml;
using Katas.ZipUNZip.Models;

namespace Katas.ZipUNZip.Services
{
    public static class BuildingBinaryTree
    {
        public static BinaryTree Building(List<BTNode> list)
        {
            BTNode Root = new BTNode();
            while (list.Count>1)
            {
                BTNode x = list[0];
                BTNode y = list[1];
                BTNode z = new BTNode(x.Symbol+y.Symbol, x.Count + y.Count,x,y);
                list.RemoveAt(0);
                list.RemoveAt(0);
                list.Add(z);
                list = list.OrderBy(x => x.Count).ToList();
            }
            Root = list[0];
            BinaryTree binarytree = new BinaryTree(Root);
            
            return binarytree;
        }
    }
}
