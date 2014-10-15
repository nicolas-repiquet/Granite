using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Granite.UI.Shaders
{
    public sealed class QuadProgram : Program
    {
        public ProgramUniform<Vector2i> ScreenSize { get; private set; }
        public ProgramAttribute<Vector2> Vertex { get; private set; }
        public ProgramAttribute<Vector2> Position { get; private set; }
        public ProgramAttribute<Vector2> Size { get; private set; }
        public ProgramAttribute<int> BorderThickness { get; private set; }
        public ProgramAttribute<int> CornerRadius { get; private set; }

        private QuadProgram()
            : base(
                    vertex: new VertexShader(typeof(QuadProgram).GetAssociatedResource("Vertex.glsl")),
                    fragment: new FragmentShader(typeof(QuadProgram).GetAssociatedResource("Fragment.glsl"))
                )
        {
            ScreenSize = GetUniform<Vector2i>("screen_size");
            Vertex = GetAttribute<Vector2>("vertex");
            Position = GetAttribute<Vector2>("position");
            Size = GetAttribute<Vector2>("size");
            BorderThickness = GetAttribute<int>("border_thickness");
            CornerRadius = GetAttribute<int>("corner_radius");
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
