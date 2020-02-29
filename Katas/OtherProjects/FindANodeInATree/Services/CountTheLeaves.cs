using System;
using System.Collections.Generic;
using System.Text;
using Katas.OtherProjects.FindANodeInATree.Models;

namespace Katas.OtherProjects.FindANodeInATree.Services
{
    public static class CountTheLeaves
    {
        public static int Start(Tree tree)
        {
            Node node = tree.Root;
            int Count = 0;

            DFSPRE(node);

            void DFSPRE(Node node)
            {
                if (node.Nodes.Count ==0)
                {
                    Count++;
                }

                foreach (var VARIABLE in node.Nodes)
                {
                    DFSPRE(VARIABLE);
                }
            }


            return Count;
        }
    }
}
