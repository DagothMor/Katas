using System;
using System.Collections.Generic;
using System.Text;
using Katas.OtherProjects.FindANodeInATree.Models;
using Katas.OtherProjects.FindANodeInATree.Services;

namespace Katas.OtherProjects.FindANodeInATree
{
    public static class FindANodeInATree
    {
        public static void Start()
        {
            Console.WriteLine("Press enter to start generator");

            Console.ReadLine();

            Console.WriteLine("Starting Tree Generation");

            Tree tree = NewTree.Start();

            Console.WriteLine("Tree is generated");

            Console.WriteLine("Enter the needed number");

            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"You entered{n}");
            //bool finding = FindANode.DFSPRE(tree, n);
            if (FindANode.DFSPRE(tree, n) == false)
            {
                Console.WriteLine("The entered node doesn't exist'");
            }
            else
            {
                Console.WriteLine("The node is find");
            }
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();

        }
    }
}
