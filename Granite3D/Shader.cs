using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Granite3D
{
    public abstract class Shader : EngineResource
    {
        private readonly uint m_name;

        internal Shader(Engine engine, uint type, string source)
            : base(engine)
        {
            m_name = Engine.Gl.glCreateShader(type);
            string[] lines = source.Split(new string[] { Environment.NewLine }, StringSplitOptions.None).Select(l => l + '\n').ToArray();

            var lineHandles = lines.Select(l => GCHandle.Alloc(Encoding.ASCII.GetBytes(l), GCHandleType.Pinned)).ToList();

            Engine.Gl.glShaderSource(m_name, lines.Length,
                lineHandles.Select(h => h.AddrOfPinnedObject()).ToArray(),
                lines.Select(l => l.Length).ToArray()
            );

            foreach (var handle in lineHandles) { handle.Free(); }

            Engine.Gl.glCompileShader(m_name);
            int compileStatus;
            Engine.Gl.glGetShaderiv(m_name, GlApi.GL_COMPILE_STATUS, out compileStatus);
            if (compileStatus == 0)
            {
                byte[] buffer = new byte[4096];
                int length;
                Engine.Gl.glGetShaderInfoLog(m_name, buffer.Length, out length, buffer);
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
                Engine.Gl.glDeleteShader(name);
            });
        }
    }

    public sealed class VertexShader : Shader
    {
        internal VertexShader(Engine engine, string source)
            : base(engine, GlApi.GL_VERTEX_SHADER, source)
        {

        }
    }

    public sealed class FragmentShader : Shader
    {
        internal FragmentShader(Engine engine, string source)
            : base(engine, GlApi.GL_FRAGMENT_SHADER, source)
        {

        }
    }
}
