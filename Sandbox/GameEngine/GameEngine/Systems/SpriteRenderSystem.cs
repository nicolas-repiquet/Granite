using GameEngine.Components;
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
    public class SpriteRenderSystem : ISystem, IUpdateSystem, IRenderSystem
    {
        private class SpriteRenderData
        {
            public LocationComponent Location { get; set; }
            public QuadComponent Quad { get; set; }
            public TextureComponent Texture { get; set; }
            public ColorComponent Color { get; set; }
            public ISpriteInstance Sprite { get; set; }

            public bool IsComplete { 
                get {
                    return Location != null && Quad != null && Texture != null; 
                } 
            }
        }

        private Dictionary<Guid, SpriteRenderData> m_datas;
        private SpriteRenderer m_renderer;

        public SpriteRenderSystem()
        {
            m_datas = new Dictionary<Guid, SpriteRenderData>();
            m_renderer = new SpriteRenderer(MapSprites.Instance);
        }

        public void Update(TimeSpan elapsed)
        {
            m_renderer.Clear();

            foreach(var data in m_datas.Where(x => x.Value.IsComplete))
            {
                data.Value.Sprite = m_renderer.AddSprite(MapSprites.Instance.Grass);
                data.Value.Sprite.Position = new Vector2(data.Value.Location.X, data.Value.Location.Y);
                data.Value.Sprite.Size = new Vector2(1, 1);
                data.Value.Sprite.Sprite = MapSprites.Instance.Grass;
            };
        }

        public void Render(Matrix4 transform)
        {
            m_renderer.Render(transform);
        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(Component value)
        {
            if (value != null)
            {
                SpriteRenderData data = null;

                if (m_datas.ContainsKey(value.ComponentParentId))
                {
                    data = m_datas[value.ComponentParentId];

                    if (value.ComponentType == ComponentType.Location)
                    {
                        data.Location = value as LocationComponent;
                    }
                    else if (value.ComponentType == ComponentType.Quad)
                    {
                        data.Quad = value as QuadComponent;
                    }
                    else if (value.ComponentType == ComponentType.Texture)
                    {
                        data.Texture = value as TextureComponent;
                    }
                }
                else
                {
                    data = new SpriteRenderData();

                    if (value.ComponentType == ComponentType.Location)
                    {
                        data.Location = value as LocationComponent;
                    }
                    else if (value.ComponentType == ComponentType.Quad)
                    {
                        data.Quad = value as QuadComponent;
                    }
                    else if (value.ComponentType == ComponentType.Texture)
                    {
                        data.Texture = value as TextureComponent;
                    }

                    m_datas.Add(value.ComponentParentId, data);
                }

                
            }
        }

        
    }
}
