﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TheTetris
{
    class Figure_I : Figure
    {
        public Figure_I (int x, int y, char sym)
        {
            points[0] = new Point(x, y, sym);
            points[1] = new Point(x, y + 1, sym);
            points[2] = new Point(x, y + 2, sym);
            points[3] = new Point(x, y + 3, sym);
        }
    }
}