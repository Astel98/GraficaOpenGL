using System;
using System.Collections.Generic;
using System.Text;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace GraficaTareita
{
    public class Cubo
    {
        private float ancho;
        private float alto;
        private float profundidad;
        public Punto origen;

        public Cubo(Punto p, float ancho, float alto, float profundidad)
        {
            origen = p;
            this.ancho = ancho;
            this.alto = alto;
            this.profundidad = profundidad;
        }

        public void Dibujar()
        {
            PrimitiveType primitiveType = PrimitiveType.Quads;
            back(primitiveType);
            left(primitiveType);
            right(primitiveType);
            top(primitiveType);
            front(primitiveType);
            bottom(primitiveType);
        }

        private void right(PrimitiveType primitiveType)
        {
            GL.Begin(primitiveType);
            GL.Color3(1.0, 1.0, 0.0);
            GL.Vertex3(origen.x + ancho, origen.y + alto, origen.z - profundidad);
            GL.Vertex3(origen.x + ancho, origen.y + alto, origen.z + profundidad);
            GL.Vertex3(origen.x + ancho, origen.y - alto, origen.z + profundidad);
            GL.Vertex3(origen.x + ancho, origen.y - alto, origen.z - profundidad);
            GL.End();
        }

        private void left(PrimitiveType primitiveType)
        {
            GL.Begin(primitiveType);
            GL.Color3(1.0, 1.0, 0.0);
            GL.Vertex3(origen.x - ancho, origen.y + alto, origen.z - profundidad);
            GL.Vertex3(origen.x - ancho, origen.y + alto, origen.z + profundidad);
            GL.Vertex3(origen.x - ancho, origen.y - alto, origen.z + profundidad);
            GL.Vertex3(origen.x - ancho, origen.y - alto, origen.z - profundidad);
            GL.End();
        }

        private void front(PrimitiveType primitiveType)
        {
            GL.Begin(primitiveType);
            GL.Color3(1.0, 1.0, 0.0);
            GL.Vertex3(origen.x - ancho, origen.y + alto, origen.z + profundidad);
            GL.Vertex3(origen.x + ancho, origen.y + alto, origen.z + profundidad);
            GL.Vertex3(origen.x + ancho, origen.y - alto, origen.z + profundidad);
            GL.Vertex3(origen.x - ancho, origen.y - alto, origen.z + profundidad);
            GL.End();
        }

        private void back(PrimitiveType primitiveType)
        {
            GL.Begin(primitiveType);
            GL.Color3(1.0, 1.0, 0.0);
            GL.Vertex3(origen.x - ancho, origen.y + alto, origen.z - profundidad);
            GL.Vertex3(origen.x + ancho, origen.y + alto, origen.z - profundidad);
            GL.Vertex3(origen.x + ancho, origen.y - alto, origen.z - profundidad);
            GL.Vertex3(origen.x - ancho, origen.y - alto, origen.z - profundidad);
            GL.End();
        }

        private void bottom(PrimitiveType primitiveType)
        {
            GL.Begin(primitiveType);
            GL.Color3(1.0, 1.0, 0.0);
            GL.Vertex3(origen.x - ancho, origen.y - alto, origen.z - profundidad);
            GL.Vertex3(origen.x + ancho, origen.y - alto, origen.z - profundidad);
            GL.Vertex3(origen.x + ancho, origen.y - alto, origen.z + profundidad);
            GL.Vertex3(origen.x - ancho, origen.y - alto, origen.z + profundidad);
            GL.End();
        }

        private void top(PrimitiveType primitiveType)
        {
            GL.Begin(primitiveType);
            GL.Color3(1.0, 1.0, 0.0);
            GL.Vertex3(origen.x - ancho, origen.y + alto, origen.z - profundidad);
            GL.Vertex3(origen.x + ancho, origen.y + alto, origen.z - profundidad);
            GL.Vertex3(origen.x + ancho, origen.y + alto, origen.z + profundidad);
            GL.Vertex3(origen.x - ancho, origen.y + alto, origen.z + profundidad);
            GL.End();
        }
    }
}
