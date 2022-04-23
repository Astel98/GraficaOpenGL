using System;
using System.Collections.Generic;
using System.Text;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace GraficaTareita
{
    public class Objeto
    {
        public Punto origen;
        public List<Partes> partes;

        public Objeto(Punto p, List<Partes> partes)
        {
            origen = p;
            partes.ForEach(parte => this.partes.Add(parte));
        }
        public void Dibujar()
        {
            this.partes.ForEach(parte => parte.Dibujar());
        }

    }
}
