using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Granite.Core
{
    public abstract class Shader : ApplicationResource
    {
        private readonly uint m_name;

        internal Shader(uint type, string source)
            : base()
        {
            m_name = GL.CreateShader(type);
            string[] lines = source.Split(new string[] { Environment.NewLine }, StringSplitOptions.None).Select(l => l + '\n').ToArray();

            var lineHandles = lines.Select(l => GCHandle.Alloc(Encoding.ASCII.GetBytes(l), GCHandleType.Pinned)).ToList();

            GL.ShaderSource(m_name, lines.Length,
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
        internal VertexShader(string source)
            : base(GL.VERTEX_SHADER, source)
        {

        }
    }

    public sealed class FragmentShader : Shader
    {
        internal FragmentShader(string source)
            : base(GL.FRAGMENT_SHADER, source)
        {

        }
    }
}
