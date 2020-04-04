using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Katas.Katas._6kyi.BackSpacesInString
{
    public static class BackSpacesInString
    {
        public static void Start()
        {
            string stringin = "asda##dsdsdd###fvcx#";

            List<char> listin = stringin.ToCharArray().ToList();

            List<char> listout = new List<char>(); 

            for (int i = 0; i < listin.Count; i++)
            {
                if (listin[i] != '#')
                {
                    listout.Add(listin[i]);
                }
                else
                {
                    if (listout != null)
                    {
                        listout.RemoveAt(listout.Count-1);
                    }
                }

            }

            string stringout = "";
            for (int i = 0; i < listout.Count; i++)
            {
                stringout += listout[i].ToString();
            }

            Console.WriteLine(stringout);

            Console.ReadLine();
        }
    }
}
