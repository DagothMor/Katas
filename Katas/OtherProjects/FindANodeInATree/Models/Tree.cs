using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.OtherProjects.FindANodeInATree.Models
{
    public class Tree
    {
        public Node Root;

        public Tree(Node root)
        {
            Root = root;
        }
        public Tree()
        {
            Root = new Node(0);
        }
    }
}
