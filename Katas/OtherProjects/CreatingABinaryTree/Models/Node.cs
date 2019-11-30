using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.OtherProjects.CreatingABinaryTree.Models
{
    public class Node<T>
    {
        public T Data;
        public Node<T> Left;
        public Node<T> Right;
        

        public Node(T data)
        {
            Data = data;
            Left = default;
            Right = default;
        }
    }
}
