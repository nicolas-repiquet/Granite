﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Granite.Core
{
    public class Program : ApplicationResource
    {
        private readonly VertexShader m_vertexShader;
        private readonly GeometryShader m_geometryShader;
        private readonly FragmentShader m_fragmentShader;

        private readonly uint m_name;
        private readonly ProgramUniform[] m_uniforms;
        private readonly Dictionary<string, ProgramAttributeInfo> m_attributes;

        public Program(VertexShader vertex = null, GeometryShader geometry = null, FragmentShader fragment = null)
        {
            m_vertexShader = vertex;
            m_geometryShader = geometry;
            m_fragmentShader = fragment;

            m_name = GL.CreateProgram();
            if(vertex != null) GL.AttachShader(m_name, vertex.Name);
            if (geometry != null) GL.AttachShader(m_name, geometry.Name);
            if(fragment != null) GL.AttachShader(m_name, fragment.Name);
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
                var location = GL.GetUniformLocation(m_name, buffer);
                uniforms.Add(ProgramUniform.Create(this, type, uniformName, location));
            }
            m_uniforms = uniforms.ToArray();

            m_attributes = new Dictionary<string, ProgramAttributeInfo>();
            LoadAttributes();

        }

        private void LoadAttributes()
        {
            int attributeCount;
            GL.GetProgramiv(m_name, GL.ACTIVE_ATTRIBUTES, out attributeCount);
            for (uint i = 0; i < attributeCount; i++)
            {
                var buffer = new byte[4096];
                int length;
                int size;
                uint type;

                GL.GetActiveAttrib(m_name, i, buffer.Length, out length, out size, out type, buffer);

                string attributeName = Encoding.ASCII.GetString(buffer, 0, length);

                int location = GL.GetAttribLocation(m_name, attributeName);

                m_attributes.Add(
                    attributeName,
                    new ProgramAttributeInfo(this, attributeName, i, (uint)location, type)
                );
            }
        }

        public IEnumerable<ProgramUniform> Uniforms { get { return m_uniforms; } }

        public ProgramUniform<T> GetUniform<T>(string name)
        {
            foreach (var uniform in m_uniforms)
            {
                if (uniform.Name == name)
                {
                    if (uniform is ProgramUniform<T>)
                    {
                        return (ProgramUniform<T>)uniform;
                    }
                    else
                    {

                    }
                }
            }

            throw new Exception("Can't find uniform " + name);
        }

        public ProgramAttribute<T> GetAttribute<T>(string name, bool normalized = false)
        {
            ProgramAttributeInfo info;

            if (m_attributes.TryGetValue(name, out info))
            {
                return ProgramAttribute<T>.Create(this, info, normalized);
            }
            else
            {
                throw new Exception(string.Format("Attribute \"{0}\" does not exists or is not active", name));
            }
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
}
