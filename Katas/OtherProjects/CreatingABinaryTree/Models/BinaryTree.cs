using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.OtherProjects.CreatingABinaryTree.Models
{
    public class BinaryTree<T>
    {
        public Node<T> Root;
        public BinaryTree(Node<T> root)
        {
            Root = root;
        }
    }
}
