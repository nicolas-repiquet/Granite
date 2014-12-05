using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zombie.Game.Entities.Components;

namespace Zombie.Game.Entities.Zones
{
    public class Map: IUpdatable, IRenderable
    {
        private Dictionary<Tuple<int, int>, Zone> m_zones;
        private Zone m_currentZone;
        private Tuple<int, int> m_currentZoneIndex;

        public Zone CurrentZone { get { return m_currentZone; } }

        public Vector2i ZoneSize { get; set; }

        public Map(Vector2i zoneSize)
        {
            m_zones = new Dictionary<Tuple<int, int>, Zone>();
            ZoneSize = zoneSize;

            Initialize();
        }

        public void Initialize()
        {
            var index = new Tuple<int, int>(0, 0);
            var zone = new Zone(this, index);
            m_zones.Add(index, zone);
            m_currentZone = zone;
            m_currentZoneIndex = index;

            AddZoneAtLeft();
            AddZoneAtTop();
            AddZoneAtRight();
            AddZoneAtDown();
            AddZoneAtDownRight();
            AddZoneAtDownLeft();
            AddZoneAtTopLeft();
            AddZoneAtTopRight();
        }

        public void AddZoneAtLeft()
        {
            var index = new Tuple<int, int>(m_currentZoneIndex.Item1 - 1, m_currentZoneIndex.Item2);

            if (!m_zones.ContainsKey(index))
            {
                m_zones.Add(index, new Zone(this, index));
            }
        }

        public void AddZoneAtTop()
        {
            var index = new Tuple<int, int>(m_currentZoneIndex.Item1, m_currentZoneIndex.Item2 + 1);

            if (!m_zones.ContainsKey(index))
            {
                m_zones.Add(index, new Zone(this, index));
            }
        }

        public void AddZoneAtRight()
        {
            var index = new Tuple<int, int>(m_currentZoneIndex.Item1 + 1, m_currentZoneIndex.Item2);

            if (!m_zones.ContainsKey(index))
            {
                m_zones.Add(index, new Zone(this, index));
            }
        }

        public void AddZoneAtDown()
        {
            var index = new Tuple<int, int>(m_currentZoneIndex.Item1, m_currentZoneIndex.Item2 - 1);

            if (!m_zones.ContainsKey(index))
            {
                m_zones.Add(index, new Zone(this, index));
            }
        }

        public void AddZoneAtTopLeft()
        {
            var index = new Tuple<int, int>(m_currentZoneIndex.Item1 - 1, m_currentZoneIndex.Item2 + 1);

            if (!m_zones.ContainsKey(index))
            {
                m_zones.Add(index, new Zone(this, index));
            }
        }

        public void AddZoneAtTopRight()
        {
            var index = new Tuple<int, int>(m_currentZoneIndex.Item1 + 1, m_currentZoneIndex.Item2 + 1);

            if (!m_zones.ContainsKey(index))
            {
                m_zones.Add(index, new Zone(this, index));
            }
        }

        public void AddZoneAtDownLeft()
        {
            var index = new Tuple<int, int>(m_currentZoneIndex.Item1 - 1, m_currentZoneIndex.Item2 - 1);

            if (!m_zones.ContainsKey(index))
            {
                m_zones.Add(index, new Zone(this, index));
            }
        }

        public void AddZoneAtDownRight()
        {
            var index = new Tuple<int, int>(m_currentZoneIndex.Item1 + 1, m_currentZoneIndex.Item2 - 1);

            if (!m_zones.ContainsKey(index))
            {
                m_zones.Add(index, new Zone(this, index));
            }
        }

        public void Update(TimeSpan elapsed)
        {
            //On récupère la position du joueur et on met a jour les zones
            var player = World.World.Instance.Player;

            var indexPlayer = new Tuple<int, int>((int)Math.Floor(player.Location.Position.X / ZoneSize.X),
                (int)Math.Floor(player.Location.Position.Y / ZoneSize.Y));

            if (indexPlayer != m_currentZoneIndex)
            {
                m_currentZone = m_zones[indexPlayer];
                m_currentZoneIndex = indexPlayer;

                AddZoneAtLeft();
                AddZoneAtTop();
                AddZoneAtRight();
                AddZoneAtDown();
                AddZoneAtDownRight();
                AddZoneAtDownLeft();
                AddZoneAtTopLeft();
                AddZoneAtTopRight();
            }

            if (m_currentZone != null)
            {
                for(var row=m_currentZoneIndex.Item1-1; row<=m_currentZoneIndex.Item1+1; row++)
                {
                    for (var col = m_currentZoneIndex.Item2 - 1; col <= m_currentZoneIndex.Item2 + 1; col++)
                    {
                        m_zones[new Tuple<int, int>(row, col)].Update(elapsed);
                    }
                }
            }
        }

        public void Render(Matrix4 transform)
        {
            if (m_currentZone != null)
            {
                for (var row = m_currentZoneIndex.Item1 - 1; row <= m_currentZoneIndex.Item1 + 1; row++)
                {
                    for (var col = m_currentZoneIndex.Item2 - 1; col <= m_currentZoneIndex.Item2 + 1; col++)
                    {
                        m_zones[new Tuple<int, int>(row, col)].Render(transform);
                    }
                }
                
            }
        }

        public void RenderLights(Matrix4 transform)
        {
            if (m_currentZone != null)
            {
                for (var row = m_currentZoneIndex.Item1 - 1; row <= m_currentZoneIndex.Item1 + 1; row++)
                {
                    for (var col = m_currentZoneIndex.Item2 - 1; col <= m_currentZoneIndex.Item2 + 1; col++)
                    {
                        m_zones[new Tuple<int, int>(row, col)].RenderLights(transform);
                    }
                }

            }
        }

    }
}
