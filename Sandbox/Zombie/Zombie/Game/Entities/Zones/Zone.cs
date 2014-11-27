using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zombie.Game.Entities.Components;
using Zombie.Game.Entities.Tools;

namespace Zombie.Game.Entities.Zones
{
    public class Zone : IUpdatable, IRenderable
    {
        private Map m_map;
        private SegmentRenderer m_wallRenderer;
        private TriangleRenderer m_lightRenderer;
        private Tuple<int, int> m_id;

        public Map Map { get { return m_map; } }
        public Tuple<int, int> Id { get { return m_id; } }

        public List<Wall> Walls { get; set; }
        public List<Light> Lights { get; set; }
        public Floor Floor { get; set; }
        

        public Zone(Map map, Tuple<int, int> id)
        {
            m_id = id;
            m_map = map;
            Walls = new List<Wall>();
            Lights = new List<Light>();
            m_wallRenderer = new SegmentRenderer();
            m_lightRenderer = new TriangleRenderer();
            Floor = new Floor(this);
            

            Generate();
        }

        private void Generate()
        {
            var random = new Random();

            //Walls
            for (var i = 0; i < 10; i++)
            {
                var x = random.Next(0,m_map.ZoneSize.X - 100);
                var y = random.Next(0, m_map.ZoneSize.Y - 100);

                var width = random.Next(10, 100);
                var height = random.Next(10, 100);

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

            //Lights
            for (var i = 0; i < 5; i++)
            {
                var x = random.Next(0, m_map.ZoneSize.X - 100);
                var y = random.Next(0, m_map.ZoneSize.Y - 100);

                var radius = random.Next(10, 100);

                Lights.Add(
                    new Light(
                        new Vector3(x, y, 0),
                        radius,
                        new Vector4(1, 1, 1, 0.4f),
                        new Vector4(1, 1, 0, 0f))
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
                var triangles = light.Cone.ToTriangles();
                foreach (var triangle in triangles)
                {
                    m_lightRenderer.AddTriangle(triangle);
                }
            }
        }

        public void Update(TimeSpan elapsed)
        {
            
        }

        public void Render(Matrix4 transform)
        {
            transform *= Matrix4.Translate(m_map.ZoneSize.X * m_id.Item1, m_map.ZoneSize.Y * m_id.Item2, 0);

            Floor.Render(transform);
            m_wallRenderer.Render(transform);

            m_lightRenderer.Render(transform);
        }

        public void RenderLights(Matrix4 transform)
        {
            transform *= Matrix4.Translate(m_map.ZoneSize.X * m_id.Item1, m_map.ZoneSize.Y * m_id.Item2, 0);

            m_lightRenderer.Render(transform);
        }
    }
}
