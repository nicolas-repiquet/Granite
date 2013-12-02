using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace Granite3D
{
    internal class ValueTypeDescriptorField
    {
        public ValueTypeDescriptorField(int offset, ValueTypeDescriptor descriptor)
        {
            Offset = offset;
            Descriptor = descriptor;
        }

        public int Offset { get; private set; }
        public ValueTypeDescriptor Descriptor { get; private set; }
    }

    internal sealed class ValueTypeDescriptor
    {
        private sealed class Field
        {
            private readonly int m_offset;
            private readonly string m_name;
            private readonly ValueTypeDescriptor m_descriptor;

            public Field(int offset, string name, ValueTypeDescriptor descriptor)
            {
                m_offset = offset;
                m_name = name;
                m_descriptor = descriptor;
            }

            public int Offset { get { return m_offset; } }
            public string Name { get { return m_name; } }
            public ValueTypeDescriptor Descriptor { get { return m_descriptor; } }
        }

        private static readonly Dictionary<Type, ValueTypeDescriptor> s_descriptors;

        static ValueTypeDescriptor()
        {
            s_descriptors = new Dictionary<Type, ValueTypeDescriptor>();

            s_descriptors.Add(typeof(sbyte), new ValueTypeDescriptor(typeof(sbyte), GL.BYTE));
            s_descriptors.Add(typeof(byte), new ValueTypeDescriptor(typeof(byte), GL.UNSIGNED_BYTE));

            s_descriptors.Add(typeof(short), new ValueTypeDescriptor(typeof(short), GL.SHORT));
            s_descriptors.Add(typeof(ushort), new ValueTypeDescriptor(typeof(ushort), GL.UNSIGNED_SHORT));

            s_descriptors.Add(typeof(int), new ValueTypeDescriptor(typeof(int), GL.INT));
            s_descriptors.Add(typeof(uint), new ValueTypeDescriptor(typeof(uint), GL.UNSIGNED_INT));

            s_descriptors.Add(typeof(float), new ValueTypeDescriptor(typeof(float), GL.FLOAT));
            s_descriptors.Add(typeof(double), new ValueTypeDescriptor(typeof(double), GL.DOUBLE));
        }

        internal static ValueTypeDescriptor Create(Type type)
        {
            ValueTypeDescriptor descriptor;
            if (!s_descriptors.TryGetValue(type, out descriptor))
            {
                descriptor = new ValueTypeDescriptor(type, 0);
                s_descriptors.Add(type, descriptor);
            }
            return descriptor;
        }

        private readonly Type m_type;
        private readonly int m_size;
        private readonly Field[] m_fields;

        private readonly uint m_flattenedType;
        private readonly int m_flattenedCount;

        private ValueTypeDescriptor(Type type, uint glType)
        {
            if (type == null || !type.IsValueType)
            {
                throw new ArgumentException("type");
            }
            else
            {
                m_type = type;
                m_size = Marshal.SizeOf(type);

                if (type.IsPrimitive)
                {
                    m_fields = null;
                    m_flattenedType = glType;
                }
                else
                {
                    var fields = new List<Field>();

                    foreach (var field in type.GetFields(
                        BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
                    {
                        var descriptor = Create(field.FieldType);
                        fields.Add(new Field(Marshal.OffsetOf(type, field.Name).ToInt32(), field.Name, descriptor));
                    }

                    m_fields = fields.ToArray();

                    if (m_fields.Length > 0)
                    {
                        m_flattenedType = m_fields[0].Descriptor.m_flattenedType;
                        m_flattenedCount = m_fields[0].Descriptor.m_flattenedCount;

                        for (int i = 1; i < m_fields.Length; i++)
                        {
                            if (m_fields[i].Descriptor.m_flattenedType != m_flattenedType)
                            {
                                m_flattenedType = 0;
                                m_flattenedCount = 0;
                                break;
                            }
                            else
                            {
                                m_flattenedCount += m_fields[i].Descriptor.m_flattenedCount;
                            }
                        }
                    }

                    if (m_flattenedType != 0)
                    {
                        m_flattenedCount = m_fields.Length;
                    }
                }
            }
        }

        public int Size { get { return m_size; } }
        public uint FlattenedType { get { return m_flattenedType; } }
        public int FlattenedCount { get { return m_flattenedCount; } }

        public ValueTypeDescriptorField GetField(string name)
        {
            var tokens = new Queue<string>(name.Split('.'));
            return GetField(0, tokens);
        }

        private ValueTypeDescriptorField GetField(int offset, Queue<string> tokens)
        {
            var name = tokens.Dequeue();
            Field field = null;
            if (m_fields != null)
            {
                foreach (var f in m_fields)
                {
                    if (f.Name == name)
                    {
                        field = f;
                        break;
                    }
                }
            }
            if (field == null)
            {
                throw new ArgumentException("Unknown field " + name);
            }
            else
            {
                if (tokens.Count > 0)
                {
                    return field.Descriptor.GetField(offset + field.Offset, tokens);
                }
                else
                {
                    return new ValueTypeDescriptorField(offset + field.Offset, field.Descriptor);
                }
            }
        }
    }
}
