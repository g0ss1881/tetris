using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace TheTetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);

            Figure[] figure = new Figure[1];
            figure[0] = new Figure_Q(2, 2, '0');
            figure[0].Move(Movement.RIGHT);


            Console.ReadLine();
        }
    }
}
