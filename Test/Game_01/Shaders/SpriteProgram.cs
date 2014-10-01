using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test.Game_01.Shaders
{
    public sealed class SpriteProgram : Program
    {
        public ProgramAttribute<Vector2> Position { get; private set; }
        public ProgramAttribute<Vector2> TextureCoordinates { get; private set; }

        public ProgramUniform<Matrix4> Transform { get; private set; }
        public ProgramUniform<Texture2D> Texture { get; private set; }

        private SpriteProgram()
            : base(
                new VertexShader(typeof(SpriteProgram).GetAssociatedResource("Vertex.glsl")),
                new FragmentShader(typeof(SpriteProgram).GetAssociatedResource("Fragment.glsl"))
                )
        {
            Position = GetAttribute<Vector2>("position");
            TextureCoordinates = GetAttribute<Vector2>("texcoord");
            Transform = GetUniform<Matrix4>("transform");
            Texture = GetUniform<Texture2D>("texture");
        }

        private static SpriteProgram s_instance;
        public static SpriteProgram Instance
        {
            get
            {
                if (s_instance == null)
                {
                    s_instance = new SpriteProgram();
                }

                return s_instance;
            }
        }
    }
}