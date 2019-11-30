using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Katas.OtherProjects.FindANodeInATree.Models;

namespace Katas.OtherProjects.FindANodeInATree.Services
{
    public static class NewTree
    {
        public static Tree Start()
        {
            int Numbers = 1;

            Tree tree = new Tree(new Node());


            int Random1LVL = new Random().Next(6, 10);

            for (int i = 0; i < Random1LVL; i++)
            {
                tree.Root.Nodes.Add(new Node(Numbers, OtherLevelGenerator(new Random().Next(1, 3))));
                Numbers++;
            }

            List<Node> OtherLevelGenerator(int randomotherlevels)
            {
                List<Node> list = new List<Node>();

                for (int i = 0; i < randomotherlevels; i++)
                {
                    Numbers++;
                    list.Add(new Node(Numbers, OtherLevelGenerator(new Random().Next(0, 2))));
                }
                return list;
            }
            return tree;
        }

    }
}
