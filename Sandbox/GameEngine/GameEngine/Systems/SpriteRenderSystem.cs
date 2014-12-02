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
    public class SpriteRenderSystem : System, IRenderSystem
    {
        private Dictionary<Guid, GameObject> m_datas;
        private SpriteRenderer m_renderer;

        public SpriteRenderSystem()
            :base(SystemType.SpriteRenderSystem)
        {
            m_datas = new Dictionary<Guid, GameObject>();
            m_renderer = new SpriteRenderer(MapSprites.Instance);
        }

        public void Update(TimeSpan elapsed)
        {
            m_renderer.Clear();

            //foreach(var data in m_datas)
            //{
            //    data.Value.Sprite = m_renderer.AddSprite(MapSprites.Instance.Grass);
            //    data.Value.Sprite.Position = new Vector2(data.Value.Location.X, data.Value.Location.Y);
            //    data.Value.Sprite.Size = new Vector2(1, 1);
            //    data.Value.Sprite.Sprite = MapSprites.Instance.Grass;
            //};

            Console.WriteLine("[SpriteRenderSystem] Update ended");
        }

        public void Render(Matrix4 transform)
        {
            m_renderer.Render(transform);

            Console.WriteLine("[SpriteRenderSystem] Render ended");
        }
    }
}
