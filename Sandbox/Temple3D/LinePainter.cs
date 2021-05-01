using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Temple3D.Programs;

namespace Temple3D
{
    public class LinePainter
    {
        public LinePainter()
        {
            _vertices = new Vertex[2000];

            _verticesBuffer = new Buffer<Vertex>(BufferTarget.Array, BufferUsage.StreamDraw);
            _program = BasicProgram.Instance;
        }

        private readonly BasicProgram _program;
        private readonly Buffer<Vertex> _verticesBuffer;

        private readonly Vertex[] _vertices;
        private int _vertexCount = 0;

        public void AddLine(Vector3 p0, Vector3 p1, Color3 c)
        {
            if (_vertexCount == _vertices.Length)
            {
                return;
            }

            _vertices[_vertexCount++] = new Vertex { Position = p0, Color = c };
            _vertices[_vertexCount++] = new Vertex { Position = p1, Color = c };
        }

        public void Clear()
        {
            _vertexCount = 0;
        }

        public void Draw(Matrix4 transform, Color3 color)
        {
            _verticesBuffer.Bind();
            _verticesBuffer.Clear(); // orphaning
            _verticesBuffer.SetData(_vertices, 0, _vertexCount);

            _program.Bind();
            _program.Transform.SetValue(transform);
            _program.Position.SetValue(_verticesBuffer.GetView(v => v.Position));
            _program.Color.SetValue(new Vector3(color.R, color.G, color.B));

            GL.DrawArrays(GL.LINES, 0, _vertexCount);

            Program.Unbind();
            _verticesBuffer.Unbind();
        }
    }
}
