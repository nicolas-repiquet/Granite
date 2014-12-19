using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granite.Render
{
    public sealed class RenderManager
    {
        private static RenderManager s_instance;
        public static RenderManager Instance
        {
            get
            {
                if (s_instance == null)
                {
                    s_instance = new RenderManager();
                }
                return s_instance;
            }
        }

        private Dictionary<int, List<RenderObject>> m_renderObjects;
        private Dictionary<string, int> m_layers;
        private int m_layerCounter;
        private Renderer m_renderer;

        public RenderManager()
        {
            m_renderObjects = new Dictionary<int, List<RenderObject>>();
            m_layers = new Dictionary<string, int>();
            m_layerCounter = 0;
        }

        public void SetRenderer(Renderer renderer)
        {
            m_renderer = renderer;
        }

        public void AddLayer(string name)
        {
            if(!m_layers.ContainsKey(name))
            {
                var id = m_layerCounter++;
                m_layers.Add(name, id);
                m_renderObjects.Add(id, new List<RenderObject>());
            }
        }

        public int GetLayerId(string name)
        {
            if (m_layers.ContainsKey(name))
            {
                return m_layers[name];
            }
            throw new Exception("Le layer demandé n'existe pas");
        }

        public void AddSprite(Sprite sprite, Vector2 position, Vector2i size, string layer, Color4ub? color = null)
        {
            var ro = new RenderObject()
            {
                Sprite = sprite,
                Position = new Vector2[] { position },
                Size = size,
                Color = color.HasValue ? color.Value : new Color4ub(255, 255, 255, 255)
            };

            m_renderObjects[GetLayerId(layer)].Add(ro);
        }

        public void AddSpriteSequence(SpriteSequence sequence, Vector2 position, Vector2i size, string layer, Color4ub? color = null)
        {
            var ro = new RenderObject()
            {
                SpriteSequence = sequence,
                Position = new Vector2[] { position },
                Size = size,
                Color = color.HasValue ? color.Value : new Color4ub(255, 255, 255, 255)
            };

            m_renderObjects[GetLayerId(layer)].Add(ro);
        }

        public void AddTriangle(Vector2[] position, string layer, Vector2i? size = null, Color4ub? color = null)
        {
            var ro = new RenderObject()
            {
                Position = position,
                Size = size.HasValue ? size.Value : new Vector2i(1, 1),
                Color = color.HasValue ? color.Value : new Color4ub(255, 255, 255, 255)
            };

            m_renderObjects[GetLayerId(layer)].Add(ro);
        }

        private void Clean()
        {
            foreach (var layer in m_renderObjects)
            {
                layer.Value.Clear();
            }
        }

        public void Render(TimeSpan elapsed, Matrix4 transform)
        {
            //On met à jour les sprites des séquences
            //var objNeedUpdate = m_renderObjects.SelectMany(x => x.Value).Where(x => x.SpriteSequence != null);

            //Parallel.ForEach(objNeedUpdate, x =>
            //    {
            //        x.SpriteSequence.Update(elapsed);
            //    });

            //On passe tout les objets à dessiner au renderer
            foreach (var layer in m_renderObjects)
            {
                foreach (var obj in layer.Value)
                {
                    m_renderer.AddRenderObject(obj);
                }
            }

            Clean();

            m_renderer.Render(transform);
        }
    }
}
