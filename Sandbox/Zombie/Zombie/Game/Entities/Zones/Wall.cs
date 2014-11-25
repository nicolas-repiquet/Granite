using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zombie.Game.Entities.Tools;

namespace Zombie.Game.Entities.Zones
{
    public class Wall
    {
        private readonly List<Segment> m_walls;

        public List<Segment> Walls { get { return m_walls; } }

        public Wall(List<Segment> walls)
        {
            m_walls = walls;
        }
    }
}
