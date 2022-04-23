using System;
using System.Collections.Generic;
using System.Text;

namespace GraficaTareita
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Juego juego = new Juego(800, 600, "Casita");
            juego.Run(60);
        }
    }
}
