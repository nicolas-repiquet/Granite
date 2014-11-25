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
        private SegmentRenderer m_renderer;
        private Tuple<int, int> m_id;

        public List<Wall> Walls { get; set; }

        public Zone(Map map, Tuple<int, int> id)
        {
            m_id = id;
            m_map = map;
            Walls = new List<Wall>();
            m_renderer = new SegmentRenderer();

            Generate();
        }

        private void Generate()
        {
            var random = new Random();

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

            foreach (var wall in Walls)
            {
                foreach (var segment in wall.Walls)
                {
                    m_renderer.AddSegment(segment);
                }
            }
        }

        public void Update(TimeSpan elapsed)
        {
            
        }

        public void Render(Matrix4 transform)
        {
            transform *= Matrix4.Translate(m_map.ZoneSize.X * m_id.Item1, m_map.ZoneSize.Y * m_id.Item2, 0);

            m_renderer.Render(transform);
        }
    }
}
