using System;
using System.Collections.Generic;
using System.Text;
using Katas.Katas.The_Supermarket_Queue.Services;
using Katas.ZipUNZip.Models;
using Katas.ZipUNZip.Services;
using System.Linq;

namespace Katas.ZipUNZip
{
    public static class ZipUNZip
    {
        public static void Start()
        {
            Console.WriteLine("Enter the string");
            string stringin = Convert.ToString(Console.ReadLine());
            Console.WriteLine($"You entered:{stringin}");
            char[] lettersin = stringin.ToCharArray();
            Dictionary<char, int> CountLetters = Services.CountLetters.Count(lettersin);
            ConsoleOut.Dictionary(CountLetters);
            Console.ReadLine();
            List<BTNode> ListNode = MakeListNode.ListNode(CountLetters);
            Console.ReadLine();
            List<BTNode> SortedListOfNodes = ListNode.OrderBy(x => x.Count).ToList();
            Console.WriteLine("List is sorted");
            Console.WriteLine("List is Reversed");
            Console.ReadLine();
            BinaryTree Tree = BuildingBinaryTree.Building(SortedListOfNodes);
            Console.WriteLine("Tree is maked");
            Console.ReadLine();
            Console.WriteLine("Lets fulled Dictionary walking on the tree");
            Dictionary<string,string> ResultCode =EnterTheDictionaryOfCode.Fulling(Tree,ListNode);
            Console.WriteLine("The Dictionary if fulled");
            ConsoleOut.Dictionary(ResultCode);
            Console.WriteLine("Start to full the text");
            string textout = LettersToBinaryCode.Transformation(Tree, lettersin);
            Console.ReadLine();
            Console.WriteLine("Making the file with binarycode");
            CreateFile.Start(textout,ResultCode);
            Console.ReadLine();
        }
    }
}
