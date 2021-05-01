using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temple3D.Programs
{
    public class GridProgram : Program
    {
        private GridProgram() : base(
            vertex: new VertexShader(typeof(GridProgram).GetAssociatedResource("vert.glsl")),
            fragment: new FragmentShader(typeof(GridProgram).GetAssociatedResource("frag.glsl")))
        {
            Transform = GetUniform<Matrix4>("transform");
            Position = GetAttribute<Vector3>("position");
        }

        public ProgramUniform<Matrix4> Transform { get; }
        public ProgramAttribute<Vector3> Position { get; }

        private static GridProgram _instance;

        public static GridProgram Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GridProgram();
                }

                return _instance;
            }
        }
    }
}

