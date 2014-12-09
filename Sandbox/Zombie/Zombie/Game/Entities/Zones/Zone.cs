using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zombie.Game.Entities.Components;
using Zombie.Game.Entities.Tools;
using Zombie.Game.Entities.Zones.Trees;
using Zombie.Game.Sprites;

namespace Zombie.Game.Entities.Zones
{
    public class Zone : IUpdatable, IRenderable
    {
        private Map m_map;
        private SegmentRenderer m_wallRenderer;
        private TriangleFanRenderer m_lightRenderer;
        protected SpriteRenderer m_treeRenderer;
        private Vector2i m_id;

        public Map Map { get { return m_map; } }
        public Vector2i Id { get { return m_id; } }

        public List<Wall> Walls { get; set; }
        public List<Light> Lights { get; set; }
        public List<Tree> Trees { get; set; }
        public Floor Floor { get; set; }


        public Zone(Map map, Vector2i id)
        {
            m_id = id;
            m_map = map;
            Walls = new List<Wall>();
            Lights = new List<Light>();
            Trees = new List<Tree>();
            m_wallRenderer = new SegmentRenderer();
            m_lightRenderer = new TriangleFanRenderer();
            Floor = new Floor(this);
            m_treeRenderer = new SpriteRenderer(TreesSprites.Instance);

            Generate();
        }

        public void AddTree(Tree tree)
        {
            tree.SetSprite(m_treeRenderer);
            Trees.Add(tree);
        }

        private void Generate()
        {
            //Walls
            for (var i = 0; i < 1; i++)
            {
                var x = m_map.Random.Next(0, m_map.ZoneSize.X);
                var y = m_map.Random.Next(0, m_map.ZoneSize.Y);

                var width = m_map.Random.Next(10, 100);
                var height = m_map.Random.Next(10, 100);
                 
                //var x = m_map.ZoneSize.X / 2 + 50;
                //var y = m_map.ZoneSize.Y / 2 + 50;

                //var width = 50;
                //var height = 50;

                var p1 = new Vector2(x, y);
                var p2 = new Vector2(x + width, y);
                var p3 = new Vector2(x + width, y + height);
                var p4 = new Vector2(x, y + height);

                Walls.Add(
                    new Wall(
                        new List<Segment>()
                        {
                            new Segment(p1, p2),
                            new Segment(p2, p3),
                            new Segment(p3, p4),
                            new Segment(p4, p1)
                        }
                    )
                );
            }

            //Tree
            for (var i = 0; i < 2; i++)
            {
                var x = m_map.Random.Next(0+50, m_map.ZoneSize.X-50);
                var y = m_map.Random.Next(0+50, m_map.ZoneSize.Y-50);

                var t = new Tree1();
                t.SetPosition(new Vector2(x, y));
                AddTree(t);
            }

            //Lights
            for (var i = 0; i < 1; i++)
            {
                //var x = m_map.Random.Next(0, m_map.ZoneSize.X);
                //var y = m_map.Random.Next(0, m_map.ZoneSize.Y);
                var x = m_map.ZoneSize.X/2;
                var y = m_map.ZoneSize.Y/2;

                var radius = m_map.ZoneSize.X/2-20;

                Lights.Add(
                    new Light(
                        new Vector2(x, y),
                        radius,
                        new Color4ub(255, 255, 255, 255),
                        new Color4ub(0, 0, 0, 255))
                );
            }

            foreach (var wall in Walls)
            {
                foreach (var segment in wall.Walls)
                {
                    foreach (var light in Lights)
                    {
                        light.Cone.Add(segment.P1, segment.P2);
                    }
                    m_wallRenderer.AddSegment(segment);
                }
            }

            foreach (var light in Lights)
            {
                var points = light.Cone.GetPath();
                foreach (var point in points)
                {
                    m_lightRenderer.AddVertex(point.Point, point.Color);
                }
            }
        }

        public void Update(TimeSpan elapsed)
        {
            Parallel.ForEach(Trees, x => 
                {
                    x.Update(elapsed);
                });
        }

        public void Render(Matrix4 transform)
        {
            transform *= Matrix4.Translate(m_map.ZoneSize.X * m_id.X, m_map.ZoneSize.Y * m_id.Y, 0);

            Floor.Render(transform);
            m_wallRenderer.Render(transform);

            m_treeRenderer.Render(transform);

            //m_lightRenderer.Render(transform);
        }

        public void RenderLights(Matrix4 transform)
        {
            transform *= Matrix4.Translate(m_map.ZoneSize.X * m_id.X, m_map.ZoneSize.Y * m_id.Y, 0);

            //GL.PolygonMode(GL.FRONT_AND_BACK, GL.LINE);
            m_lightRenderer.Render(transform);
            //GL.PolygonMode(GL.FRONT_AND_BACK, GL.FILL);
        }

    }
}
