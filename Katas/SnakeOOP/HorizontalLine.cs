using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.SnakeOOP
{
    class HorizontalLine: Figure
    {
        public HorizontalLine(int xLeft, int xRight, int height, char symbol)
        {
            pList = new List<Point>();
            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x,height,symbol);
                pList.Add(p);
            }
        }
    }
}
