using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace Granite3D
{
    public abstract class Buffer : EngineResource
    {
        private readonly uint m_name;

        internal Buffer()
            : base()
        {
            uint name;
            Engine.Gl.GenBuffers(1, out name);
            m_name = name;
        }

        internal uint Name { get { return m_name; } }
        public abstract int Count { get; }
        public abstract int TypeSize { get; }
    }

    public sealed class Buffer<T> : Buffer where T : struct
    {
        #region VIEW
        private sealed class View : IBufferView
        {
            private readonly Buffer m_buffer;
            private readonly int m_size;
            private readonly uint m_type;
            private readonly int m_offset;
            private readonly int m_stride;

            public View(Buffer buffer, int size, uint type, int offset, int stride)
            {
                m_buffer = buffer;
                m_size = size;
                m_type = type;
                m_offset = offset;
                m_stride = stride;
            }

            public Buffer Buffer { get { return m_buffer; } }
            public int Size { get { return m_size; } }
            public uint Type { get { return m_type; } }
            public int Offset { get { return m_offset; } }
            public int Stride { get { return m_stride; } }
        }
        #endregion

        #region STATIC

        private static readonly ValueTypeDescriptor s_descriptor;

        static Buffer()
        {
            s_descriptor = ValueTypeDescriptor.Create(typeof(T));
        }

        private static void Inspect(Type t)
        {
            if (t.IsPrimitive)
            {

            }
            else
            {

            }
        }
        #endregion

        private int m_count;

        internal Buffer()
            : base()
        {

        }

        public override int Count
        {
            get { return m_count; }
        }

        public override int TypeSize
        {
            get { return s_descriptor.Size; }
        }

        public IBufferView GetView()
        {
            if (s_descriptor.FlattenedCount < 1 || s_descriptor.FlattenedCount > 4)
            {
                throw new InvalidOperationException("Invalid type");
            }
            else
            {
                return new View(this, s_descriptor.FlattenedCount, s_descriptor.FlattenedType, 0, 0);
            }
        }

        public IBufferView GetView(string name)
        {
            var field = s_descriptor.GetField(name);

            if (field.Descriptor.FlattenedCount < 1 || field.Descriptor.FlattenedCount > 4)
            {
                throw new InvalidOperationException("Invalid type");
            }
            else
            {
                return new View(this, field.Descriptor.FlattenedCount, field.Descriptor.FlattenedType, field.Offset, s_descriptor.Size);
            }
        }

        // protected abstract uint Target { get; }

        protected override void InternalDispose()
        {
            var name = Name;

            Engine.ExecuteAction(() =>
            {
                Engine.Gl.DeleteBuffers(1, ref name);
            });
        }

        public void SetData(T[] data)
        {

            var handle = GCHandle.Alloc(data, GCHandleType.Pinned);
            
            try
            {
                var size = TypeSize * data.Length;
                Engine.Gl.BindBuffer(GL.ARRAY_BUFFER, Name);
                Engine.Gl.BufferData(GL.ARRAY_BUFFER, new IntPtr(size), handle.AddrOfPinnedObject(), GL.STATIC_DRAW);
                int realSize;
                Engine.Gl.GetBufferParameteriv(GL.ARRAY_BUFFER, GL.BUFFER_SIZE, out realSize);
                Engine.Gl.BindBuffer(GL.ARRAY_BUFFER, 0);
                m_count = data.Length;
                if (size != realSize)
                {
                    throw new Exception();
                }
            }
            finally
            {
                handle.Free();
            }
        }
    }
}
