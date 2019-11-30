using System;
using System.Collections.Generic;
using System.Text;
using Katas.OtherProjects.FindANodeInATree.Models;

namespace Katas.OtherProjects.FindANodeInATree.Services
{
    public static class FindANode
    {
        public static bool DFSPRE(Tree tree, int data)
        {
            Node node = tree.Root;
            bool find = false;

            preorder(node);

            void preorder(Node node)
            {
                if (find == false)
                {
                    if (node.Data == data)
                    {
                        find = true;
                    }
                    foreach (var VARIABLE in node.Nodes)
                    {
                        preorder(VARIABLE);
                    }
                }
            }



            return find;
        }
    }
}
