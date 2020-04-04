using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.Katas._6kyi.Delete_occurrences_of_an_element_if_it_occurs_more_than_n_times.Services
{
    public static class ListCheckOut
    {
        public static List<int> Start(List<int> listvar,List<int> listcheck,int[] array,int n)
        {
            List<int> listnew = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < listvar.Count; j++)
                {
                    if (array[i] == listvar[j])
                    {
                        if (listcheck[j] < n)
                        {
                            listcheck[j]++;
                            listnew.Add(array[i]);
                        }

                    }
                }
            }

            return listnew;
        }
    }
}
