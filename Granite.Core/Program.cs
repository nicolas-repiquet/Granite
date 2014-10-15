using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Granite.Core
{
    public class Program : ApplicationResource
    {
        private readonly VertexShader m_vertexShader;
        private readonly FragmentShader m_fragmentShader;
        private readonly uint m_name;
        private readonly ProgramAttribute[] m_attributes;
        private readonly ProgramUniform[] m_uniforms;

        public Program(VertexShader vertexShader, FragmentShader fragmentShader)
        {
            m_vertexShader = vertexShader;
            m_fragmentShader = fragmentShader;

            m_name = GL.CreateProgram();
            GL.AttachShader(m_name, vertexShader.Name);
            GL.AttachShader(m_name, fragmentShader.Name);
            GL.LinkProgram(m_name);
            int linkStatus;
            GL.GetProgramiv(m_name, GL.LINK_STATUS, out linkStatus);
            if (linkStatus == 0)
            {
                byte[] buffer = new byte[4096];
                int length;
                GL.GetProgramInfoLog(m_name, buffer.Length, out length, buffer);
                string log = Encoding.ASCII.GetString(buffer, 0, length);
                throw new Exception(log);
            }

            var uniforms = new List<ProgramUniform>();
            int uniformCount;
            GL.GetProgramiv(m_name, GL.ACTIVE_UNIFORMS, out uniformCount);
            for (uint i = 0; i < uniformCount; i++)
            {
                var buffer = new byte[4096];
                int length;
                int size;
                uint type;
                GL.GetActiveUniform(m_name, i, buffer.Length, out length, out size, out type, buffer);
                var uniformName = Encoding.ASCII.GetString(buffer, 0, length);
                var position = GL.GetUniformLocation(m_name, buffer);
                uniforms.Add(ProgramUniform.Create(this, type, uniformName, position));
            }
            m_uniforms = uniforms.ToArray();

            var attributes = new List<ProgramAttribute>();
            int attribCount;
            GL.GetProgramiv(m_name, GL.ACTIVE_ATTRIBUTES, out attribCount);
            for (uint i = 0; i < attribCount; i++)
            {
                var buffer = new byte[4096];
                int length;
                int size;
                uint type;
                GL.GetActiveAttrib(m_name, i, buffer.Length, out length, out size, out type, buffer);
                var attribName = Encoding.ASCII.GetString(buffer, 0, length);
                var position = GL.GetAttribLocation(m_name, buffer);
                attributes.Add(ProgramAttribute.Create(this, type, attribName, position));
            }
            m_attributes = attributes.ToArray();
        }

        public IEnumerable<ProgramUniform> Uniforms { get { return m_uniforms; } }

        public ProgramUniform<T> GetUniform<T>(string name)
        {
            foreach (var uniform in m_uniforms)
            {
                if (uniform.Name == name && uniform is ProgramUniform<T>)
                {
                    return (ProgramUniform<T>)uniform;
                }
            }

            return null;
        }

        public IEnumerable<ProgramAttribute> Attributes { get { return m_attributes; } }

        public ProgramAttribute<T> GetAttribute<T>(string name)
        {
            foreach (var attribute in m_attributes)
            {
                if (attribute.Name == name && attribute is ProgramAttribute<T>)
                {
                    return (ProgramAttribute<T>)attribute;
                }
            }

            return null;
        }

        internal uint Name { get { return m_name; } }

        protected override void InternalDispose()
        {
            var name = m_name;

            Engine.ExecuteAction(() =>
            {
                GL.DeleteProgram(m_name);
            });
        }
    }

    #region ATTRIBUTES
    public abstract class ProgramAttribute
    {
        #region FACTORY
        internal static ProgramAttribute Create(Program program, uint type, string name, int position)
        {
            switch (type)
            {
                case GL.FLOAT_VEC2:
                    return new ProgramAttribute_FloatVec2(program, name, position);
                case GL.FLOAT_VEC3:
                    return new ProgramAttribute_FloatVec3(program, name, position);
                case GL.FLOAT_VEC4:
                    return new ProgramAttribute_FloatVec4(program, name, position);
                case GL.FLOAT_MAT4:
                    return new ProgramAttribute_FloatMatrix4(program, name, position);
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
        public int Position { get { return m_position; } }
    }

    public abstract class ProgramAttribute<T> : ProgramAttribute
    {
        internal ProgramAttribute(Program program, string name, int position)
            : base(program, name, position)
        {

        }

        public virtual void SetValue(IBufferView view)
        {
            GL.BindBuffer(GL.ARRAY_BUFFER, view.Buffer.Name);
            GL.VertexAttribPointer(
                (uint)Position,
                view.Size,
                view.Type,
                true,
                view.Stride,
                new IntPtr(view.Offset)
            );
            GL.EnableVertexAttribArray((uint)Position);
        }

        public virtual void SetDivisor(int divisor)
        {
            GL.VertexAttribDivisor((uint)Position, (uint)divisor);
        }
    }

    public sealed class ProgramAttribute_FloatVec2 : ProgramAttribute<Vector2>
    {
        internal ProgramAttribute_FloatVec2(Program program, string name, int position)
            : base(program, name, position)
        {

        }
    }

    public sealed class ProgramAttribute_FloatVec3 : ProgramAttribute<Vector3>
    {
        internal ProgramAttribute_FloatVec3(Program program, string name, int position)
            : base(program, name, position)
        {

        }
    }

    public sealed class ProgramAttribute_FloatVec4 : ProgramAttribute<Vector4>
    {
        internal ProgramAttribute_FloatVec4(Program program, string name, int position)
            : base(program, name, position)
        {

        }
    }

    public sealed class ProgramAttribute_FloatMatrix4 : ProgramAttribute<Matrix4>
    {
        internal ProgramAttribute_FloatMatrix4(Program program, string name, int position)
            : base(program, name, position)
        {

        }

        public override void SetValue(IBufferView view)
        {
            uint pos1 = (uint)Position + 0;
            uint pos2 = (uint)Position + 1;
            uint pos3 = (uint)Position + 2;
            uint pos4 = (uint)Position + 3;

            GL.EnableVertexAttribArray(pos1);
            GL.EnableVertexAttribArray(pos2);
            GL.EnableVertexAttribArray(pos3);
            GL.EnableVertexAttribArray(pos4);

            GL.VertexAttribPointer(pos1, 4, GL.FLOAT, false, view.Stride, new IntPtr(view.Offset));
            GL.VertexAttribPointer(pos2, 4, GL.FLOAT, false, view.Stride, new IntPtr(view.Offset + 16));
            GL.VertexAttribPointer(pos3, 4, GL.FLOAT, false, view.Stride, new IntPtr(view.Offset + 32));
            GL.VertexAttribPointer(pos4, 4, GL.FLOAT, false, view.Stride, new IntPtr(view.Offset + 48));
        }

        public override void SetDivisor(int divisor)
        {
            GL.VertexAttribDivisor((uint)Position + 0, (uint)divisor);
            GL.VertexAttribDivisor((uint)Position + 1, (uint)divisor);
            GL.VertexAttribDivisor((uint)Position + 2, (uint)divisor);
            GL.VertexAttribDivisor((uint)Position + 3, (uint)divisor);
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
                case GL.FLOAT:
                    return new ProgramUniform_Float(program, name, position);
                case GL.FLOAT_MAT4:
                    return new ProgramUniform_Mat44f(program, name, position);
                case GL.SAMPLER_2D:
                    return new ProgramUniform_Texture2d(program, name, position);
                case GL.FLOAT_VEC2:
                    return new ProgramUniform_Vector2(program, name, position);
                case GL.FLOAT_VEC3:
                    return new ProgramUniform_Vector3(program, name, position);
                case GL.FLOAT_VEC4:
                    return new ProgramUniform_Vector4(program, name, position);
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
        public int Position { get { return m_position; } }
    }

    public abstract class ProgramUniform<T> : ProgramUniform
    {
        internal ProgramUniform(Program program, string name, int position)
            : base(program, name, position)
        {

        }

        public abstract void SetValue(T value);
    }

    public sealed class ProgramUniform_Float : ProgramUniform<float>
    {
        internal ProgramUniform_Float(Program program, string name, int position)
            : base(program, name, position)
        {

        }

        public override void SetValue(float value)
        {
            GL.Uniform1f(Position, value);
        }
    }

    public sealed class ProgramUniform_Mat44f : ProgramUniform<Matrix4>
    {
        internal ProgramUniform_Mat44f(Program program, string name, int position)
            : base(program, name, position)
        {

        }

        public override void SetValue(Matrix4 value)
        {
            GL.UniformMatrix4fv(Position, 1, false, ref value);
        }
    }

    public sealed class ProgramUniform_Vector2 : ProgramUniform<Vector2>
    {
        internal ProgramUniform_Vector2(Program program, string name, int position)
            : base(program, name, position)
        {

        }

        public override void SetValue(Vector2 value)
        {
            GL.Uniform2f(Position, value);
        }
    }

    public sealed class ProgramUniform_Vector3 : ProgramUniform<Vector3>
    {
        internal ProgramUniform_Vector3(Program program, string name, int position)
            : base(program, name, position)
        {

        }

        public override void SetValue(Vector3 value)
        {
            GL.Uniform3f(Position, value);
        }
    }

    public sealed class ProgramUniform_Vector4 : ProgramUniform<Vector4>
    {
        internal ProgramUniform_Vector4(Program program, string name, int position)
            : base(program, name, position)
        {

        }

        public override void SetValue(Vector4 value)
        {
            GL.Uniform4f(Position, value);
        }
    }

    public sealed class ProgramUniform_Texture2d : ProgramUniform<Texture2D>
    {
        internal ProgramUniform_Texture2d(Program program, string name, int position)
            : base(program, name, position)
        {

        }

        public override void SetValue(Texture2D value)
        {
            if (value != null)
            {
                GL.ActiveTexture(GL.TEXTURE0);
                GL.BindTexture(GL.TEXTURE_2D, value.Name);
                GL.Uniform1i(Position, 0);
            }
        }
    }
    #endregion
}
