using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Katas.Katas.Remove_All_The_Marked_Elements_of_a_List.Services
{
    public static class ChekAndRemoveElements
    {
        public static int[] ChekAndRemove(int[] integerList, int[] valuesList)
        {
            var IntegerList = integerList.ToList();

            var CheckedList = valuesList.ToList();



            for (int i = 0; i < IntegerList.Count; i++)
            {
                foreach (var v in CheckedList)
                {
                    if (IntegerList[i] == v)
                    {
                        IntegerList.Remove(IntegerList[i]);
                        i--;
                        break;
                    }
                }
            }
            return IntegerList.ToArray();
        }
    }
}
