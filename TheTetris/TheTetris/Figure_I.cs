using System;
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

        public override void Rotate()
        {
            if (points[0].x == points[1].x)
            {
                RotateHorizonral();
            }
            else
            {
                RotateVertical();
            }
        }

        private void RotateHorizonral()
        {
            for (int i = 0; i < points.Length; i++)
            {
                points[i].y = points[1].y;
                points[i].x = points[0].x + i;
            }   
        }

        private void RotateVertical()
        {
            for (int i = 0; i < points.Length; i++)
            {
                points[i].x = points[1].x;
                points[i].y = points[0].y + i;
            }
        }
    }
}
