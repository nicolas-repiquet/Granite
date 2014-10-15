using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test.Game_01.Shaders
{
    public sealed class SpriteProgram : Program
    {
        public ProgramAttribute<Vector3> Position { get; private set; }
        public ProgramAttribute<Matrix4> Transform { get; private set; }
        public ProgramAttribute<Vector4> Color { get; private set; }
        public ProgramAttribute<Vector2> TextureCoordinates0 { get; private set; }
        public ProgramAttribute<Vector2> TextureCoordinates1 { get; private set; }
        public ProgramAttribute<Vector2> TextureCoordinates2 { get; private set; }
        public ProgramAttribute<Vector2> TextureCoordinates3 { get; private set; }

        public ProgramUniform<Texture2D> Texture { get; private set; }
        public ProgramUniform<Matrix4> Projection { get; private set; }

        private SpriteProgram()
            : base(
                vertex: new VertexShader(typeof(SpriteProgram).GetAssociatedResource("Vertex.glsl")),
                fragment: new FragmentShader(typeof(SpriteProgram).GetAssociatedResource("Fragment.glsl"))
                )
        {
            Position = GetAttribute<Vector3>("positionAttrib");
            Transform = GetAttribute<Matrix4>("transformAttrib");
            //Color = GetAttribute<Vector4>("colorAttrib");
            TextureCoordinates0 = GetAttribute<Vector2>("textCoordAttrib0");
            TextureCoordinates1 = GetAttribute<Vector2>("textCoordAttrib1");
            TextureCoordinates2 = GetAttribute<Vector2>("textCoordAttrib2");
            TextureCoordinates3 = GetAttribute<Vector2>("textCoordAttrib3");

            Texture = GetUniform<Texture2D>("texture");
            Projection = GetUniform<Matrix4>("projection");
            
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