using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TheTetris
{
    abstract class Figure
    {
        const int LENGTH = 4;

        public Point[] points = new Point[LENGTH];

        public void Draw()
        {
            foreach (Point i in points)
            {
                i.Draw();
            }
        }

        internal void TryMove(Movement dir)
        {
            Hide();

            var clone = Clone();

            Move(clone, dir);

            if (VerifyPosition(clone))
                points = clone;

            Draw();
        }

        private bool VerifyPosition(Point[] pList)
        {
            foreach (var p in pList)
            {
                if (p.x < 2 || p.y < 0 || p.x >= 40 || p.y >= 30)
                    return false;
            }

            return true;
        }

        private Point[] Clone()
        {
            var newPoints = new Point[LENGTH];

            for (int i = 0; i < LENGTH; i++)
            {
                newPoints[i] = new Point(points[i]);
            }

            return newPoints;
        }

        public void Move(Point[] pList, Movement dir)
        {
            foreach (var p in pList)
            {
                p.Move(dir);
            }
        }

        //public void Move(Movement dir)
        //{
        //    Hide();

        //    foreach (Point p in points)
        //    {
        //        p.Move(dir);
        //    }
            
        //    Draw();
        //}

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
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(200);
                Hide();
                TryMove(Movement.DOWN);
                Draw();
            }

            Hide();
        }
    }
}
