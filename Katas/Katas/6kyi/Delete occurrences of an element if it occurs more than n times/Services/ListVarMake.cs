using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.Katas._6kyi.Delete_occurrences_of_an_element_if_it_occurs_more_than_n_times.Services
{
    public static class ListVarMake
    {
        public static List<int> Start(int[] array)
        {
            List<int> listvar = new List<int>();

            bool flag;

            listvar.Add(array[0]);

            for (int i = 1; i < array.Length; i++)
            {
                flag = false;
                for (int j = 0; j < listvar.Count; j++)
                {
                    if (array[i] == listvar[j])
                    {
                        flag = true;
                    }
                }
                if (flag == false) { listvar.Add(array[i]);}
            }

            return listvar;
        }
    }
}
