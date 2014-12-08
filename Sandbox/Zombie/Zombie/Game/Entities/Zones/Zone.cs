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
        private string m_id;

        public Map Map { get { return m_map; } }
        public string Id { get { return m_id; } }

        public List<Wall> Walls { get; set; }
        public List<Light> Lights { get; set; }
        public Floor Floor { get; set; }
        

        public Zone(Map map, string id)
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
            var key = Map.GetKey(m_id);
            transform *= Matrix4.Translate(m_map.ZoneSize.X * key.Item1, m_map.ZoneSize.Y * key.Item2, 0);

            Floor.Render(transform);
            m_wallRenderer.Render(transform);

            //m_lightRenderer.Render(transform);
        }

        public void RenderLights(Matrix4 transform)
        {
            var key = Map.GetKey(m_id);
            transform *= Matrix4.Translate(m_map.ZoneSize.X * key.Item1, m_map.ZoneSize.Y * key.Item2, 0);

            //GL.PolygonMode(GL.FRONT_AND_BACK, GL.LINE);
            m_lightRenderer.Render(transform);
            //GL.PolygonMode(GL.FRONT_AND_BACK, GL.FILL);
        }

    }
}
