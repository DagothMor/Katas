﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Katas.SnakeOOP
{
	class Snake : Figure
    {
        
        Direction direction;

        public Snake(Point tail, int length, Direction _direction)
        {
            direction = _direction;
            pList = new List<Point>();
            
            for (int i = 0; i < length; i++)
            {
                //Point p = new Point(tail);
                //p.Move(i, direction);
                //pList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            //tail.Clear();
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point();
            nextPoint.Move(1, direction);
            return nextPoint;
        }
    }
}
