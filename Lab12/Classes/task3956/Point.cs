﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes.task3956
{
    public class Point
    {
        public int x;
        public int y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public String print()
        {
            return "(" + x + ";" + y + ")";
        }
        public override bool Equals(Object o)
        {
            if (this == o) return true;
            if (o == null || GetType() != o.GetType()) return false;

            Point point = (Point)o;

            if (x != point.x) return false;
            return y == point.y;
        }
    }
}
