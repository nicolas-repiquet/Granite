using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Granite.UI.Shaders
{
    public sealed class QuadProgram : Program
    {
        public ProgramUniform<Texture2D>[] Textures { get; private set; }

        public ProgramAttribute<Vector2> Vertex { get; private set; }
        public ProgramAttribute<Matrix3x2> Transform { get; private set; }
        public ProgramAttribute<Color4ub> Color { get; private set; }
        public ProgramAttribute<int> Texture { get; private set; }
        public ProgramAttribute<Vector2> TextureCoordinates0 { get; private set; }
        public ProgramAttribute<Vector2> TextureCoordinates1 { get; private set; }

        private QuadProgram()
            : base(
                    vertex: new VertexShader(typeof(QuadProgram).GetAssociatedResource("Vertex.glsl")),
                    fragment: new FragmentShader(typeof(QuadProgram).GetAssociatedResource("Fragment.glsl"))
                )
        {
            Textures = new ProgramUniform<Texture2D>[] {
                GetUniform<Texture2D>("texture0", GL.TEXTURE0),
                GetUniform<Texture2D>("texture1", GL.TEXTURE1),
                GetUniform<Texture2D>("texture2", GL.TEXTURE2),
                GetUniform<Texture2D>("texture3", GL.TEXTURE3),
                GetUniform<Texture2D>("texture4", GL.TEXTURE4),
                GetUniform<Texture2D>("texture5", GL.TEXTURE5),
                GetUniform<Texture2D>("texture6", GL.TEXTURE6),
                GetUniform<Texture2D>("texture7", GL.TEXTURE7)
            };

            Vertex = GetAttribute<Vector2>("vertex");
            Transform = GetAttribute<Matrix3x2>("transform");
            Color = GetAttribute<Color4ub>("color", normalized: true);
            Texture = GetAttribute<int>("texture");
            TextureCoordinates0 = GetAttribute<Vector2>("texture_coordinates0");
            TextureCoordinates1 = GetAttribute<Vector2>("texture_coordinates1");
        }

        private static QuadProgram s_instance;
        public static QuadProgram Instance
        {
            get
            {
                if (s_instance == null)
                {
                    s_instance = new QuadProgram();
                }

                return s_instance;
            }
        }
    }
}
