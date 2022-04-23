using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace GraficaTareita
{
    internal class Juego:GameWindow
    {
        public Casa casa;
        public Casa casa2;
        public List<Punto> vertices;

        public Juego(int width, int height, string title) : base(width, height, GraphicsMode.Default, title) { }
        
        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);
        }
       
        protected override void OnLoad(EventArgs e)
        {
            GL.ClearColor(Color4.Black);
            //Inicializando casas con punto de origen distinto
            casa = new Casa(new Punto(), 10, 10, 10);
            casa2 = new Casa(new Punto(15), 10, 10, 10);
            base.OnLoad(e);
        }
       
        protected override void OnUnload(EventArgs e)
        {
            GL.BindBuffer(BufferTarget.ArrayBuffer, 0);
            base.OnUnload(e);
        }
        
        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.DepthMask(true);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.Enable(EnableCap.DepthTest);
            GL.LoadIdentity();

            //Para ver de costado
            GL.Rotate(30, 1, 1 , 0);

            //Dibujando las casas
            this.casa.Dibujar();
            this.casa2.Dibujar();

            Context.SwapBuffers();
            base.OnRenderFrame(e);
        }

        protected override void OnResize(EventArgs e)
        {
            GL.Viewport(0, 0, Width, Height);
            //Definiendo proyeccion
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(-30, 30, -30, 30, -30, 100);
            //Definiendo punto de vista o enfoque
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
            base.OnResize(e);
        }

    }
}
