using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Granite3D
{
    public sealed class Program : EngineResource
    {
        private readonly VertexShader m_vertexShader;
        private readonly FragmentShader m_fragmentShader;
        private readonly uint m_name;
        private readonly ProgramAttribute[] m_attributes;
        private readonly ProgramUniform[] m_uniforms;

        internal Program(Engine engine, VertexShader vertexShader, FragmentShader fragmentShader)
            : base(engine)
        {
            m_vertexShader = vertexShader;
            m_fragmentShader = fragmentShader;

            m_name = Engine.Gl.glCreateProgram();
            Engine.Gl.glAttachShader(m_name, vertexShader.Name);
            Engine.Gl.glAttachShader(m_name, fragmentShader.Name);
            Engine.Gl.glLinkProgram(m_name);
            int linkStatus;
            Engine.Gl.glGetProgramiv(m_name, GlApi.GL_LINK_STATUS, out linkStatus);
            if (linkStatus == 0)
            {
                byte[] buffer = new byte[4096];
                int length;
                Engine.Gl.glGetProgramInfoLog(m_name, buffer.Length, out length, buffer);
                string log = Encoding.ASCII.GetString(buffer, 0, length);
                throw new Exception(log);
            }

            var uniforms = new List<ProgramUniform>();
            int uniformCount;
            Engine.Gl.glGetProgramiv(m_name, GlApi.GL_ACTIVE_UNIFORMS, out uniformCount);
            for (uint i = 0; i < uniformCount; i++)
            {
                var buffer = new byte[4096];
                int length;
                int size;
                uint type;
                Engine.Gl.glGetActiveUniform(m_name, i, buffer.Length, out length, out size, out type, buffer);
                var uniformName = Encoding.ASCII.GetString(buffer, 0, length);
                var position = Engine.Gl.glGetUniformLocation(m_name, buffer);
                uniforms.Add(ProgramUniform.Create(this, type, uniformName, position));
            }
            m_uniforms = uniforms.ToArray();

            var attributes = new List<ProgramAttribute>();
            int attribCount;
            Engine.Gl.glGetProgramiv(m_name, GlApi.GL_ACTIVE_ATTRIBUTES, out attribCount);
            for (uint i = 0; i < attribCount; i++)
            {
                var buffer = new byte[4096];
                int length;
                int size;
                uint type;
                Engine.Gl.glGetActiveAttrib(m_name, i, buffer.Length, out length, out size, out type, buffer);
                var attribName = Encoding.ASCII.GetString(buffer, 0, length);
                var position = Engine.Gl.glGetAttribLocation(m_name, buffer);
                attributes.Add(ProgramAttribute.Create(this, type, attribName, position));
            }
            m_attributes = attributes.ToArray();
        }

        public IEnumerable<ProgramUniform> Uniforms { get { return m_uniforms; } }
        public IEnumerable<ProgramAttribute> Attributes { get { return m_attributes; } }

        internal uint Name { get { return m_name; } }

        public ProgramInstance CreateInstance(Dictionary<string,IBufferView> attributeValues)
        {
            return new ProgramInstance(this, attributeValues);
        }

        protected override void InternalDispose()
        {
            var name = m_name;

            Engine.ExecuteAction(() =>
            {
                Engine.Gl.glDeleteProgram(m_name);
            });
        }
    }

    #region PROGRAM INSTANCE
    public sealed class ProgramInstance : EngineResource
    {
        private readonly Program m_program;
        private readonly uint m_name;
        private readonly Dictionary<ProgramAttribute, IBufferView> m_attributeValues;
        private readonly Dictionary<ProgramUniform, object> m_uniformValues;

        internal ProgramInstance(Program program, Dictionary<string, IBufferView> attributeValues)
            : base(program.Engine)
        {
            m_program = program;
            m_attributeValues = new Dictionary<ProgramAttribute, IBufferView>();
            m_uniformValues = new Dictionary<ProgramUniform, object>();

            foreach (var attribute in m_program.Attributes)
            {
                IBufferView view;
                if (attributeValues.TryGetValue(attribute.Name, out view))
                {
                    m_attributeValues.Add(attribute, view);
                }
            }

            uint name;
            Engine.Gl.glGenVertexArrays(1, out name);
            m_name = name;

            Engine.Gl.glBindVertexArray(m_name);

            foreach (var entry in m_attributeValues)
            {
                var attribute = entry.Key;
                var view = entry.Value;

                Engine.Gl.glBindBuffer(GlApi.GL_ARRAY_BUFFER, view.Buffer.Name);
                Engine.Gl.glVertexAttribPointer(
                    (uint)attribute.Position,
                    view.Size,
                    view.Type,
                    0xFF,
                    view.Stride,
                    new IntPtr(view.Offset)
                );
                Engine.Gl.glBindBuffer(GlApi.GL_ARRAY_BUFFER, 0);
                Engine.Gl.glEnableVertexAttribArray((uint)attribute.Position);
            }

            Engine.Gl.glBindVertexArray(0);
        }

        public void SetUniform(string name, object value)
        {
            var uniform = m_program.Uniforms.Where(u => u.Name == name).FirstOrDefault();

            if (uniform != null)
            {
                m_uniformValues[uniform] = value;
            }
        }

        public void Draw()
        {
            Engine.Gl.glUseProgram(m_program.Name);
            foreach (var entry in m_uniformValues)
            {
                entry.Key.SetValue(entry.Value);
            }
            Engine.Gl.glBindVertexArray(m_name);
            Engine.Gl.glDrawArrays(GlApi.GL_TRIANGLES, 0, 36);
            Engine.Gl.glBindVertexArray(0);
            Engine.Gl.glUseProgram(0);
        }

        protected override void InternalDispose()
        {
            var name = m_name;

            Engine.ExecuteAction(() =>
            {
                Engine.Gl.glDeleteVertexArrays(1, out name);
            });
        }
    }
    #endregion

    #region ATTRIBUTES
    public abstract class ProgramAttribute
    {
        #region FACTORY
        internal static ProgramAttribute Create(Program program, uint type, string name, int position)
        {
            switch (type)
            {
                case GlApi.GL_FLOAT_VEC2:
                    return new ProgramAttribute_FloatVec2(program, name, position);
                case GlApi.GL_FLOAT_VEC3:
                    return new ProgramAttribute_FloatVec3(program, name, position);
                case GlApi.GL_FLOAT_VEC4:
                    return new ProgramAttribute_FloatVec4(program, name, position);
                default:
                    throw new Exception();
            }
        }
        #endregion

        private readonly Program m_program;
        private readonly string m_name;
        private readonly int m_position;

        internal ProgramAttribute(Program program, string name, int position)
        {
            m_program = program;
            m_name = name;
            m_position = position;
        }

        public string Name { get { return m_name; } }
        internal int Position { get { return m_position; } }
    }

    public sealed class ProgramAttribute_FloatVec2 : ProgramAttribute
    {
        internal ProgramAttribute_FloatVec2(Program program, string name, int position)
            : base(program, name, position)
        {

        }
    }

    public sealed class ProgramAttribute_FloatVec3 : ProgramAttribute
    {
        internal ProgramAttribute_FloatVec3(Program program, string name, int position)
            : base(program, name, position)
        {

        }
    }

    public sealed class ProgramAttribute_FloatVec4 : ProgramAttribute
    {
        internal ProgramAttribute_FloatVec4(Program program, string name, int position)
            : base(program, name, position)
        {

        }
    }

    #endregion

    #region UNIFORMS
    public abstract class ProgramUniform
    {
        #region FACTORY
        internal static ProgramUniform Create(Program program, uint type, string name, int position)
        {
            switch (type)
            {
                case GlApi.GL_FLOAT:
                    return new ProgramUniform_Float(program, name, position);
                case GlApi.GL_FLOAT_MAT4:
                    return new ProgramUniform_Mat44f(program, name, position);
                case GlApi.GL_SAMPLER_2D:
                    return new ProgramUniform_Texture2d(program, name, position);
                default:
                    throw new Exception();
            }
        }
        #endregion

        private readonly Program m_program;
        private readonly string m_name;
        private readonly int m_position;

        internal ProgramUniform(Program program, string name, int position)
        {
            m_program = program;
            m_name = name;
            m_position = position;
        }

        public Program Program { get { return m_program; } }
        public string Name { get { return m_name; } }
        internal int Position { get { return m_position; } }

        internal abstract void SetValue(object value);
    }

    public sealed class ProgramUniform_Float : ProgramUniform
    {
        internal ProgramUniform_Float(Program program, string name, int position)
            : base(program, name, position)
        {

        }

        internal override void SetValue(object value)
        {
            Program.Engine.Gl.glUniform1f(Position, (float)value);
        }
    }

    public sealed class ProgramUniform_Mat44f : ProgramUniform
    {
        internal ProgramUniform_Mat44f(Program program, string name, int position)
            : base(program, name, position)
        {

        }

        internal override void SetValue(object value)
        {
            var m = (Matrix4)value;
            Program.Engine.Gl.glUniformMatrix4fv(Position, 1, 0, ref m);
        }
    }

    public sealed class ProgramUniform_Texture2d : ProgramUniform
    {
        internal ProgramUniform_Texture2d(Program program, string name, int position)
            : base(program, name, position)
        {

        }

        internal override void SetValue(object value)
        {
            var t = (Texture2D)value;

            Program.Engine.Gl.glActiveTexture(GlApi.GL_TEXTURE0);
            Program.Engine.Gl.glBindTexture(GlApi.GL_TEXTURE_2D, t.Name);
            Program.Engine.Gl.glUniform1i(Position, 0);
        }
    }
    #endregion
}
