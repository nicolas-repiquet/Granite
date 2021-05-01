using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Temple3D.Programs;

namespace Temple3D
{
    public class Mesh
    {
        public Mesh(Vertex[] vertices, uint[] elements)
        {
            _verticesBuffer = new Buffer<Vertex>(BufferTarget.Array, BufferUsage.StaticDraw);
            _elementsBuffer = new Buffer<uint>(BufferTarget.ElementArray, BufferUsage.StaticDraw);
            _program = BasicProgram.Instance;
            _vao = new VertexArray();

            using (_vao.Bind())
            {
                _verticesBuffer.Bind();
                _verticesBuffer.SetData(vertices);

                _elementsBuffer.Bind();
                _elementsBuffer.SetData(elements);

                _program.Bind();
                _program.Position.SetValue(_verticesBuffer.GetView(v => v.Position));
            }
        }

        private readonly VertexArray _vao;
        private readonly BasicProgram _program;
        private readonly Buffer<Vertex> _verticesBuffer;
        private readonly Buffer<uint> _elementsBuffer;

        public void Draw(Matrix4 transform, Color3 color)
        {
            _program.Bind();

            using (_vao.Bind())
            {
                _program.Transform.SetValue(transform);
                _program.Color.SetValue(new Vector3(color.R, color.G, color.B));

                GL.DrawElements(GL.TRIANGLES, _elementsBuffer.Count, GL.UNSIGNED_INT, IntPtr.Zero);
            }
        }
    }
}