using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Granite3D
{
    public sealed class Graphics
    {
        private readonly Engine m_engine;

        internal Graphics(Engine engine)
        {
            m_engine = engine;
        }

        public void DrawPoints(
            Program program,
            Granite3D.Buffer elements,
            Dictionary<string, object> uniforms,
            Dictionary<string, IBufferView> attributes)
        {
            m_engine.Gl.UseProgram(program.Name);

            // Uniforms
            foreach (var uniform in program.Uniforms)
            {
                object value;

                if (uniforms.TryGetValue(uniform.Name, out value))
                {
                    uniform.SetValue(value);
                }
            }

            // Attributes
            foreach (var attribute in program.Attributes)
            {
                IBufferView view = null;
                if (attributes.TryGetValue(attribute.Name, out view))
                {
                    m_engine.Gl.BindBuffer(GL.ARRAY_BUFFER, view.Buffer.Name);
                    m_engine.Gl.VertexAttribPointer(
                        (uint)attribute.Position,
                        view.Size,
                        view.Type,
                        true,
                        view.Stride,
                        new IntPtr(view.Offset)
                    );
                    m_engine.Gl.BindBuffer(GL.ARRAY_BUFFER, 0);
                    m_engine.Gl.EnableVertexAttribArray((uint)attribute.Position);
                }
            }

            // Elements
            //m_engine.Gl.glBindBuffer(GL.ELEMENT_ARRAY_BUFFER, elements.Name);
            //m_engine.Gl.glDrawElements(
            //    GL.TRIANGLE_FAN,
            //    elements.Count,
            //    GL.UNSIGNED_INT,
            //    IntPtr.Zero
            //);

            m_engine.Gl.DrawArrays(GL.TRIANGLE_FAN, 0, 4);

            // Cleanup

            // Uniforms


            // Attributes
            foreach (var attribute in program.Attributes)
            {
                m_engine.Gl.DisableVertexAttribArray((uint)attribute.Position);
            }

            m_engine.Gl.UseProgram(0);
        }
    }
}
