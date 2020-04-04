using System;
using System.Collections.Generic;
using System.Text;
using Katas.StructureData.Create.Array.Object;
using Katas.StructureData.Create.Array.String;

namespace Katas.Katas.ReversingAndCombiningText
{
    public static class ReversingAndCombiningText
    {
        public static void Start()
        {
            Console.WriteLine("Press any key to start");
            Console.ReadLine();
            string[] arrayofstrings = CreateArrayOfStrings.Start();
            Console.WriteLine("Press any key to end");
            Console.ReadLine();
        }
    }
}
