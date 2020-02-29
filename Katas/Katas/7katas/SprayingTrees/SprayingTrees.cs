using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.Katas._7katas.SprayingTrees
{
    public static class SprayingTrees
    {
        public static void Start()
        {
            Console.WriteLine("Enter the name");

            string w = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter the name");

            int n = Convert.ToInt32(Console.ReadLine());

            int c= Convert.ToInt32(Console.ReadLine());


            Dictionary<string,string> dictionary = new Dictionary<string, string>();

            List<string> listweeksday = new List<string>(){"Monday","Tuesday","Wednesday","Thursday","Friday"};

            List<string> ListOfNames = new List<string>(){"James","John","Robert","Michael","William"};

            for (int i = 0; i < 5; i++)
            {
                dictionary.Add(ListOfNames[i],listweeksday[i]);
            }

            Message();

            Console.ReadLine();

             void Message()
            {
                Console.WriteLine($"It is {w} today, {dictionary[w]}, you have to work, you must spray {c} trees and you need {c*2} dollars to buy liquid");
            }
        }

        
    }
}
