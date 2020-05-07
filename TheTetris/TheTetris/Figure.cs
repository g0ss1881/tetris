using System;
using System.Collections.Generic;
using System.Text;

namespace TheTetris
{
    class Figure
    {
        public Point[] points = new Point[4];

        public void Draw()
        {
            foreach (Point i in points)
            {
                i.Draw();
            }
        }

        public void Move(Movement dir)
        {
            foreach (Point p in points)
            {
                p.Move(dir);
            }
        }
    }
}
