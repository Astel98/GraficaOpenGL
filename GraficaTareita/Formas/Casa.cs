using System;
using System.Collections.Generic;
using System.Text;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace GraficaTareita
{
    public class Casa
    {
        private float ancho;
        private float alto;
        private float profundidad;
        public Punto origen;
        public Punto origenT;
        public Punto origenC;
        public Piramide techo;
        public Cubo cuerpo;

        public Casa(Punto p, float ancho, float alto, float profundidad)
        {
            origen = p;
            this.ancho = ancho;
            this.alto = alto;
            this.profundidad = profundidad;
            techo = new Piramide(new Punto(p.x, p.y + (this.alto / 2), p.z), this.ancho, (this.alto / 2), this.profundidad);
            cuerpo = new Cubo(new Punto(p.x, p.y - (this.alto / 2), p.z), this.ancho, (this.alto / 2), this.profundidad);
        }

        public void Dibujar()
        {
            cuerpo.Dibujar();
            techo.Dibujar();
            
        }

    }
}
