using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.SnakesAndLadders
{
    public static class snakesandladders
    {
        public static void Start()
        {
            Console.WriteLine("Press any key to start");
            Console.ReadLine();

            Console.WriteLine("Press any key to end");
            Console.ReadLine();
        }

        public static int ThrowACubes()
        {
            return new Random().Next(2, 12);
        }

        public static void Draw()
        {

        }
    }
}
