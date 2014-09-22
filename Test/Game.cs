using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test
{
    public sealed class Game : ApplicationLogicBase
    {
        private Buffer<Vector2d> m_vertices;

        public override void Start()
        {
            m_vertices = new Buffer<Vector2d>();
            m_vertices.SetData(new Vector2d[] {
                new Vector2d(0.5, 0.5),
                new Vector2d(-0.5, 0.5),
                new Vector2d(-0.5, -0.5),
                new Vector2d(0.5, -0.5)
            });
        }

        public override void Render()
        {
            GL.Viewport(Engine.Display.GetSize());

            GL.ClearColor(0.2f, 0.2f, 0.3f, 1.0f);
            GL.Clear(GL.COLOR_BUFFER_BIT | GL.DEPTH_BUFFER_BIT);

            GL.BindBuffer(GL.ARRAY_BUFFER, m_vertices);
            GL.VertexAttribPointer(0, 3, GL.DOUBLE, false, 0, IntPtr.Zero);
            GL.EnableVertexAttribArray(0);
            GL.DrawElements(GL.TRIANGLES, new byte[] { 0, 1, 2,  1, 2, 0, 2, 0, 1 });


        }

    }
}
