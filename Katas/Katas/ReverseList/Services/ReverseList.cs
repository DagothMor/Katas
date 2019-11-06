using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.Katas.ReverseList.Services
{
    public static class ReverseList
    {
        public static List<int> Reverse(List<int> list)
        {
            List<int> listr = new List<int>();
            for (int i = list.Count; i > 0; i--)
            {
                listr.Add(list[i-1]);
            }
            return listr;
        }
    }
}
