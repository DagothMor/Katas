using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.Katas._5kyu
{
    public static class DirectionsReduction
    {
        public static void Start()
        {
            Console.WriteLine("Press any key to start");
            Console.ReadLine();
            Dictionary<string,string> dict = new Dictionary<string, string>();
            string[] dirarray = new string[4] {"NORTH","WEST","EAST","SOUTH"};
            for (int i = 0; i < 4; i++)
            {
                dict.Add(dirarray[i],dirarray[dirarray.Length-i-1]);
            }

            Console.WriteLine("Start Check the array");
            string[] stringin = new string[] { "NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST" };
            List<string> list = new List<string>();
            for (int i = 0; i < stringin.Length; i++)
            {
                //if(stringin[i]==)
            }
            Console.WriteLine("Press any key to end");
            Console.ReadLine();
        }
    }
}
