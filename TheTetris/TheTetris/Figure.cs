using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TheTetris
{
    abstract class Figure
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

        internal void Hide()
        {
            foreach (Point p in points)
            {
                p.Hide();
            }
        }

        public abstract void Rotate();

        internal void Fall()
        {
            for (int i = 0; i < 11; i++)
            {
                Thread.Sleep(200);
                Hide();
                Move(Movement.DOWN);
                Draw();
            }

            Hide();

            //i.Draw();
            //Thread.Sleep(200);
            //i.Hide();
            //i.Move(Movement.DOWN);
            //i.Draw();
        }
    }
}
