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
        private Dictionary<string, Zone> m_zones;
        private Zone m_currentZone;
        private string m_currentZoneIndex;
        private string m_currentMinZoneIndex;
        private string m_currentMaxZoneIndex;
        private Random m_random;
        private bool m_isUpdated;

        public Zone CurrentZone { get { return m_currentZone; } }
        public Random Random { get { return m_random; } }

        public Vector2i ZoneSize { get; set; }

        public Map(Vector2i zoneSize)
        {
            m_zones = new Dictionary<string, Zone>();
            ZoneSize = zoneSize;
            m_random = new Random();
            m_isUpdated = false;
        }

        public string CreateKey(int x, int y)
        {
            return string.Format("{0}_{1}", x, y);
        }

        public Tuple<int, int> GetKey(string key)
        {
            var tab = key.Split('_');
            return new Tuple<int, int>(int.Parse(tab[0]), int.Parse(tab[1]));
        }

        public void Initialize()
        {
            var index = CreateKey(0, 0);
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
            var key = GetKey(m_currentZoneIndex);
            var box = World.World.Instance.Camera.Box;

            for (var i = 1; i <= (box.Size.X/2)/ZoneSize.X+1; i++)
            {
                var index = CreateKey(key.Item1 - i, key.Item2);

                if (!m_zones.ContainsKey(index))
                {
                    m_zones.Add(index, new Zone(this, index));
                }
            }
        }

        public void AddZoneAtTop()
        {
            var key = GetKey(m_currentZoneIndex);
            var box = World.World.Instance.Camera.Box;

            for (var i = 1; i <= (box.Size.Y / 2) / ZoneSize.Y + 1; i++)
            {
                var index = CreateKey(key.Item1, key.Item2 + i);

                if (!m_zones.ContainsKey(index))
                {
                    m_zones.Add(index, new Zone(this, index));
                }
            }
        }

        public void AddZoneAtRight()
        {
            var key = GetKey(m_currentZoneIndex);
            var box = World.World.Instance.Camera.Box;

            for (var i = 1; i <= (box.Size.X / 2) / ZoneSize.X + 1; i++)
            {
                var index = CreateKey(key.Item1 + i, key.Item2);

                if (!m_zones.ContainsKey(index))
                {
                    m_zones.Add(index, new Zone(this, index));
                }
            }
        }

        public void AddZoneAtDown()
        {
            var key = GetKey(m_currentZoneIndex);
            var box = World.World.Instance.Camera.Box;

            for (var i = 1; i <= (box.Size.Y / 2) / ZoneSize.Y + 1; i++)
            {
                var index = CreateKey(key.Item1, key.Item2 - i);

                if (!m_zones.ContainsKey(index))
                {
                    m_zones.Add(index, new Zone(this, index));
                }
            }
        }

        public void AddZoneAtTopLeft()
        {
            var key = GetKey(m_currentZoneIndex);
            var box = World.World.Instance.Camera.Box;

            for (var i = 1; i <= (box.Size.X / 2) / ZoneSize.X + 1; i++)
            {
                for (var j = 1; j <= (box.Size.Y / 2) / ZoneSize.Y; j++)
                {
                    var index = CreateKey(key.Item1 - i, key.Item2 + j);

                    if (!m_zones.ContainsKey(index))
                    {
                        m_zones.Add(index, new Zone(this, index));
                    }
                }
            }
        }

        public void AddZoneAtTopRight()
        {
            var key = GetKey(m_currentZoneIndex);
            var box = World.World.Instance.Camera.Box;

            for (var i = 1; i <= (box.Size.X / 2) / ZoneSize.X + 1; i++)
            {
                for (var j = 1; j <= (box.Size.Y / 2) / ZoneSize.Y + 1; j++)
                {
                    var index = CreateKey(key.Item1 + i, key.Item2 + j);

                    if (!m_zones.ContainsKey(index))
                    {
                        m_zones.Add(index, new Zone(this, index));
                    }
                }
            }
        }

        public void AddZoneAtDownLeft()
        {
            var key = GetKey(m_currentZoneIndex);
            var box = World.World.Instance.Camera.Box;

            for (var i = 1; i <= (box.Size.X / 2) / ZoneSize.X + 1; i++)
            {
                for (var j = 1; j <= (box.Size.Y / 2) / ZoneSize.Y + 1; j++)
                {
                    var index = CreateKey(key.Item1 - i, key.Item2 - j);

                    if (!m_zones.ContainsKey(index))
                    {
                        m_zones.Add(index, new Zone(this, index));
                    }
                }
            }
        }

        public void AddZoneAtDownRight()
        {
            var key = GetKey(m_currentZoneIndex);
            var box = World.World.Instance.Camera.Box;

            for (var i = 1; i <= (box.Size.X / 2) / ZoneSize.X + 1; i++)
            {
                for (var j = 1; j <= (box.Size.Y / 2) / ZoneSize.Y + 1; j++)
                {
                    var index = CreateKey(key.Item1 + i, key.Item2 - j);

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

            var indexPlayer = CreateKey((int)Math.Floor(player.Location.Position.X / ZoneSize.X),
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
                var key = GetKey(m_currentZoneIndex);
                var positionCurrent = new Tuple<int, int>(key.Item1 * ZoneSize.X, key.Item2 * ZoneSize.Y);
                var box = World.World.Instance.Camera.Box;

                m_currentMinZoneIndex = CreateKey((int)(Math.Round(box.MinX / ZoneSize.X)), (int)(Math.Round(box.MinY / ZoneSize.Y)));
                m_currentMaxZoneIndex = CreateKey((int)(Math.Round(box.MaxX / ZoneSize.X)), (int)(Math.Round(box.MaxY / ZoneSize.Y)));
                var positionMin = GetKey(m_currentMinZoneIndex);
                var positionMax = GetKey(m_currentMaxZoneIndex);

                for (var row = positionMin.Item1-1; row <= positionMax.Item1+1; row++)
                {
                    for (var col = positionMin.Item2 - 1; col <= positionMax.Item2 + 1; col++)
                    {
                        var index = CreateKey(row, col);
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
                var positionMin = GetKey(m_currentMinZoneIndex);
                var positionMax = GetKey(m_currentMaxZoneIndex);

                for (var row = positionMin.Item1 - 1; row <= positionMax.Item1 + 1; row++)
                {
                    for (var col = positionMin.Item2 - 1; col <= positionMax.Item2 + 1; col++)
                    {
                        var index = CreateKey(row, col);
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
                var positionMin = GetKey(m_currentMinZoneIndex);
                var positionMax = GetKey(m_currentMaxZoneIndex);

                for (var row = positionMin.Item1 - 1; row <= positionMax.Item1 + 1; row++)
                {
                    for (var col = positionMin.Item2 - 1; col <= positionMax.Item2 + 1; col++)
                    {
                        var index = CreateKey(row, col);
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
