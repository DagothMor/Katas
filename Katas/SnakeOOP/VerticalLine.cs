using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.SnakeOOP
{
    class VerticalLine:Figure
    {
        public VerticalLine(int yUp, int yDown, int x, char symbol)
        {
            pList = new List<Point>();
            for (int y = yUp; x <= yDown; x++)
            {
                Point p = new Point(x, y, symbol);
                pList.Add(p);
            }
        }
    }
}
