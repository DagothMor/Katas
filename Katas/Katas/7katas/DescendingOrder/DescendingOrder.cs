using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Katas.Katas._7katas.DescendingOrder
{
    public static class DescendingOrder
    {
        public static void Start()
        {

            Console.WriteLine("Enter The Number");
            long Number = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine($"You entered {Number}");
            Console.WriteLine($"{Number}");
            List<char> listofchars = Number.ToString().ToCharArray().ToList();
            List<long> listofdigits = new List<long>();
            for (int i = 0; i < listofchars.Count; i++)
            {
                listofdigits.Add(Convert.ToInt64(listofchars[i].ToString()));
            }

            listofdigits.Reverse();
            listofdigits.Select(x => x * x);
            Console.ReadLine();




        }
    }
}
