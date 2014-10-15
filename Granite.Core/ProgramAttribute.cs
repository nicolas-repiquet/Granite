using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Granite.Core
{
    public abstract class ProgramAttribute
    {
        #region FACTORY
        internal static ProgramAttribute Create(Program program, uint type, string name, int location)
        {
            switch (type)
            {
                case GL.FLOAT: return new ProgramAttributeFloat1(program, name, location);
                case GL.FLOAT_VEC2: return new ProgramAttributeFloat2(program, name, location);
                case GL.FLOAT_VEC3: return new ProgramAttributeFloat3(program, name, location);
                case GL.FLOAT_VEC4: return new ProgramAttributeFloat4(program, name, location);

                case GL.FLOAT_MAT2: return new ProgramAttributeFloatMatrix2(program, name, location);
                case GL.FLOAT_MAT3: return new ProgramAttributeFloatMatrix3(program, name, location);
                case GL.FLOAT_MAT4: return new ProgramAttributeFloatMatrix4(program, name, location);

                //case GL.FLOAT_MAT2x3:
                //case GL.FLOAT_MAT2x4:
                //case GL.FLOAT_MAT3x2:
                //case GL.FLOAT_MAT3x4:
                //case GL.FLOAT_MAT4x2:
                //case GL.FLOAT_MAT4x3:

                case GL.INT: return new ProgramAttributeInt1(program, name, location);
                case GL.INT_VEC2: return new ProgramAttributeInt2(program, name, location);
                case GL.INT_VEC3: return new ProgramAttributeInt3(program, name, location);
                case GL.INT_VEC4: return new ProgramAttributeInt4(program, name, location);

                case GL.UNSIGNED_INT: return new ProgramAttributeUInt1(program, name, location);
                //case GL.UNSIGNED_INT_VEC2:
                //case GL.UNSIGNED_INT_VEC3:
                //case GL.UNSIGNED_INT_VEC4:

                default:
                    throw new Exception();
            }
        }
        #endregion

        private readonly Program m_program;
        private readonly string m_name;
        private readonly int m_location;

        internal ProgramAttribute(Program program, string name, int location)
        {
            m_program = program;
            m_name = name;
            m_location = location;
        }

        public string Name { get { return m_name; } }
        public int Location { get { return m_location; } }
        public abstract Type Type { get; } 

        public void SetDivisor(uint divisor)
        {
            GL.VertexAttribDivisor((uint)Location, divisor);
        }
    }

    public abstract class ProgramAttribute<T> : ProgramAttribute
    {
        internal ProgramAttribute(Program program, string name, int location)
            : base(program, name, location)
        {

        }

        public override Type Type
        {
            get { return typeof(T); }
        }

        public virtual void SetValue(IBufferView<T> view)
        {
            GL.BindBuffer(GL.ARRAY_BUFFER, view.Buffer.Name);

            GL.VertexAttribPointer(
                (uint)Location,
                view.Size,
                view.Type,
                true,
                view.Stride,
                new IntPtr(view.Offset)
            );

            GL.EnableVertexAttribArray((uint)Location);
        }

        public virtual void SetDivisor(int divisor)
        {
            GL.VertexAttribDivisor((uint)Location, (uint)divisor);
        }
    }

    public sealed class ProgramAttributeInt1 : ProgramAttribute<int>
    {
        internal ProgramAttributeInt1(Program program, string name, int location)
            : base(program, name, location)
        {

        }
    }

    public sealed class ProgramAttributeInt2 : ProgramAttribute<Vector2i>
    {
        internal ProgramAttributeInt2(Program program, string name, int location)
            : base(program, name, location)
        {

        }
    }

    public sealed class ProgramAttributeInt3 : ProgramAttribute<Vector3i>
    {
        internal ProgramAttributeInt3(Program program, string name, int location)
            : base(program, name, location)
        {

        }
    }

    public sealed class ProgramAttributeInt4 : ProgramAttribute<Vector4i>
    {
        internal ProgramAttributeInt4(Program program, string name, int location)
            : base(program, name, location)
        {

        }
    }

    public sealed class ProgramAttributeFloat1 : ProgramAttribute<float>
    {
        internal ProgramAttributeFloat1(Program program, string name, int location)
            : base(program, name, location)
        {

        }
    }

    public sealed class ProgramAttributeFloat2 : ProgramAttribute<Vector2>
    {
        internal ProgramAttributeFloat2(Program program, string name, int location)
            : base(program, name, location)
        {

        }
    }

    public sealed class ProgramAttributeFloat3 : ProgramAttribute<Vector3>
    {
        internal ProgramAttributeFloat3(Program program, string name, int location)
            : base(program, name, location)
        {

        }
    }

    public sealed class ProgramAttributeFloat4 : ProgramAttribute<Vector4>
    {
        internal ProgramAttributeFloat4(Program program, string name, int location)
            : base(program, name, location)
        {

        }
    }

    public sealed class ProgramAttributeFloatMatrix2 : ProgramAttribute<Matrix2>
    {
        internal ProgramAttributeFloatMatrix2(Program program, string name, int location)
            : base(program, name, location)
        {

        }

        public override void SetValue(IBufferView<Matrix2> view)
        {
            uint pos1 = (uint)Location + 0;
            uint pos2 = (uint)Location + 1;

            GL.BindBuffer(GL.ARRAY_BUFFER, view.Buffer.Name);

            GL.VertexAttribPointer(pos1, 2, GL.FLOAT, false, view.Stride, new IntPtr(view.Offset));
            GL.VertexAttribPointer(pos2, 2, GL.FLOAT, false, view.Stride, new IntPtr(view.Offset + 8));

            GL.EnableVertexAttribArray(pos1);
            GL.EnableVertexAttribArray(pos2);
        }

        public override void SetDivisor(int divisor)
        {
            GL.VertexAttribDivisor((uint)Location + 0, (uint)divisor);
            GL.VertexAttribDivisor((uint)Location + 1, (uint)divisor);
        }
    }

    public sealed class ProgramAttributeFloatMatrix3 : ProgramAttribute<Matrix3>
    {
        internal ProgramAttributeFloatMatrix3(Program program, string name, int location)
            : base(program, name, location)
        {

        }

        public override void SetValue(IBufferView<Matrix3> view)
        {
            uint pos1 = (uint)Location + 0;
            uint pos2 = (uint)Location + 1;
            uint pos3 = (uint)Location + 2;

            GL.BindBuffer(GL.ARRAY_BUFFER, view.Buffer.Name);

            GL.VertexAttribPointer(pos1, 3, GL.FLOAT, false, view.Stride, new IntPtr(view.Offset));
            GL.VertexAttribPointer(pos2, 3, GL.FLOAT, false, view.Stride, new IntPtr(view.Offset + 12));
            GL.VertexAttribPointer(pos3, 3, GL.FLOAT, false, view.Stride, new IntPtr(view.Offset + 24));

            GL.EnableVertexAttribArray(pos1);
            GL.EnableVertexAttribArray(pos2);
            GL.EnableVertexAttribArray(pos3);
        }

        public override void SetDivisor(int divisor)
        {
            GL.VertexAttribDivisor((uint)Location + 0, (uint)divisor);
            GL.VertexAttribDivisor((uint)Location + 1, (uint)divisor);
            GL.VertexAttribDivisor((uint)Location + 2, (uint)divisor);
        }
    }

    public sealed class ProgramAttributeFloatMatrix4 : ProgramAttribute<Matrix4>
    {
        internal ProgramAttributeFloatMatrix4(Program program, string name, int location)
            : base(program, name, location)
        {

        }

        public override void SetValue(IBufferView<Matrix4> view)
        {
            uint pos1 = (uint)Location + 0;
            uint pos2 = (uint)Location + 1;
            uint pos3 = (uint)Location + 2;
            uint pos4 = (uint)Location + 3;

            GL.BindBuffer(GL.ARRAY_BUFFER, view.Buffer.Name);

            GL.VertexAttribPointer(pos1, 4, GL.FLOAT, false, view.Stride, new IntPtr(view.Offset));
            GL.VertexAttribPointer(pos2, 4, GL.FLOAT, false, view.Stride, new IntPtr(view.Offset + 16));
            GL.VertexAttribPointer(pos3, 4, GL.FLOAT, false, view.Stride, new IntPtr(view.Offset + 32));
            GL.VertexAttribPointer(pos4, 4, GL.FLOAT, false, view.Stride, new IntPtr(view.Offset + 48));

            GL.EnableVertexAttribArray(pos1);
            GL.EnableVertexAttribArray(pos2);
            GL.EnableVertexAttribArray(pos3);
            GL.EnableVertexAttribArray(pos4);
        }

        public override void SetDivisor(int divisor)
        {
            GL.VertexAttribDivisor((uint)Location + 0, (uint)divisor);
            GL.VertexAttribDivisor((uint)Location + 1, (uint)divisor);
            GL.VertexAttribDivisor((uint)Location + 2, (uint)divisor);
            GL.VertexAttribDivisor((uint)Location + 3, (uint)divisor);
        }
    }

    public sealed class ProgramAttributeUInt1 : ProgramAttribute<uint>
    {
        internal ProgramAttributeUInt1(Program program, string name, int location)
            : base(program, name, location)
        {

        }
    }
}
