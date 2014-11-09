using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Granite.Core
{
    public sealed class ProgramAttributeInfo
    {
        public Program Program { get; private set; }
        public string Name { get; private set; }
        public uint Index { get; private set; }
        public uint Location { get; private set; }
        public uint Type { get; private set; }

        public ProgramAttributeInfo(Program program, string name, uint index, uint location, uint type)
        {
            Program = program;
            Name = name;
            Index = index;
            Location = location;
            Type = type;
        }
    }

    public abstract class ProgramAttribute
    {
        #region FACTORY
        internal static int GetComponentCount(uint attributeType)
        {
            switch (attributeType)
            {
                case GL.FLOAT: return 1;
                case GL.FLOAT_VEC2: return 2;
                case GL.FLOAT_VEC3: return 3;
                case GL.FLOAT_VEC4: return 4;
                case GL.FLOAT_MAT2: return 4;
                case GL.FLOAT_MAT3: return 9;
                case GL.FLOAT_MAT4: return 16;
                case GL.FLOAT_MAT2x3: return 6;
                case GL.FLOAT_MAT2x4: return 8;
                case GL.FLOAT_MAT3x2: return 6;
                case GL.FLOAT_MAT3x4: return 12;
                case GL.FLOAT_MAT4x2: return 8;
                case GL.FLOAT_MAT4x3: return 12;
                case GL.INT: return 1;
                case GL.INT_VEC2: return 2;
                case GL.INT_VEC3: return 3;
                case GL.INT_VEC4: return 4;
                case GL.UNSIGNED_INT: return 1;
                case GL.UNSIGNED_INT_VEC2: return 2;
                case GL.UNSIGNED_INT_VEC3: return 3;
                case GL.UNSIGNED_INT_VEC4: return 4;
                default: throw new ArgumentException("attributeType");
            }
        }

        internal static int GetColumnCount(uint attributeType)
        {
            switch (attributeType)
            {
                case GL.FLOAT:
                case GL.FLOAT_VEC2:
                case GL.FLOAT_VEC3:
                case GL.FLOAT_VEC4:
                case GL.INT:
                case GL.INT_VEC2:
                case GL.INT_VEC3:
                case GL.INT_VEC4:
                case GL.UNSIGNED_INT:
                case GL.UNSIGNED_INT_VEC2:
                case GL.UNSIGNED_INT_VEC3:
                case GL.UNSIGNED_INT_VEC4:
                    return 1;

                case GL.FLOAT_MAT2:
                case GL.FLOAT_MAT3x2:
                case GL.FLOAT_MAT4x2:
                    return 2;

                case GL.FLOAT_MAT2x3:
                case GL.FLOAT_MAT3:
                case GL.FLOAT_MAT4x3:
                    return 3;

                case GL.FLOAT_MAT2x4:
                case GL.FLOAT_MAT3x4:
                case GL.FLOAT_MAT4:
                    return 4;

                default:
                    throw new ArgumentException("attributeType");
            }
        }

        internal static bool IsInteger(uint attributeType)
        {
            switch (attributeType)
            {
                case GL.FLOAT:
                case GL.FLOAT_VEC2:
                case GL.FLOAT_VEC3:
                case GL.FLOAT_VEC4:
                case GL.FLOAT_MAT2:
                case GL.FLOAT_MAT3:
                case GL.FLOAT_MAT4:
                case GL.FLOAT_MAT2x3:
                case GL.FLOAT_MAT2x4:
                case GL.FLOAT_MAT3x2:
                case GL.FLOAT_MAT3x4:
                case GL.FLOAT_MAT4x2:
                case GL.FLOAT_MAT4x3:
                    return false;

                case GL.INT:
                case GL.INT_VEC2:
                case GL.INT_VEC3:
                case GL.INT_VEC4:
                case GL.UNSIGNED_INT:
                case GL.UNSIGNED_INT_VEC2:
                case GL.UNSIGNED_INT_VEC3:
                case GL.UNSIGNED_INT_VEC4:
                    return true;

                default:
                    throw new ArgumentException("attributeType");
            }
        }
        #endregion

        public ProgramAttributeInfo Info { get; private set; }

        internal ProgramAttribute(ProgramAttributeInfo info)
        {
            Info = info;
        }

        public abstract void SetDivisor(int divisor);
    }

    public abstract class ProgramAttribute<T> : ProgramAttribute
    {
        private static readonly ValueTypeDescriptor Descriptor = ValueTypeDescriptor.Create(typeof(T));

        internal static ProgramAttribute<T> Create(Program program, ProgramAttributeInfo info, bool normalized)
        {
            var attributeComponentCount = GetComponentCount(info.Type);
            var attributeColumnCount = GetColumnCount(info.Type);
            var attributeComponentsPerColumn = attributeComponentCount / attributeColumnCount;

            if (attributeComponentCount != Descriptor.FlattenedCount)
            {
                throw new Exception(string.Format("Attribute \"{0}\" data type does not match {1}: first has {2} components, second has {3}",
                    info.Name, typeof(T), attributeComponentCount, Descriptor.FlattenedCount
                ));
            }

            if (IsInteger(info.Type))
            {
                switch (attributeColumnCount)
                {
                    case 1: return new ProgramAttribute1Integer(info, attributeComponentsPerColumn, Descriptor.Size);
                    case 2: return new ProgramAttribute2Integer(info, attributeComponentsPerColumn, Descriptor.Size / 2);
                    case 3: return new ProgramAttribute3Integer(info, attributeComponentsPerColumn, Descriptor.Size / 3);
                    case 4: return new ProgramAttribute4Integer(info, attributeComponentsPerColumn, Descriptor.Size / 4);
                    default: throw new Exception(); // will never happens
                }
            }
            else
            {
                switch (attributeColumnCount)
                {
                    case 1: return new ProgramAttribute1Real(info, attributeComponentsPerColumn, Descriptor.Size, normalized);
                    case 2: return new ProgramAttribute2Real(info, attributeComponentsPerColumn, Descriptor.Size / 2, normalized);
                    case 3: return new ProgramAttribute3Real(info, attributeComponentsPerColumn, Descriptor.Size / 3, normalized);
                    case 4: return new ProgramAttribute4Real(info, attributeComponentsPerColumn, Descriptor.Size / 4, normalized);
                    default: throw new Exception(); // will never happens
                }
            }
        }

        protected int ComponentsPerColumn { get; private set; }
        protected int ColumnSize { get; private set; }
        protected bool Normalized { get; private set; }

        internal ProgramAttribute(ProgramAttributeInfo info, int componentsPerColumn, int columnSize, bool normalized)
            : base(info)
        {
            ComponentsPerColumn = componentsPerColumn;
            ColumnSize = columnSize;
            Normalized = normalized;
        }

        public abstract void SetValue(IBufferView<T> view);

        private class ProgramAttribute1Integer : ProgramAttribute<T>
        {
            public ProgramAttribute1Integer(ProgramAttributeInfo info, int componentsPerColumn, int columnSize)
                : base(info, componentsPerColumn, columnSize, false)
            {

            }

            public override void SetValue(IBufferView<T> view)
            {
                GL.BindBuffer(GL.ARRAY_BUFFER, view.Buffer.Name);

                GL.VertexAttribIPointer(Info.Location, ComponentsPerColumn, Descriptor.FlattenedType, view.Stride, new IntPtr(view.Offset));

                GL.EnableVertexAttribArray(Info.Location);
            }

            public override void SetDivisor(int divisor)
            {
                GL.VertexAttribDivisor(Info.Location, (uint)divisor);
            }
        }

        private class ProgramAttribute2Integer : ProgramAttribute<T>
        {
            public ProgramAttribute2Integer(ProgramAttributeInfo info, int componentsPerColumn, int columnSize)
                : base(info, componentsPerColumn, columnSize, false)
            {

            }

            public override void SetValue(IBufferView<T> view)
            {
                GL.BindBuffer(GL.ARRAY_BUFFER, view.Buffer.Name);

                GL.VertexAttribIPointer(Info.Location + 0, ComponentsPerColumn, Descriptor.FlattenedType, view.Stride, new IntPtr(view.Offset));
                GL.VertexAttribIPointer(Info.Location + 1, ComponentsPerColumn, Descriptor.FlattenedType, view.Stride, new IntPtr(view.Offset + ColumnSize));

                GL.EnableVertexAttribArray(Info.Location + 0);
                GL.EnableVertexAttribArray(Info.Location + 1);
            }

            public override void SetDivisor(int divisor)
            {
                GL.VertexAttribDivisor(Info.Location + 0, (uint)divisor);
                GL.VertexAttribDivisor(Info.Location + 1, (uint)divisor);
            }
        }

        private class ProgramAttribute3Integer : ProgramAttribute<T>
        {
            public ProgramAttribute3Integer(ProgramAttributeInfo info, int componentsPerColumn, int columnSize)
                : base(info, componentsPerColumn, columnSize, false)
            {

            }

            public override void SetValue(IBufferView<T> view)
            {
                GL.BindBuffer(GL.ARRAY_BUFFER, view.Buffer.Name);

                GL.VertexAttribIPointer(Info.Location + 0, ComponentsPerColumn, Descriptor.FlattenedType, view.Stride, new IntPtr(view.Offset));
                GL.VertexAttribIPointer(Info.Location + 1, ComponentsPerColumn, Descriptor.FlattenedType, view.Stride, new IntPtr(view.Offset + ColumnSize));
                GL.VertexAttribIPointer(Info.Location + 2, ComponentsPerColumn, Descriptor.FlattenedType, view.Stride, new IntPtr(view.Offset + ColumnSize * 2));

                GL.EnableVertexAttribArray(Info.Location + 0);
                GL.EnableVertexAttribArray(Info.Location + 1);
                GL.EnableVertexAttribArray(Info.Location + 2);
            }

            public override void SetDivisor(int divisor)
            {
                GL.VertexAttribDivisor(Info.Location + 0, (uint)divisor);
                GL.VertexAttribDivisor(Info.Location + 1, (uint)divisor);
                GL.VertexAttribDivisor(Info.Location + 2, (uint)divisor);
            }
        }

        private class ProgramAttribute4Integer : ProgramAttribute<T>
        {
            public ProgramAttribute4Integer(ProgramAttributeInfo info, int componentsPerColumn, int columnSize)
                : base(info, componentsPerColumn, columnSize, false)
            {

            }

            public override void SetValue(IBufferView<T> view)
            {
                GL.BindBuffer(GL.ARRAY_BUFFER, view.Buffer.Name);

                GL.VertexAttribIPointer(Info.Location + 0, ComponentsPerColumn, Descriptor.FlattenedType, view.Stride, new IntPtr(view.Offset));
                GL.VertexAttribIPointer(Info.Location + 1, ComponentsPerColumn, Descriptor.FlattenedType, view.Stride, new IntPtr(view.Offset + ColumnSize));
                GL.VertexAttribIPointer(Info.Location + 2, ComponentsPerColumn, Descriptor.FlattenedType, view.Stride, new IntPtr(view.Offset + ColumnSize * 2));
                GL.VertexAttribIPointer(Info.Location + 3, ComponentsPerColumn, Descriptor.FlattenedType, view.Stride, new IntPtr(view.Offset + ColumnSize * 3));

                GL.EnableVertexAttribArray(Info.Location + 0);
                GL.EnableVertexAttribArray(Info.Location + 1);
                GL.EnableVertexAttribArray(Info.Location + 2);
                GL.EnableVertexAttribArray(Info.Location + 3);
            }

            public override void SetDivisor(int divisor)
            {
                GL.VertexAttribDivisor(Info.Location + 0, (uint)divisor);
                GL.VertexAttribDivisor(Info.Location + 1, (uint)divisor);
                GL.VertexAttribDivisor(Info.Location + 2, (uint)divisor);
                GL.VertexAttribDivisor(Info.Location + 3, (uint)divisor);
            }
        }

        private class ProgramAttribute1Real : ProgramAttribute<T>
        {
            public ProgramAttribute1Real(ProgramAttributeInfo info, int componentsPerColumn, int columnSize, bool normalized)
                : base(info, componentsPerColumn, columnSize, normalized)
            {

            }

            public override void SetValue(IBufferView<T> view)
            {
                GL.BindBuffer(GL.ARRAY_BUFFER, view.Buffer.Name);

                GL.VertexAttribPointer(Info.Location, ComponentsPerColumn, Descriptor.FlattenedType, Normalized, view.Stride, new IntPtr(view.Offset));

                GL.EnableVertexAttribArray(Info.Location);
            }

            public override void SetDivisor(int divisor)
            {
                GL.VertexAttribDivisor(Info.Location, (uint)divisor);
            }
        }

        private class ProgramAttribute2Real : ProgramAttribute<T>
        {
            public ProgramAttribute2Real(ProgramAttributeInfo info, int componentsPerColumn, int columnSize, bool normalized)
                : base(info, componentsPerColumn, columnSize, normalized)
            {

            }

            public override void SetValue(IBufferView<T> view)
            {
                GL.BindBuffer(GL.ARRAY_BUFFER, view.Buffer.Name);

                GL.VertexAttribPointer(Info.Location + 0, ComponentsPerColumn, Descriptor.FlattenedType, Normalized, view.Stride, new IntPtr(view.Offset));
                GL.VertexAttribPointer(Info.Location + 1, ComponentsPerColumn, Descriptor.FlattenedType, Normalized, view.Stride, new IntPtr(view.Offset + ColumnSize));

                GL.EnableVertexAttribArray(Info.Location + 0);
                GL.EnableVertexAttribArray(Info.Location + 1);
            }

            public override void SetDivisor(int divisor)
            {
                GL.VertexAttribDivisor(Info.Location + 0, (uint)divisor);
                GL.VertexAttribDivisor(Info.Location + 1, (uint)divisor);
            }
        }

        private class ProgramAttribute3Real : ProgramAttribute<T>
        {
            public ProgramAttribute3Real(ProgramAttributeInfo info, int componentsPerColumn, int columnSize, bool normalized)
                : base(info, componentsPerColumn, columnSize, normalized)
            {

            }

            public override void SetValue(IBufferView<T> view)
            {
                GL.BindBuffer(GL.ARRAY_BUFFER, view.Buffer.Name);

                GL.VertexAttribPointer(Info.Location + 0, ComponentsPerColumn, Descriptor.FlattenedType, Normalized, view.Stride, new IntPtr(view.Offset));
                GL.VertexAttribPointer(Info.Location + 1, ComponentsPerColumn, Descriptor.FlattenedType, Normalized, view.Stride, new IntPtr(view.Offset + ColumnSize));
                GL.VertexAttribPointer(Info.Location + 2, ComponentsPerColumn, Descriptor.FlattenedType, Normalized, view.Stride, new IntPtr(view.Offset + ColumnSize * 2));

                GL.EnableVertexAttribArray(Info.Location + 0);
                GL.EnableVertexAttribArray(Info.Location + 1);
                GL.EnableVertexAttribArray(Info.Location + 2);
            }

            public override void SetDivisor(int divisor)
            {
                GL.VertexAttribDivisor(Info.Location + 0, (uint)divisor);
                GL.VertexAttribDivisor(Info.Location + 1, (uint)divisor);
                GL.VertexAttribDivisor(Info.Location + 2, (uint)divisor);
            }
        }

        private class ProgramAttribute4Real : ProgramAttribute<T>
        {
            public ProgramAttribute4Real(ProgramAttributeInfo info, int componentsPerColumn, int columnSize, bool normalized)
                : base(info, componentsPerColumn, columnSize, normalized)
            {

            }

            public override void SetValue(IBufferView<T> view)
            {
                GL.BindBuffer(GL.ARRAY_BUFFER, view.Buffer.Name);

                GL.VertexAttribPointer(Info.Location + 0, ComponentsPerColumn, Descriptor.FlattenedType, Normalized, view.Stride, new IntPtr(view.Offset));
                GL.VertexAttribPointer(Info.Location + 1, ComponentsPerColumn, Descriptor.FlattenedType, Normalized, view.Stride, new IntPtr(view.Offset + ColumnSize));
                GL.VertexAttribPointer(Info.Location + 2, ComponentsPerColumn, Descriptor.FlattenedType, Normalized, view.Stride, new IntPtr(view.Offset + ColumnSize * 2));
                GL.VertexAttribPointer(Info.Location + 3, ComponentsPerColumn, Descriptor.FlattenedType, Normalized, view.Stride, new IntPtr(view.Offset + ColumnSize * 3));

                GL.EnableVertexAttribArray(Info.Location + 0);
                GL.EnableVertexAttribArray(Info.Location + 1);
                GL.EnableVertexAttribArray(Info.Location + 2);
                GL.EnableVertexAttribArray(Info.Location + 3);
            }

            public override void SetDivisor(int divisor)
            {
                GL.VertexAttribDivisor(Info.Location + 0, (uint)divisor);
                GL.VertexAttribDivisor(Info.Location + 1, (uint)divisor);
                GL.VertexAttribDivisor(Info.Location + 2, (uint)divisor);
                GL.VertexAttribDivisor(Info.Location + 3, (uint)divisor);
            }
        }
    }
}