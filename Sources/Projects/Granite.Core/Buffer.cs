﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace Granite.Core
{
    public abstract class Buffer : ApplicationResource
    {
        private readonly uint m_name;

        internal Buffer()
        {
            uint name;
            GL.GenBuffers(1, out name);
            m_name = name;
        }

        internal uint Name { get { return m_name; } }
        public abstract int Count { get; }
        public abstract int TypeSize { get; }
    }

    public sealed class Buffer<T> : Buffer where T : struct
    {
        #region VIEW
        private sealed class View<TItem> : IBufferView<TItem>
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

        public Buffer()
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

        public IBufferView<T> GetView()
        {
            return new View<T>(this, s_descriptor.FlattenedCount, s_descriptor.FlattenedType, 0, 0);
        }

        public IBufferView<TItem> GetView<TItem>(string name)
        {
            var field = s_descriptor.GetField(name);

            if (field.Descriptor.Type != typeof(TItem))
            {
                throw new InvalidOperationException(string.Format(
                    "Can't convert from {0} to {1}",
                    field.Descriptor.Type.Name,
                    typeof(TItem).Name
                ));
            }
            else
            {
                return new View<TItem>(this, field.Descriptor.FlattenedCount, field.Descriptor.FlattenedType, field.Offset, s_descriptor.Size);
            }
        }

        protected override void InternalDispose()
        {
            var name = Name;

            Engine.ExecuteAction(() =>
            {
                GL.DeleteBuffers(1, ref name);
            });
        }

        public void SetData(int count, uint usage = GL.STATIC_DRAW)
        {
            GL.BindBuffer(GL.ARRAY_BUFFER, Name);
            GL.BufferData(GL.ARRAY_BUFFER, new IntPtr(count * TypeSize), IntPtr.Zero, usage);
            m_count = count;
        }

        public void SetData(T[] data, uint usage = GL.STATIC_DRAW)
        {
            if (data == null)
            {
                GL.BindBuffer(GL.ARRAY_BUFFER, Name);
                GL.BufferData(GL.ARRAY_BUFFER, IntPtr.Zero, IntPtr.Zero, usage);
                m_count = 0;
            }
            else
            {
                var handle = GCHandle.Alloc(data, GCHandleType.Pinned);

                try
                {
                    var size = TypeSize * data.Length;
                    GL.BindBuffer(GL.ARRAY_BUFFER, Name);
                    GL.BufferData(GL.ARRAY_BUFFER, new IntPtr(size), handle.AddrOfPinnedObject(), usage);
                    m_count = data.Length;
                }
                finally
                {
                    handle.Free();
                }
            }
        }

        public void SetSubData(T[] data, int offset, int count)
        {
            var handle = GCHandle.Alloc(data, GCHandleType.Pinned);

            try
            {
                var size = TypeSize * count;
                GL.BindBuffer(GL.ARRAY_BUFFER, Name);
                GL.BufferSubData(GL.ARRAY_BUFFER, new IntPtr(offset), new IntPtr(size), handle.AddrOfPinnedObject());
                m_count = count;
            }
            finally
            {
                handle.Free();
            }
        }

        public BufferMapping<T> Map(int count)
        {
            var size = TypeSize * count;
            GL.BindBuffer(GL.ARRAY_BUFFER, Name);
            //GL.BufferData(GL.ARRAY_BUFFER, new IntPtr(size), IntPtr.Zero, GL.STREAM_DRAW);
            var address = GL.MapBufferRange(GL.ARRAY_BUFFER, new IntPtr(0), new IntPtr(size), GL.MAP_WRITE_BIT | GL.MAP_INVALIDATE_BUFFER_BIT);

            return new BufferMapping<T>(this, address);
        }
    }
}