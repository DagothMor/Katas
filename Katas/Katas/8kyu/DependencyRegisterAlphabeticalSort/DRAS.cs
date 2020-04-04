using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Katas.DependencyRegisterAlphabeticalSort.Services;

namespace Katas.DependencyRegisterAlphabeticalSort
{
    public static class DRAS
    {
        public static void Start()
        {
            Dictionary<char,int> SerialAlphabet = Fulling.FullDictionary();
            Console.ReadLine();
            string[] givenwords = AddStringArray.Add();
            Console.ReadLine();
            string[] sortedwords = DRASort.Start(SerialAlphabet,givenwords);
            char[] c = sortedwords.First().ToCharArray(); 
            Console.ReadLine();
        }
    }
}
