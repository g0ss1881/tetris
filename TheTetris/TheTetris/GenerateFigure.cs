using System;

namespace TheTetris
{
    internal class GenerateFigure
    {
        private int _x;
        private int _y;
        private char _c;

        public GenerateFigure(int x, int y, char c)
        {
            _x = x;
            _y = y;
            _c = c;
        }

        private Random _rand = new Random();

        public Figure GetNewFigure()
        {
            switch (_rand.Next(0, 7))
            {
                case 0:
                    return new Figure_I(_x, _y, _c);
                case 1:
                    return new Figure_Q(_x, _y, _c);
                case 2:
                    return new Figure_T(_x, _y, _c);
                case 3:
                    return new Figure_S(_x, _y, _c);
                case 4:
                    return new Figure_Z(_x, _y, _c);
                case 5:
                    return new Figure_J(_x, _y, _c);
                default:
                    return new Figure_L(_x, _y, _c);
            }
        }
    }
}