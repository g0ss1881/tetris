using System;
using System.Collections.Generic;
using System.Text;

namespace TheTetris
{
    class Point
    {
        public int x;
        public int y;
        public char c;

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(c);
        }

        public Point (int a, int b, char sym)
        {
            x = a;
            y = b;
            c = sym;
            Draw();
        }

        public void Move(Movement dir)
        {
            switch (dir)
            {
                case Movement.LEFT:
                    x -= 1;
                    break;
                case Movement.RIGHT:
                    x += 1;
                    break;
                case Movement.DOWN:
                    y += 1;
                    break;
            }
        }
    }
}
