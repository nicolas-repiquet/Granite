using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test.Game_02.Shaders
{
    public sealed class TriangleProgram : Program
    {
        public ProgramAttribute<Vector3> Position { get; private set; }
        public ProgramAttribute<Vector3> Normal { get; private set; }
        public ProgramAttribute<Matrix4> Transform { get; private set; }
        public ProgramAttribute<Vector4> Color { get; private set; }
        public ProgramAttribute<Vector2> TextureOrigin { get; private set; }
        public ProgramAttribute<Vector2> TextureTarget { get; private set; }

        public ProgramUniform<Texture2D> Texture { get; private set; }
        public ProgramUniform<Matrix4> Projection { get; private set; }

        private TriangleProgram()
            : base(
                vertex: new VertexShader(typeof(TriangleProgram).GetAssociatedResource("Vertex.glsl")),
                fragment: new FragmentShader(typeof(TriangleProgram).GetAssociatedResource("Fragment.glsl"))
                )
        {
            Position = GetAttribute<Vector3>("positionAttrib");
            Normal = GetAttribute<Vector3>("normalAttrib");
            Transform = GetAttribute<Matrix4>("transformAttrib");
            Color = GetAttribute<Vector4>("colorAttrib");
            TextureOrigin = GetAttribute<Vector2>("textOriginAttrib");
            TextureTarget = GetAttribute<Vector2>("textTargetAttrib");

            Texture = GetUniform<Texture2D>("texture");
            Projection = GetUniform<Matrix4>("projection");
            
        }

        private static TriangleProgram s_instance;
        public static TriangleProgram Instance
        {
            get
            {
                if (s_instance == null)
                {
                    s_instance = new TriangleProgram();
                }

                return s_instance;
            }
        }
    }
}