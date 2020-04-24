using System;

namespace Katas.CircleTrainOOPStyle
{
    public static class CircleTrainOopStyle
    {
        public static void Start()
        {
            Console.WriteLine("Press any key to start");
            Console.ReadLine();
            int x1 = 1;
            int y1 = 3;
            char sym1 = '*';

            Draw(x1, y1, sym1);

            int x2 = 4;
            int y2 = 5;
            char sym2 = '#';

            Draw(x2, y2, sym2);

            Console.ReadLine();
            Console.WriteLine("Press any key to end");
            Console.ReadLine();
        }
        static void Draw(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
