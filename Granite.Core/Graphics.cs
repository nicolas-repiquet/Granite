using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Granite.Core
{
    public sealed class Graphics
    {
        internal Graphics()
        {
        }

        public void DrawPoints(
            Program program,
            Granite.Core.Buffer elements,
            Dictionary<string, object> uniforms,
            Dictionary<string, IBufferView> attributes)
        {
            Engine.Gl.UseProgram(program.Name);

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
                    Engine.Gl.BindBuffer(GL.ARRAY_BUFFER, view.Buffer.Name);
                    Engine.Gl.VertexAttribPointer(
                        (uint)attribute.Position,
                        view.Size,
                        view.Type,
                        true,
                        view.Stride,
                        new IntPtr(view.Offset)
                    );
                    Engine.Gl.BindBuffer(GL.ARRAY_BUFFER, 0);
                    Engine.Gl.EnableVertexAttribArray((uint)attribute.Position);
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

            Engine.Gl.DrawArrays(GL.TRIANGLE_FAN, 0, 4);

            // Cleanup

            // Uniforms


            // Attributes
            foreach (var attribute in program.Attributes)
            {
                Engine.Gl.DisableVertexAttribArray((uint)attribute.Position);
            }

            Engine.Gl.UseProgram(0);
        }
    }
}
