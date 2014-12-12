using Granite.Core;
using Granite.Particle.Renderer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Granite.Particle.Textures
{
    public class ParticleTexture
    {
        private static ParticleTexture s_instance;
        public static ParticleTexture Instance
        {
            get
            {
                if (s_instance == null)
                {
                    s_instance = new ParticleTexture();
                }
                return s_instance;
            }
        }

        private readonly Texture2D m_texture;
        private readonly SpriteSheet m_sheet;
        private readonly Sprite m_sprite;

        public SpriteSheet SpriteSheet { get { return m_sheet; } }
        public Sprite Sprite { get { return m_sprite; } }

        public ParticleTexture()
        {
            m_texture = Texture2D.Load(typeof(Particle).Assembly.GetManifestResourceStream("Granite.Particle.Textures.fire.png"));
            m_sheet = new SpriteSheet(m_texture);
            m_sprite = m_sheet.AddSprite("", new Box2i(Vector2i.Zero, m_texture.Size));
        }
    }
}
