using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Granite.Core
{
    public abstract class ProgramUniform
    {
        #region FACTORY
        internal static ProgramUniform Create(Program program, uint type, string name, int location)
        {
            switch (type)
            {
                case GL.FLOAT: return new ProgramUniformFloat1(program, name, location);
                case GL.FLOAT_VEC2: return new ProgramUniformFloat2(program, name, location);
                case GL.FLOAT_VEC3: return new ProgramUniformFloat3(program, name, location);
                case GL.FLOAT_VEC4: return new ProgramUniformFloat4(program, name, location);

                case GL.INT: return new ProgramUniformInt1(program, name, location);
                case GL.INT_VEC2: return new ProgramUniformInt2(program, name, location);
                case GL.INT_VEC3: return new ProgramUniformInt3(program, name, location);
                case GL.INT_VEC4: return new ProgramUniformInt4(program, name, location);

                case GL.UNSIGNED_INT: return new ProgramUniformUInt1(program, name, location);
                //case GL.UNSIGNED_INT_VEC2:
                //case GL.UNSIGNED_INT_VEC3:
                //case GL.UNSIGNED_INT_VEC4:

                case GL.BOOL: return new ProgramUniformBool1(program, name, location);
                //case GL.BOOL_VEC2:
                //case GL.BOOL_VEC3:
                //case GL.BOOL_VEC4:

                case GL.FLOAT_MAT2: return new ProgramUniformFloatMatrix2(program, name, location);
                case GL.FLOAT_MAT3: return new ProgramUniformFloatMatrix3(program, name, location);
                case GL.FLOAT_MAT4: return new ProgramUniformFloatMatrix4(program, name, location);
                //case GL.FLOAT_MAT2x3:
                //case GL.FLOAT_MAT2x4:
                //case GL.FLOAT_MAT3x2:
                //case GL.FLOAT_MAT3x4:
                //case GL.FLOAT_MAT4x2:
                //case GL.FLOAT_MAT4x3:

                //case GL.SAMPLER_1D:
                case GL.SAMPLER_2D: return new ProgramUniformSampler2D(program, name, location);
                //case GL.SAMPLER_3D:
                //case GL.SAMPLER_CUBE:
                //case GL.SAMPLER_1D_SHADOW:
                //case GL.SAMPLER_2D_SHADOW:
                //case GL.SAMPLER_1D_ARRAY:
                //case GL.SAMPLER_2D_ARRAY:
                //case GL.SAMPLER_1D_ARRAY_SHADOW:
                //case GL.SAMPLER_2D_ARRAY_SHADOW:
                //case GL.SAMPLER_2D_MULTISAMPLE:
                //case GL.SAMPLER_2D_MULTISAMPLE_ARRAY:
                //case GL.SAMPLER_CUBE_SHADOW:
                //case GL.SAMPLER_BUFFER:
                //case GL.SAMPLER_2D_RECT:
                //case GL.SAMPLER_2D_RECT_SHADOW:
                //case GL.INT_SAMPLER_1D:
                //case GL.INT_SAMPLER_2D:
                //case GL.INT_SAMPLER_3D:
                //case GL.INT_SAMPLER_CUBE:
                //case GL.INT_SAMPLER_1D_ARRAY:
                //case GL.INT_SAMPLER_2D_ARRAY:
                //case GL.INT_SAMPLER_2D_MULTISAMPLE:
                //case GL.INT_SAMPLER_2D_MULTISAMPLE_ARRAY:
                //case GL.INT_SAMPLER_BUFFER:
                //case GL.INT_SAMPLER_2D_RECT:
                //case GL.UNSIGNED_INT_SAMPLER_1D:
                //case GL.UNSIGNED_INT_SAMPLER_2D:
                //case GL.UNSIGNED_INT_SAMPLER_3D:
                //case GL.UNSIGNED_INT_SAMPLER_CUBE:
                //case GL.UNSIGNED_INT_SAMPLER_1D_ARRAY:
                //case GL.UNSIGNED_INT_SAMPLER_2D_ARRAY:
                //case GL.UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE:
                //case GL.UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE_ARRAY:
                //case GL.UNSIGNED_INT_SAMPLER_BUFFER:
                //case GL.UNSIGNED_INT_SAMPLER_2D_RECT:

                default:
                    throw new Exception();
            }
        }
        #endregion

        private readonly Program m_program;
        private readonly string m_name;
        private readonly int m_location;

        internal ProgramUniform(Program program, string name, int location)
        {
            m_program = program;
            m_name = name;
            m_location = location;
        }

        public Program Program { get { return m_program; } }
        public string Name { get { return m_name; } }
        public int Location { get { return m_location; } }
    }

    public abstract class ProgramUniform<T> : ProgramUniform
    {
        internal ProgramUniform(Program program, string name, int location)
            : base(program, name, location)
        {

        }

        public abstract void SetValue(T value);
    }

    public sealed class ProgramUniformFloat1 : ProgramUniform<float>
    {
        internal ProgramUniformFloat1(Program program, string name, int location)
            : base(program, name, location)
        {

        }

        public override void SetValue(float value)
        {
            GL.Uniform1f(Location, value);
        }
    }

    public sealed class ProgramUniformFloat2 : ProgramUniform<Vector2>
    {
        internal ProgramUniformFloat2(Program program, string name, int location)
            : base(program, name, location)
        {

        }

        public override void SetValue(Vector2 value)
        {
            GL.Uniform2f(Location, value);
        }
    }

    public sealed class ProgramUniformFloat3 : ProgramUniform<Vector3>
    {
        internal ProgramUniformFloat3(Program program, string name, int location)
            : base(program, name, location)
        {

        }

        public override void SetValue(Vector3 value)
        {
            GL.Uniform3f(Location, value);
        }
    }

    public sealed class ProgramUniformFloat4 : ProgramUniform<Vector4>
    {
        internal ProgramUniformFloat4(Program program, string name, int location)
            : base(program, name, location)
        {

        }

        public override void SetValue(Vector4 value)
        {
            GL.Uniform4f(Location, value);
        }
    }

    public sealed class ProgramUniformInt1 : ProgramUniform<int>
    {
        internal ProgramUniformInt1(Program program, string name, int location)
            : base(program, name, location)
        {

        }

        public override void SetValue(int value)
        {
            GL.Uniform1i(Location, value);
        }
    }

    public sealed class ProgramUniformInt2 : ProgramUniform<Vector2i>
    {
        internal ProgramUniformInt2(Program program, string name, int location)
            : base(program, name, location)
        {

        }

        public override void SetValue(Vector2i value)
        {
            GL.Uniform2i(Location, value);
        }
    }

    public sealed class ProgramUniformInt3 : ProgramUniform<Vector3i>
    {
        internal ProgramUniformInt3(Program program, string name, int location)
            : base(program, name, location)
        {

        }

        public override void SetValue(Vector3i value)
        {
            GL.Uniform3i(Location, value);
        }
    }

    public sealed class ProgramUniformInt4 : ProgramUniform<Vector4i>
    {
        internal ProgramUniformInt4(Program program, string name, int location)
            : base(program, name, location)
        {

        }

        public override void SetValue(Vector4i value)
        {
            GL.Uniform4i(Location, value);
        }
    }

    public sealed class ProgramUniformUInt1 : ProgramUniform<uint>
    {
        internal ProgramUniformUInt1(Program program, string name, int location)
            : base(program, name, location)
        {

        }

        public override void SetValue(uint value)
        {
            GL.Uniform1ui(Location, value);
        }
    }

    public sealed class ProgramUniformBool1 : ProgramUniform<bool>
    {
        internal ProgramUniformBool1(Program program, string name, int location)
            : base(program, name, location)
        {

        }

        public override void SetValue(bool value)
        {
            GL.Uniform1ui(Location, value ? 0u : 1u);
        }
    }

    public sealed class ProgramUniformFloatMatrix2 : ProgramUniform<Matrix2>
    {
        internal ProgramUniformFloatMatrix2(Program program, string name, int location)
            : base(program, name, location)
        {

        }

        public override void SetValue(Matrix2 value)
        {
            GL.UniformMatrix2fv(Location, 1, false, ref value);
        }
    }

    public sealed class ProgramUniformFloatMatrix3 : ProgramUniform<Matrix3>
    {
        internal ProgramUniformFloatMatrix3(Program program, string name, int location)
            : base(program, name, location)
        {

        }

        public override void SetValue(Matrix3 value)
        {
            GL.UniformMatrix3fv(Location, 1, false, ref value);
        }
    }

    public sealed class ProgramUniformFloatMatrix4 : ProgramUniform<Matrix4>
    {
        internal ProgramUniformFloatMatrix4(Program program, string name, int location)
            : base(program, name, location)
        {

        }

        public override void SetValue(Matrix4 value)
        {
            GL.UniformMatrix4fv(Location, 1, false, ref value);
        }
    }

    public sealed class ProgramUniformSampler2D : ProgramUniform<Texture2D>
    {
        internal ProgramUniformSampler2D(Program program, string name, int location)
            : base(program, name, location)
        {

        }

        public override void SetValue(Texture2D value)
        {
            if (value != null)
            {
                GL.ActiveTexture(GL.TEXTURE0);
                GL.BindTexture(GL.TEXTURE_2D, value.Name);
                GL.Uniform1i(Location, 0);
            }
        }
    }
}
