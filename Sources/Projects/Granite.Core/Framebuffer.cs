using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Granite.Core
{
    public sealed class Framebuffer : ApplicationResource
    {
        private readonly uint m_name;

        public Framebuffer()
        {
            m_name = GL.GenFramebuffer();
        }

        internal uint Name { get { return m_name; } }

        protected override void InternalDispose()
        {
            var name = m_name;

            Engine.ExecuteAction(() =>
            {
                GL.DeleteFramebuffer(name);
            });
        }

        public void Attach(Texture2D texture, uint attachment = GL.COLOR_ATTACHMENT0, int level = 0)
        {
            var currentFramebuffer = (uint)GL.GetInteger(GL.DRAW_FRAMEBUFFER_BINDING);

            if (currentFramebuffer != m_name)
            {
                GL.BindFramebuffer(this, GL.DRAW_FRAMEBUFFER);
            }

            GL.FramebufferTexture2D(
                GL.DRAW_FRAMEBUFFER, attachment, 
                GL.TEXTURE_2D, texture == null ? 0 : texture.Name, 0
            );

            if (currentFramebuffer != m_name)
            {
                GL.BindFramebuffer(GL.DRAW_FRAMEBUFFER, currentFramebuffer);
            }
        }
    }
}
