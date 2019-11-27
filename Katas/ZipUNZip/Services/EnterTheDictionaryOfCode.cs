using System;
using System.Collections.Generic;
using System.Text;
using Katas.ZipUNZip.Models;

namespace Katas.ZipUNZip.Services
{
    public static class EnterTheDictionaryOfCode
    {
        public static Dictionary<string, string> Fulling(BinaryTree tree, List<BTNode> list)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            BTNode root = tree.Root;
            string BinaryCode = "";
            bool IsLeave(BTNode node)
            {
                if (node.Left == null)
                {
                    if (node.Right == null)
                    {
                        return true;
                    }
                }

                return false;
            }
            for (int i = 0; i < list.Count; i++)
            {
                BinaryCode = "";
                 WalkOnTree(root, list[i].Symbol, BinaryCode);
                 string s = BinaryCode;

               dictionary.Add(list[i].Symbol, s);
            }

            void WalkOnTree(BTNode node, string symbol, string binarycode)
            {
                if (IsLeave(node) == false)
                {

                    if (node.Left != null)
                    {
                        WalkOnTree(node.Left, symbol, binarycode + "0");
                    }

                    if (node.Right != null)
                    {
                        WalkOnTree(node.Right, symbol, binarycode + "1");
                    }

                }
                if (node.Symbol == symbol)
                {
                    BinaryCode = binarycode;
                }
            }

            return dictionary;
        }


    }
}

