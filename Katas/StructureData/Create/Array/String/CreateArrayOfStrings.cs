using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.StructureData.Create.Array.String
{
    public static class CreateArrayOfStrings
    {
        public static string[] Start()
        {
            Console.WriteLine("Press count of strings");
            int Count = Convert.ToInt32(Console.ReadLine());
            string[] stringout = new string[Count];
            for (int i=0;i<Count;i++) {
                Console.WriteLine($"Enter the {i+1} word");
                stringout[i] = Convert.ToString(Console.ReadLine());
            }
            foreach (var VARIABLE in stringout)
            {
                Console.Write(VARIABLE+"|");
            }
            Console.WriteLine("\nDone!");
            Console.ReadLine();
            return stringout;
        }
    }
}
