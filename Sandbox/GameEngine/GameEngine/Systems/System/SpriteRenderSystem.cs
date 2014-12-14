using GameEngine.Components;
using GameEngine.Entities;
using GameEngine.Graphics;
using GameEngine.Graphics.Textures;
using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Systems
{
    public class SpriteRenderSystem : ISystem
    {
        private SpriteRenderer m_renderer;

        public SpriteRenderSystem()
        {
            m_renderer = new SpriteRenderer(MapSprites.Instance);
        }

        public void Start()
        {
            Console.WriteLine("[SpriteRenderSystem] Started");
        }

        public void Update(TimeSpan elapsed, Matrix4 transform)
        {
            m_renderer.Clear();


            m_renderer.Render(transform);

            Console.WriteLine("[SpriteRenderSystem] Update ended");
        }

        public void End()
        {
            Console.WriteLine("[SpriteRenderSystem] Ended");
        }
    }
}
