using System;
using System.Collections.Generic;
using System.Text;
using Katas.BiggerOrNot;

namespace Katas.DependencyRegisterAlphabeticalSort.Services
{
    public static class DRASort
    {
        public static string[] Start(Dictionary<char, int> ABCDictionary, string[] givenarray)
        {
            string[] SortedArray =givenarray;
            string firstword;
            string secondword;
            bool IsItNeedToSwap = false;


            for (int i = 0; i < givenarray.Length-1; i++)
            {
                if (i == 0)
                {
                    IsItNeedToSwap = false;
                    firstword = givenarray[i];
                    secondword = givenarray[i + 1];
                    IsItNeedToSwap = BON.Checking(firstword, secondword, ABCDictionary);
                    if (IsItNeedToSwap == true)
                    {
                        SortedArray[i] = secondword;
                        SortedArray[i + 1] = firstword;
                    }
                    
                }
                else
                {
                    IsItNeedToSwap = false;
                    firstword = givenarray[i];
                    secondword = givenarray[i + 1];
                    IsItNeedToSwap = BON.Checking(firstword, secondword, ABCDictionary);
                    if (IsItNeedToSwap == true)
                    {
                        SortedArray[i] = secondword;
                        SortedArray[i + 1] = firstword;
                        i--;
                        i--;
                    }

                }
            }




            return SortedArray;
        }
    }
}
