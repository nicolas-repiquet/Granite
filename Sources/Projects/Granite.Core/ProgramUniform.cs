using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Granite.Core
{
    public sealed class ProgramUniformInfo
    {
        public Program Program { get; private set; }
        public string Name { get; private set; }
        public uint Index { get; private set; }
        public int Location { get; private set; }
        public uint Type { get; private set; }

        public ProgramUniformInfo(Program program, string name, uint index, int location, uint type)
        {
            Program = program;
            Name = name;
            Index = index;
            Location = location;
            Type = type;
        }
    }

    public abstract class ProgramUniform
    {
        public Program Program { get; private set; }
        public ProgramUniformInfo Info { get; private set; }

        internal ProgramUniform(Program program, ProgramUniformInfo info)
        {
            Program = program;
            Info = info;
        }

        #region FACTORY
        internal static ProgramUniform Create(Program program, ProgramUniformInfo info, uint textureUnit)
        {
            switch (info.Type)
            {
                case GL.FLOAT: return new ProgramUniformFloat1(program, info);
                case GL.FLOAT_VEC2: return new ProgramUniformFloat2(program, info);
                case GL.FLOAT_VEC3: return new ProgramUniformFloat3(program, info);
                case GL.FLOAT_VEC4: return new ProgramUniformFloat4(program, info);

                case GL.INT: return new ProgramUniformInt1(program, info);
                case GL.INT_VEC2: return new ProgramUniformInt2(program, info);
                case GL.INT_VEC3: return new ProgramUniformInt3(program, info);
                case GL.INT_VEC4: return new ProgramUniformInt4(program, info);

                case GL.UNSIGNED_INT: return new ProgramUniformUInt1(program, info);
                //case GL.UNSIGNED_INT_VEC2:
                //case GL.UNSIGNED_INT_VEC3:
                //case GL.UNSIGNED_INT_VEC4:

                case GL.BOOL: return new ProgramUniformBool1(program, info);
                //case GL.BOOL_VEC2:
                //case GL.BOOL_VEC3:
                //case GL.BOOL_VEC4:

                case GL.FLOAT_MAT2: return new ProgramUniformFloatMatrix2(program, info);
                case GL.FLOAT_MAT3: return new ProgramUniformFloatMatrix3(program, info);
                case GL.FLOAT_MAT4: return new ProgramUniformFloatMatrix4(program, info);
                //case GL.FLOAT_MAT2x3:
                //case GL.FLOAT_MAT2x4:
                //case GL.FLOAT_MAT3x2:
                //case GL.FLOAT_MAT3x4:
                //case GL.FLOAT_MAT4x2:
                //case GL.FLOAT_MAT4x3:

                //case GL.SAMPLER_1D:
                case GL.SAMPLER_2D: return new ProgramUniformSampler2D(program, info, textureUnit);
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
    }

    public abstract class ProgramUniform<T> : ProgramUniform
    {
        internal ProgramUniform(Program program, ProgramUniformInfo info)
            : base(program, info)
        {

        }

        public abstract void SetValue(T value);
    }

    #region Implementations
    internal sealed class ProgramUniformFloat1 : ProgramUniform<float>
    {
        internal ProgramUniformFloat1(Program program, ProgramUniformInfo info)
            : base(program, info)
        {

        }

        public override void SetValue(float value)
        {
            GL.Uniform1f(Info.Location, value);
        }
    }

    internal sealed class ProgramUniformFloat2 : ProgramUniform<Vector2>
    {
        internal ProgramUniformFloat2(Program program, ProgramUniformInfo info)
            : base(program, info)
        {

        }

        public override void SetValue(Vector2 value)
        {
            GL.Uniform2f(Info.Location, value);
        }
    }

    internal sealed class ProgramUniformFloat3 : ProgramUniform<Vector3>
    {
        internal ProgramUniformFloat3(Program program, ProgramUniformInfo info)
            : base(program, info)
        {

        }

        public override void SetValue(Vector3 value)
        {
            GL.Uniform3f(Info.Location, value);
        }
    }

    internal sealed class ProgramUniformFloat4 : ProgramUniform<Vector4>
    {
        internal ProgramUniformFloat4(Program program, ProgramUniformInfo info)
            : base(program, info)
        {

        }

        public override void SetValue(Vector4 value)
        {
            GL.Uniform4f(Info.Location, value);
        }
    }

    internal sealed class ProgramUniformInt1 : ProgramUniform<int>
    {
        internal ProgramUniformInt1(Program program, ProgramUniformInfo info)
            : base(program, info)
        {

        }

        public override void SetValue(int value)
        {
            GL.Uniform1i(Info.Location, value);
        }
    }

    internal sealed class ProgramUniformInt2 : ProgramUniform<Vector2i>
    {
        internal ProgramUniformInt2(Program program, ProgramUniformInfo info)
            : base(program, info)
        {

        }

        public override void SetValue(Vector2i value)
        {
            GL.Uniform2i(Info.Location, value);
        }
    }

    internal sealed class ProgramUniformInt3 : ProgramUniform<Vector3i>
    {
        internal ProgramUniformInt3(Program program, ProgramUniformInfo info)
            : base(program, info)
        {

        }

        public override void SetValue(Vector3i value)
        {
            GL.Uniform3i(Info.Location, value);
        }
    }

    internal sealed class ProgramUniformInt4 : ProgramUniform<Vector4i>
    {
        internal ProgramUniformInt4(Program program, ProgramUniformInfo info)
            : base(program, info)
        {

        }

        public override void SetValue(Vector4i value)
        {
            GL.Uniform4i(Info.Location, value);
        }
    }

    internal sealed class ProgramUniformUInt1 : ProgramUniform<uint>
    {
        internal ProgramUniformUInt1(Program program, ProgramUniformInfo info)
            : base(program, info)
        {

        }

        public override void SetValue(uint value)
        {
            GL.Uniform1ui(Info.Location, value);
        }
    }

    internal sealed class ProgramUniformBool1 : ProgramUniform<bool>
    {
        internal ProgramUniformBool1(Program program, ProgramUniformInfo info)
            : base(program, info)
        {

        }

        public override void SetValue(bool value)
        {
            GL.Uniform1ui(Info.Location, value ? 0u : 1u);
        }
    }

    internal sealed class ProgramUniformFloatMatrix2 : ProgramUniform<Matrix2>
    {
        internal ProgramUniformFloatMatrix2(Program program, ProgramUniformInfo info)
            : base(program, info)
        {

        }

        public override void SetValue(Matrix2 value)
        {
            GL.UniformMatrix2fv(Info.Location, 1, false, ref value);
        }
    }

    internal sealed class ProgramUniformFloatMatrix3 : ProgramUniform<Matrix3>
    {
        internal ProgramUniformFloatMatrix3(Program program, ProgramUniformInfo info)
            : base(program, info)
        {

        }

        public override void SetValue(Matrix3 value)
        {
            GL.UniformMatrix3fv(Info.Location, 1, false, ref value);
        }
    }

    internal sealed class ProgramUniformFloatMatrix4 : ProgramUniform<Matrix4>
    {
        internal ProgramUniformFloatMatrix4(Program program, ProgramUniformInfo info)
            : base(program, info)
        {

        }

        public override void SetValue(Matrix4 value)
        {
            GL.UniformMatrix4fv(Info.Location, 1, false, ref value);
        }
    }

    internal sealed class ProgramUniformSampler2D : ProgramUniform<Texture2D>
    {
        private readonly uint m_textureUnit;

        internal ProgramUniformSampler2D(Program program, ProgramUniformInfo info, uint textureUnit)
            : base(program, info)
        {
            m_textureUnit = textureUnit;
        }

        public override void SetValue(Texture2D value)
        {
            if (value != null)
            {
                GL.ActiveTexture(m_textureUnit);
                GL.BindTexture(GL.TEXTURE_2D, value.Name);
                GL.Uniform1i(Info.Location, (int)(m_textureUnit - GL.TEXTURE0));
            }
        }
    }
    #endregion
}
