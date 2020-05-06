using System;
using System.Security.Cryptography.X509Certificates;

namespace TheTetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);

            int x1 = 2, 
                y1 = 3;

            char c1 = '■';

            Drow(x1, y1, c1);

            Console.ReadLine();
        }

        static void Drow(int x, int y, char c)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(c);
        }
    }
}
