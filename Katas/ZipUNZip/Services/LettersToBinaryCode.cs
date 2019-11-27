using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Katas.ZipUNZip.Models;

namespace Katas.ZipUNZip.Services
{
    public static class LettersToBinaryCode
    {
        public static string Transformation(BinaryTree tree, char[] lettersin)
        {
            List<char> list = lettersin.ToList();
            string TextOut = "";
            while (list.Count > 0)
            {
                string BinaryCode = "";
                BTNode node = tree.Root;
                char letter = list[0]; 
                list.RemoveAt(0);
                while (node.Symbol != letter.ToString())
                {
                    if (node.Left.Symbol.Any(str => str.Equals(letter)))
                    {
                        node = node.Left;
                        BinaryCode += "0";
                    }
                    else
                    {
                        node = node.Right;
                        BinaryCode += "1";
                    }
                }

                TextOut += BinaryCode;
            }
            return TextOut;
        }
    }
}
