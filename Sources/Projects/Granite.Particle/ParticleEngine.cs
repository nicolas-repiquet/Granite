using Granite.Core;
using Granite.Particle.Renderer;
using Granite.Particle.Textures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Granite.Particle
{
    public class ParticleEngine
    {
        private Random random;
        public Vector2 EmitterLocation { get; set; }
        private List<Particle> particles;
        private List<Texture2D> textures;
        private Vector2 m_velocity;
        private int m_ttl;
        private float m_size;

        private readonly SpriteRenderer m_renderer;

        public List<Particle> Particles { get { return particles; } }

        public ParticleEngine(List<Texture2D> textures, Vector2 location, Vector2 velocity, int ttl = 50, float size = 1f)
        {
            EmitterLocation = location;
            this.textures = textures;
            this.particles = new List<Particle>();
            random = new Random();
            m_velocity = velocity;
            m_ttl = ttl;
            m_size = size;

            m_renderer = new SpriteRenderer(ParticleTexture.Instance.SpriteSheet);
        }

        public void Update(TimeSpan elapsed)
        {
            int total = 20;

            for (int i = 0; i < total - particles.Count; i++)
            {
                particles.Add(GenerateNewParticle());
            }

            m_renderer.Clear();

            for (int particle = 0; particle < particles.Count; particle++)
            {
                particles[particle].SetSprite(m_renderer);
                particles[particle].Update(elapsed);
                if (particles[particle].TTL <= 0)
                {
                    particles.RemoveAt(particle);
                    particle--;
                }
            }
        }

        private Particle GenerateNewParticle()
        {
            Texture2D texture = null;// textures[random.Next(textures.Count)];
            Vector2 position = EmitterLocation;
            Vector2 velocity = new Vector2(m_velocity.X + (float)random.Next(-10, 10), m_velocity.Y);

            float angle = 0;
            float angularVelocity = 1f * (float)(random.NextDouble() * 2 - 1);
            Color4ub color = new Color4ub(
                        (byte)random.Next(80, 100),
                        (byte)random.Next(30, 50),
                        (byte)random.Next(10, 25),
                        1);
            float size = m_size * (float)random.NextDouble();
            int ttl = m_ttl + random.Next((int)(m_ttl * 0.4));

            return new Particle(texture, position, velocity, angle, angularVelocity, color, size, ttl);
        }

        public void Draw(Matrix4 transform)
        {
            m_renderer.Render(transform);
        }
    }
}
