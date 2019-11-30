using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.OtherProjects.FindANodeInATree.Models
{
    public class Node
    {
        public int Data;
        public List<Node> Nodes;
        public Node(int data, List<Node> nodes)
        {
            Data = data;
            Nodes = nodes;
        }
        public Node(int data)
        {
            Data = data;
            Nodes = new List<Node>();
        }

        public Node()
        {
            Data = default;
            Nodes = new List<Node>();
        }
    }
}
