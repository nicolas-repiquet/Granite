using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temple3D.Programs
{
    public class BasicProgram : Program
    {
        private BasicProgram() : base(
            vertex: new VertexShader(typeof(BasicProgram).GetAssociatedResource("vert.glsl")),
            fragment: new FragmentShader(typeof(BasicProgram).GetAssociatedResource("frag.glsl")))
        {
            Transform = GetUniform<Matrix4>("transform");
            Color = GetUniform<Vector3>("color");

            Position = GetAttribute<Vector3>("position");
        }

        public ProgramUniform<Matrix4> Transform { get; }
        public ProgramUniform<Vector3> Color { get; }

        public ProgramAttribute<Vector3> Position { get; }

        private static BasicProgram _instance;

        public static BasicProgram Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BasicProgram();
                }

                return _instance;
            }
        }
    }
}

