using System;
using System.Collections.Generic;
using System.Text;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace GraficaTareita
{
    public class Partes
    {
        public Punto origen;
        public List<Punto> vertices;

        public Partes(Punto p, List<Punto> vertices)
        {
            origen = p;
            vertices.ForEach( punto => this.vertices.Add(punto));
        }
        public void Dibujar()
        {
            GL.Begin(PrimitiveType.Triangles);
            GL.Color3(1.0, 1.0, 1.0);
            this.vertices.ForEach( vertice => GL.Vertex3(vertice.x, vertice.y, vertice.z));
            GL.End();
        }

    }
}
