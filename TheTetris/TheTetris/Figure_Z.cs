using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace TheTetris
{
    class Figure_Z : Figure
    {
        public Figure_Z (int x, int y, char sym)
        {
            points[0] = new Point(x, y, sym);
            points[1] = new Point(x + 1, y, sym);
            points[2] = new Point(x + 1, y + 1, sym);
            points[3] = new Point(x + 2, y + 1, sym);
            Draw();
        }

        public override void Rotate()
        {
            if (points[0].y == points[1].y)
            {
                RotateVertical();
            }
            else
            {
                RotateHorizontal();
            }
        }

        public void RotateVertical()
        {
            
        }

        public void RotateHorizontal()
        {
            
        }
    }
}
