using Microsoft.VisualBasic;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace TheTetris
{
    class Program
    {
        private static void HandleKey(Figure figure, ConsoleKeyInfo key)
        {
            figure.Hide();

            switch (key.Key)
            {
                case ConsoleKey.LeftArrow:
                    figure.Move(Movement.LEFT);
                    break;
                case ConsoleKey.RightArrow:
                    figure.Move(Movement.RIGHT);
                    break;
                case ConsoleKey.DownArrow:
                    figure.Move(Movement.DOWN);
                    break;
                    //case ConsoleKey.UpArrow:
                    //break;
            }

            figure.Draw();
        }

        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);

            

            Figure fig = new Figure_I(20, 0, '0');

            while (true)
            {
                var key = Console.ReadKey();

                HandleKey(fig, key);
            }


            //GenerateFigure newfigure = new GenerateFigure(20, 0, '0');
            //Figure fig;

            //while (true)
            //{

            //}



            // Проверка всех фигур на работоспособность метода Rotate

            //Figure[] figures = new Figure[2];
            //figures[0] = new Figure_Q(2, 5, '0');
            //figures[0].Draw();
            //Thread.Sleep(500);
            //figures[0].Hide();
            //figures[0].Rotate();
            //figures[1].Draw();

            //figures[1] = new Figure_I(8, 5, '0');
            //figures[1].Draw();
            //Thread.Sleep(500);
            //figures[1].Hide();
            //figures[1].Rotate();
            //figures[1].Draw();

            //figures[2] = new Figure_T(10, 2, '0');
            //figures[2].Draw();
            //Thread.Sleep(500);
            //figures[2].Hide();
            //figures[2].Rotate();

            //figures[3] = new Figure_J(15, 10, '0');
            //figures[3].Draw();
            //Thread.Sleep(500);
            //figures[3].Hide();
            //figures[3].Rotate();

            //figures[4] = new Figure_L(20, 5, '0');
            //figures[4].Draw();
            //Thread.Sleep(500);
            //figures[4].Hide();
            //figures[4].Rotate();

            //figures[5] = new Figure_S(25, 20, '0');
            //figures[5].Draw();
            //Thread.Sleep(500);
            //figures[5].Hide();
            //figures[5].Rotate();

            //figures[6] = new Figure_Z(22, 25, '0');
            //figures[6].Draw();
            //Thread.Sleep(500);
            //figures[6].Hide();
            //figures[6].Rotate();

            //Console.ReadLine();
        }
    }
}
