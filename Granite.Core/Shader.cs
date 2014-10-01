using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;

namespace Granite.Core
{
    public abstract class Shader : ApplicationResource
    {
        private readonly uint m_name;

        internal Shader(uint type, string source)
            : this(type, new StringReader(source))
        {

        }

        internal Shader(uint type, Stream source)
            : this(type, new StreamReader(source))
        {

        }

        internal Shader(uint type, TextReader source)
        {
            m_name = GL.CreateShader(type);

            var lines = new List<string>();
            string line;

            while((line = source.ReadLine()) != null)
            {
                lines.Add(line + "\n");
            }

            var lineHandles = lines.Select(l => GCHandle.Alloc(Encoding.ASCII.GetBytes(l), GCHandleType.Pinned));

            GL.ShaderSource(m_name, lines.Count,
                lineHandles.Select(h => h.AddrOfPinnedObject()).ToArray(),
                lines.Select(l => l.Length).ToArray()
            );

            foreach (var handle in lineHandles) { handle.Free(); }

            GL.CompileShader(m_name);
            int compileStatus;
            GL.GetShaderiv(m_name, GL.COMPILE_STATUS, out compileStatus);
            if (compileStatus == 0)
            {
                byte[] buffer = new byte[4096];
                int length;
                GL.GetShaderInfoLog(m_name, buffer.Length, out length, buffer);
                string log = Encoding.ASCII.GetString(buffer, 0, length);
                throw new Exception(log);
            }
        }

        internal uint Name { get { return m_name; } }

        protected override void InternalDispose()
        {
            uint name = m_name;
            Engine.ExecuteAction(() =>
            {
                GL.DeleteShader(name);
            });
        }
    }

    public sealed class VertexShader : Shader
    {
        public VertexShader(string source)
            : base(GL.VERTEX_SHADER, source)
        {

        }

        public VertexShader(TextReader source)
            : base(GL.VERTEX_SHADER, source)
        {

        }

        public VertexShader(Stream source)
            : base(GL.VERTEX_SHADER, source)
        {

        }
    }

    public sealed class FragmentShader : Shader
    {
        public FragmentShader(string source)
            : base(GL.FRAGMENT_SHADER, source)
        {

        }

        public FragmentShader(TextReader source)
            : base(GL.FRAGMENT_SHADER, source)
        {

        }

        public FragmentShader(Stream source)
            : base(GL.FRAGMENT_SHADER, source)
        {

        }
    }
}
