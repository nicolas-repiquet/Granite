using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Temple3D.Programs;

namespace Temple3D
{
    public class Grid
    {
        public Grid(Vector3 center, float size, int steps)
        {
            var vertices = new List<Vector3>();

            var size2 = size / 2;
            var xmin = center.X - size2;
            var xmax = center.X + size2;
            var ymin = center.Y - size2;
            var ymax = center.Y + size2;
            var stepSize = size / steps;

            for (int i = 0; i <= steps; i++)
            {
                var offset = stepSize * i;

                // x
                var x = xmin + offset;
                vertices.Add(new Vector3(x, ymin, center.Z));
                vertices.Add(new Vector3(x, ymax, center.Z));

                // y
                var y = ymin + offset;
                vertices.Add(new Vector3(xmin, y, center.Z));
                vertices.Add(new Vector3(xmax, y, center.Z));
            }

            _verticesBuffer = new Buffer<Vector3>(BufferTarget.Array, BufferUsage.StaticDraw);
            _program = GridProgram.Instance;
            _vao = new VertexArray();

            using (_vao.Bind())
            {

                _verticesBuffer.Bind();
                _verticesBuffer.SetData(vertices.ToArray());

                _program.Bind();
                _program.Position.SetValue(_verticesBuffer.GetView());

            }
        }

        private readonly VertexArray _vao;
        private readonly GridProgram _program;
        private readonly Buffer<Vector3> _verticesBuffer;

        public void Draw(Matrix4 transform)
        {
            _program.Bind();

            using (_vao.Bind())
            {
                _program.Transform.SetValue(transform);
                GL.DrawArrays(GL.LINES, 0, _verticesBuffer.Count);
            }
        }
    }
}