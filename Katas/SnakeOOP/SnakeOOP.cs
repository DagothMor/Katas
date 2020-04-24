using System;
using System.Collections.Generic;
using System.Text;
using Katas.SnakeOOP;

namespace Katas.SnakeOOP
{
    public static class SnakeOop
    {
        public static void Start()
        {
            Console.SetBufferSize(80, 25);

            //
            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();

            Point p = new Point(4,5,'*');
            p.Draw();


        }
    }
}
