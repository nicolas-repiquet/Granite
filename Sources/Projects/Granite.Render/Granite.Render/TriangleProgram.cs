using Granite.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Granite.Render
{
    public class TriangleProgram : Program
    {
        public ProgramAttribute<Vector2> Position { get; private set; }
        public ProgramAttribute<Color4ub> Color { get; private set; }
        public ProgramAttribute<Vector2> TextureCoordinates { get; private set; }

        public ProgramUniform<Texture2D> Texture { get; private set; }
        public ProgramUniform<Matrix4> Projection { get; private set; }

        public TriangleProgram(Stream vertex, Stream fragment)
            : base(
                vertex: new VertexShader(vertex),
                fragment: new FragmentShader(fragment)
                )
        {
            Position = GetAttribute<Vector2>("position");
            Color = GetAttribute<Color4ub>("color", true);
            TextureCoordinates = GetAttribute<Vector2>("textCoordinates");

            //Texture = GetUniform<Texture2D>("texture");
            Projection = GetUniform<Matrix4>("projection");
            
        }
    }
}
