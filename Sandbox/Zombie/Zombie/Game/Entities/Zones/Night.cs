using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zombie.Game.Entities.Components;
using Zombie.Game.Entities.Tools;
using Zombie.Game.Sprites;

namespace Zombie.Game.Entities.Zones
{
    public class Night : IUpdatable, IRenderable
    {
        private Camera m_camera;
        private readonly Texture2D m_backgroundTexture;
        private readonly SpriteSheet m_backgroundSheet;
        private readonly Sprite m_backgroundSprite;
        private readonly SpriteRenderer m_backgroundRenderer;
        private readonly ISpriteInstance m_backgroundInstance;

        private Texture2D m_lightTexture;
        private SpriteSheet m_lightSheet;
        private Sprite m_lightSprite;
        private SpriteRenderer m_lightRenderer;
        private ISpriteInstance m_lightInstance;

        private Texture2D m_finalTexture;
        private SpriteSheet m_finalSheet;
        private Sprite m_finalSprite;
        private SpriteRenderer m_finalRenderer;
        private ISpriteInstance m_finalInstance;

        private Texture2D m_lights;
        private Texture2D m_final;
        private Framebuffer m_framebuffer;

        public Night(Camera camera)
        {
            m_camera = camera;

            m_backgroundTexture = Texture2D.Load(typeof(Floor).Assembly.GetManifestResourceStream("Zombie.Game.Textures.night.png"));
            m_backgroundSheet = new SpriteSheet(m_backgroundTexture);
            m_backgroundSprite = m_backgroundSheet.AddSprite("", new Box2i(Vector2i.Zero, m_backgroundTexture.Size));
            m_backgroundRenderer = new SpriteRenderer(m_backgroundSheet);
            m_backgroundInstance = m_backgroundRenderer.AddSprite(m_backgroundSprite);

            

            m_framebuffer = new Framebuffer();
            m_final = new Texture2D();
            var size = Engine.Display.GetSize();
            m_final.SetData<Color4ub>(size.X, size.Y, null);
            m_framebuffer.Attach(m_final);
        }

        public void SetTextureLights(Texture2D lights)
        {
            m_lights = lights;
        }

        public void Update(TimeSpan elapsed)
        {
            
            m_backgroundInstance.Position = m_camera.Box.Position;
            m_backgroundInstance.Size = m_camera.Box.Size;

            if (m_lights != null)
            {
                m_lightTexture = m_lights;
                m_lightSheet = new SpriteSheet(m_lightTexture);
                m_lightSprite = m_lightSheet.AddSprite("", new Box2i(Vector2i.Zero, m_lightTexture.Size));
                m_lightRenderer = new SpriteRenderer(m_lightSheet);
                m_lightInstance = m_lightRenderer.AddSprite(m_lightSprite);

                m_lightInstance.Position = m_camera.Box.Position;
                m_lightInstance.Size = m_camera.Box.Size;
            }

            if (m_final != null)
            {
                m_finalTexture = m_final;
                m_finalSheet = new SpriteSheet(m_finalTexture);
                m_finalSprite = m_finalSheet.AddSprite("", new Box2i(Vector2i.Zero, m_finalTexture.Size));
                m_finalRenderer = new SpriteRenderer(m_finalSheet);
                m_finalInstance = m_finalRenderer.AddSprite(m_finalSprite);

                m_finalInstance.Position = m_camera.Box.Position;
                m_finalInstance.Size = m_camera.Box.Size;
            }
        }

        public void Render(Matrix4 transform)
        {
            GL.BindFramebuffer(m_framebuffer);

            GL.ClearColor(0.2f, 0.2f, 0.2f, 1f);
            GL.Clear(GL.COLOR_BUFFER_BIT);

            //m_backgroundRenderer.Render(transform);

            if (m_lightRenderer != null)
            {
                m_lightRenderer.Render(transform);
            }

            GL.BindFramebuffer(null);

            GL.BlendFunc(GL.ONE, GL.SRC_COLOR);
            GL.BlendEquation(GL.FUNC_ADD);

            if (m_finalRenderer != null)
            {
                m_finalRenderer.Render(transform);
            }
        }
    }
}
