using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Test.Game_01.Sprites;

namespace Test.Game_01.Entities
{
    public sealed class Background : Entity, IUpdatable, IRenderable
    {
        private readonly Camera m_camera;

        private readonly Texture2D m_backgroundTexture_01;
        private readonly SpriteSheet m_backgroundSheet_01;
        private readonly Sprite m_backgroundSprite_01;
        private readonly SpriteRenderer m_backgroundRenderer_01;
        private readonly ISpriteInstance m_backgroundInstance_01;

        private readonly Texture2D m_backgroundTexture_02;
        private readonly SpriteSheet m_backgroundSheet_02;
        private readonly Sprite m_backgroundSprite_02;
        private readonly SpriteRenderer m_backgroundRenderer_02;
        private readonly ISpriteInstance m_backgroundInstance_02_First;
        private readonly ISpriteInstance m_backgroundInstance_02_Second;

        public Background(Camera camera)
        {
            m_camera = camera;

            m_backgroundTexture_01 = Texture2D.Load(typeof(Background).Assembly.GetManifestResourceStream("Test.Game_01.Textures.Background_01.png"));
            m_backgroundSheet_01 = new SpriteSheet(m_backgroundTexture_01);
            m_backgroundSprite_01 = m_backgroundSheet_01.AddSprite("", new Box2i(Vector2i.Zero, m_backgroundTexture_01.Size));
            m_backgroundRenderer_01 = new SpriteRenderer(m_backgroundSheet_01);
            m_backgroundInstance_01 = m_backgroundRenderer_01.AddSprite(m_backgroundSprite_01);

            m_backgroundTexture_02 = Texture2D.Load(typeof(Background).Assembly.GetManifestResourceStream("Test.Game_01.Textures.Background_02.png"));
            m_backgroundSheet_02 = new SpriteSheet(m_backgroundTexture_02);
            m_backgroundSprite_02 = m_backgroundSheet_02.AddSprite("", new Box2i(Vector2i.Zero, m_backgroundTexture_02.Size));
            m_backgroundRenderer_02 = new SpriteRenderer(m_backgroundSheet_02);
            m_backgroundInstance_02_First = m_backgroundRenderer_02.AddSprite(m_backgroundSprite_02);
            m_backgroundInstance_02_Second = m_backgroundRenderer_02.AddSprite(m_backgroundSprite_02);
        }

        public void Update(TimeSpan elapsed)
        {
            m_backgroundInstance_01.Position = m_camera.Location.Position;
            m_backgroundInstance_01.Size = m_camera.Location.Size;

            var x = m_camera.Location.MinX;
            var width = m_camera.Location.Size.X;

            var offset = (x * 0.2) % width;

            m_backgroundInstance_02_First.Position = new Vector2d(x - offset, m_camera.Location.MinY * 0.9);
            m_backgroundInstance_02_First.Size = m_camera.Location.Size;
            m_backgroundInstance_02_Second.Position = new Vector2d(x + width - offset, m_camera.Location.MinY * 0.9);
            m_backgroundInstance_02_Second.Size = m_camera.Location.Size;
        }

        public void Render(Matrix4 transform)
        {
            m_backgroundRenderer_01.Render(transform);
            m_backgroundRenderer_02.Render(transform);
        }

    }
}
