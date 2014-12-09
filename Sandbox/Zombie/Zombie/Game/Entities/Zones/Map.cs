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
        private Dictionary<Vector2i, Zone> m_zones;
        private Zone m_currentZone;
        private Vector2i m_currentZoneIndex;
        private Vector2i m_currentMinZoneIndex;
        private Vector2i m_currentMaxZoneIndex;
        private Random m_random;
        private bool m_isUpdated;

        public Zone CurrentZone { get { return m_currentZone; } }
        public Random Random { get { return m_random; } }

        public Vector2i ZoneSize { get; set; }

        public Map(Vector2i zoneSize)
        {
            m_zones = new Dictionary<Vector2i, Zone>();
            ZoneSize = zoneSize;
            m_random = new Random();
            m_isUpdated = false;
        }

        public void Initialize()
        {
            var index = new Vector2i(0, 0);
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

        public void CameraHasChanged()
        {
            m_isUpdated = true;

            AddZoneAtLeft();
            AddZoneAtTop();
            AddZoneAtRight();
            AddZoneAtDown();
            AddZoneAtDownRight();
            AddZoneAtDownLeft();
            AddZoneAtTopLeft();
            AddZoneAtTopRight();

            m_isUpdated = false;
        }

        public void AddZoneAtLeft()
        {
            var box = World.World.Instance.Camera.Box;

            for (var i = 1; i <= (box.Size.X/2)/ZoneSize.X+1; i++)
            {
                var index = new Vector2i(m_currentZoneIndex.X - i, m_currentZoneIndex.Y);

                if (!m_zones.ContainsKey(index))
                {
                    m_zones.Add(index, new Zone(this, index));
                }
            }
        }

        public void AddZoneAtTop()
        {
            var box = World.World.Instance.Camera.Box;

            for (var i = 1; i <= (box.Size.Y / 2) / ZoneSize.Y + 1; i++)
            {
                var index = new Vector2i(m_currentZoneIndex.X, m_currentZoneIndex.Y + i);

                if (!m_zones.ContainsKey(index))
                {
                    m_zones.Add(index, new Zone(this, index));
                }
            }
        }

        public void AddZoneAtRight()
        {
            var box = World.World.Instance.Camera.Box;

            for (var i = 1; i <= (box.Size.X / 2) / ZoneSize.X + 1; i++)
            {
                var index = new Vector2i(m_currentZoneIndex.X + i, m_currentZoneIndex.Y);

                if (!m_zones.ContainsKey(index))
                {
                    m_zones.Add(index, new Zone(this, index));
                }
            }
        }

        public void AddZoneAtDown()
        {
            var box = World.World.Instance.Camera.Box;

            for (var i = 1; i <= (box.Size.Y / 2) / ZoneSize.Y + 1; i++)
            {
                var index = new Vector2i(m_currentZoneIndex.X, m_currentZoneIndex.Y - i);

                if (!m_zones.ContainsKey(index))
                {
                    m_zones.Add(index, new Zone(this, index));
                }
            }
        }

        public void AddZoneAtTopLeft()
        {
            var box = World.World.Instance.Camera.Box;

            for (var i = 1; i <= (box.Size.X / 2) / ZoneSize.X + 1; i++)
            {
                for (var j = 1; j <= (box.Size.Y / 2) / ZoneSize.Y + 1; j++)
                {
                    var index = new Vector2i(m_currentZoneIndex.X - i, m_currentZoneIndex.Y + j);

                    if (!m_zones.ContainsKey(index))
                    {
                        m_zones.Add(index, new Zone(this, index));
                    }
                }
            }
        }

        public void AddZoneAtTopRight()
        {
            var box = World.World.Instance.Camera.Box;

            for (var i = 1; i <= (box.Size.X / 2) / ZoneSize.X + 1; i++)
            {
                for (var j = 1; j <= (box.Size.Y / 2) / ZoneSize.Y + 1; j++)
                {
                    var index = new Vector2i(m_currentZoneIndex.X + i, m_currentZoneIndex.Y + j);

                    if (!m_zones.ContainsKey(index))
                    {
                        m_zones.Add(index, new Zone(this, index));
                    }
                }
            }
        }

        public void AddZoneAtDownLeft()
        {
            var box = World.World.Instance.Camera.Box;

            for (var i = 1; i <= (box.Size.X / 2) / ZoneSize.X + 1; i++)
            {
                for (var j = 1; j <= (box.Size.Y / 2) / ZoneSize.Y + 1; j++)
                {
                    var index = new Vector2i(m_currentZoneIndex.X - i, m_currentZoneIndex.Y - j);

                    if (!m_zones.ContainsKey(index))
                    {
                        m_zones.Add(index, new Zone(this, index));
                    }
                }
            }
        }

        public void AddZoneAtDownRight()
        {
            var box = World.World.Instance.Camera.Box;

            for (var i = 1; i <= (box.Size.X / 2) / ZoneSize.X + 1; i++)
            {
                for (var j = 1; j <= (box.Size.Y / 2) / ZoneSize.Y + 1; j++)
                {
                    var index = new Vector2i(m_currentZoneIndex.X + i, m_currentZoneIndex.Y - j);

                    if (!m_zones.ContainsKey(index))
                    {
                        m_zones.Add(index, new Zone(this, index));
                    }
                }
            }
        }

        public void Update(TimeSpan elapsed)
        {
            //On récupère la position du joueur et on met a jour les zones
            var player = World.World.Instance.Player;

            var indexPlayer = new Vector2i((int)Math.Floor(player.Location.Position.X / ZoneSize.X),
                (int)Math.Floor(player.Location.Position.Y / ZoneSize.Y));

            if (indexPlayer != m_currentZoneIndex)
            {
                m_currentZone = m_zones[indexPlayer];
                m_currentZoneIndex = indexPlayer;

                Console.WriteLine("Zone : " + m_currentZoneIndex);

                AddZoneAtLeft();
                AddZoneAtTop();
                AddZoneAtRight();
                AddZoneAtDown();
                AddZoneAtDownRight();
                AddZoneAtDownLeft();
                AddZoneAtTopLeft();
                AddZoneAtTopRight();
            }

            if (m_currentZone != null && !m_isUpdated)
            {
                //Calcul des zones visibles par la camera
                var positionCurrent = new Vector2i(m_currentZoneIndex.X * ZoneSize.X, m_currentZoneIndex.Y * ZoneSize.Y);
                var box = World.World.Instance.Camera.Box;

                m_currentMinZoneIndex = new Vector2i((int)(Math.Round(box.MinX / ZoneSize.X)), (int)(Math.Round(box.MinY / ZoneSize.Y)));
                m_currentMaxZoneIndex = new Vector2i((int)(Math.Round(box.MaxX / ZoneSize.X)), (int)(Math.Round(box.MaxY / ZoneSize.Y)));

                for (var row = m_currentMinZoneIndex.X - 1; row <= m_currentMaxZoneIndex.X + 1; row++)
                {
                    for (var col = m_currentMinZoneIndex.Y - 1; col <= m_currentMaxZoneIndex.Y + 1; col++)
                    {
                        var index = new Vector2i(row, col);
                        if (m_zones.ContainsKey(index))
                        {
                            m_zones[index].Update(elapsed);
                        }
                    }
                }
            }
        }

        public void Render(Matrix4 transform)
        {
            if (m_currentZone != null)
            {
                for (var row = m_currentMinZoneIndex.X - 1; row <= m_currentMaxZoneIndex.X + 1; row++)
                {
                    for (var col = m_currentMinZoneIndex.Y - 1; col <= m_currentMaxZoneIndex.Y + 1; col++)
                    {
                        var index = new Vector2i(row, col);
                        if (m_zones.ContainsKey(index))
                        {
                            m_zones[index].Render(transform);
                        }
                    }
                }
                //m_zones[CreateKey(key.Item1, key.Item2)].Render(transform);
            }
        }

        public void RenderLights(Matrix4 transform)
        {
            if (m_currentZone != null)
            {
                for (var row = m_currentMinZoneIndex.X - 1; row <= m_currentMaxZoneIndex.X + 1; row++)
                {
                    for (var col = m_currentMinZoneIndex.Y - 1; col <= m_currentMaxZoneIndex.Y + 1; col++)
                    {
                        var index = new Vector2i(row, col);
                        if (m_zones.ContainsKey(index))
                        {
                            m_zones[index].RenderLights(transform);
                        }
                    }
                }
            }
        }

    }
}
