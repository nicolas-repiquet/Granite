﻿using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zombie.Game.Shaders
{
    public sealed class TriangleProgram : Program
    {
        public ProgramAttribute<Vector3> Position { get; private set; }
        public ProgramAttribute<Color4ub> Color { get; private set; }

        public ProgramUniform<Matrix4> Projection { get; private set; }

        private TriangleProgram()
            : base(
                vertex: new VertexShader(typeof(TriangleProgram).GetAssociatedResource("Vertex.glsl")),
                fragment: new FragmentShader(typeof(TriangleProgram).GetAssociatedResource("Fragment.glsl"))
                )
        {
            Position = GetAttribute<Vector3>("positionAttrib");
            Color = GetAttribute<Color4ub>("colorAttrib", normalized: true);

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