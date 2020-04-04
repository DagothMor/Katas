using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Katas.Katas._6kyi.SumOfDigitsAndDigitalRoot
{
    public static class SumOfDigitsAndDigitalRoot
    {
        public static void Start()
        {
            Console.WriteLine("");
            Console.ReadLine();
            Console.WriteLine("Enter the number");
            List<int> Number = Convert.ToInt64(Console.ReadLine()).
                ToString().
                ToCharArray().
                ToList().
                ConvertAll(x => int.
                    Parse(x.ToString()));
            //int sum = 0;
            Console.ReadLine();

            while (Number.Count>1)
            {
                Number = sum(Number).ToString().ToCharArray().ToList().ConvertAll(x => int.Parse(x.ToString()));
            }
            Console.WriteLine("ada");
            Console.ReadLine();
        }

        public static int sum(List<int> list)
        {
            int numberout=0;

            foreach (var VARIABLE in list)
            {
                numberout += VARIABLE;
            }
            return numberout;
        }
    }
}
