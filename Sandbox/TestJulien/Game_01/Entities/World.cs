using Granite.Collision;
using Granite.Core;
using Granite.Time;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestJulien.Game_01.Entities
{
    public sealed class World : Entity, IUpdatable, IRenderable
    {
        private readonly Camera m_camera;
        private readonly Player m_player;
        private readonly TriangleRenderer m_renderer;
        private readonly SegmentRenderer m_SRenderer;

        private List<Triangle> m_triangles;
        private List<Segment> m_walls;
        private List<Point> m_intersections;
        private List<Player> m_players;
        private Time m_time;
        private Random m_random;

        public Player Player { get { return m_player; } }
        public List<Player> Players { get { return m_players; } }
        public Camera Camera { get { return m_camera; } }
        public List<Point> Intersections { get { return m_intersections; } }

        private static World s_instance;
        public static World Instance {
            get
            {
                return s_instance;
            }
        }

        public World()
        {
            m_triangles = new List<Triangle>();
            m_walls = new List<Segment>();
            m_intersections = new List<Point>();
            m_renderer = new TriangleRenderer();
            m_SRenderer = new SegmentRenderer();
            m_players = new List<Player>();
             
            m_camera = new Camera();

            //Creation des joueurs
            m_player = new Player();

            m_camera.Bounds = new Box2(0, 0, 1000, 1000);
            m_camera.Target = m_player;

            Player.SetPosition(new Vector2(200, 200));

            m_random = new Random();

            //for (var i = 0; i < 20; i++)
            //{
            //    var x = m_random.Next(0, 500);
            //    var y = m_random.Next(0, 500);

            //    var p = new Player();
            //    p.SetPosition(new Vector2(x, y));
            //    m_players.Add(p);
            //}

            var p = new Player();
            p.SetPosition(new Vector2(400, 100));
            p.SetPositionNext(new Vector2(400, 400));
            m_players.Add(p);

            for (var i = 0; i < 10; i++)
            {
                var x = m_random.Next(0, 500);
                var y = m_random.Next(0, 500);
                var sx = m_random.Next(10, 50);
                var sy = m_random.Next(10, 50);

                m_walls.Add(new Segment()
                {
                    P1 = new Vector2(x, y),
                    P2 = new Vector2(x + sx, y),
                    Color = new Vector4(0.5f, 0.2f, 0, 1)
                });

                m_walls.Add(new Segment()
                {
                    P1 = new Vector2(x + sx, y),
                    P2 = new Vector2(x + sx, y + sy),
                    Color = new Vector4(0.5f, 0.2f, 0, 1)
                });

                m_walls.Add(new Segment()
                {
                    P1 = new Vector2(x + sx, y + sy),
                    P2 = new Vector2(x, y + sy),
                    Color = new Vector4(0.5f, 0.2f, 0, 1)
                });

                m_walls.Add(new Segment()
                {
                    P1 = new Vector2(x, y + sy),
                    P2 = new Vector2(x, y),
                    Color = new Vector4(0.5f, 0.2f, 0, 1)
                });
            }

            //m_walls.Add(new Segment()
            //{
            //    P1 = new Vector3(300, 300, 0),
            //    P2 = new Vector3(300, 400, 0),
            //    Color = new Vector4(0.5f, 0.2f, 0, 1)
            //});

            //m_walls.Add(new Segment()
            //{
            //    P1 = new Vector3(300, 400, 0),
            //    P2 = new Vector3(400, 400, 0),
            //    Color = new Vector4(0.5f, 0.2f, 0, 1)
            //});

            //m_walls.Add(new Segment()
            //{
            //    P1 = new Vector3(400, 400, 0),
            //    P2 = new Vector3(400, 300, 0),
            //    Color = new Vector4(0.5f, 0.2f, 0, 1)
            //});

            //m_walls.Add(new Segment()
            //{
            //    P1 = new Vector3(400, 300, 0),
            //    P2 = new Vector3(300, 300, 0),
            //    Color = new Vector4(0.5f, 0.2f, 0, 1)
            //});

            s_instance = this;

            //Triangles();

            m_time = Time.Instance;
            m_time.AddAction(new Granite.Time.Action(Update, 0.1));
            //m_time.AddAction(new Granite.Time.Action(UpdatePlayers, 2));
            m_time.Start();
        }

        private void Triangles()
        {
            m_triangles.Clear();
            m_renderer.Clear();
            m_SRenderer.Clear();
            //m_intersections.Clear();

            foreach (var s in m_player.GetSegments())
            {
                m_SRenderer.AddSegment(s);
            }

            foreach (var wall in m_walls)
            {
                m_SRenderer.AddSegment(wall);
                //m_player.CollisionTest(wall);

                //foreach (var player in m_players)
                //{
                //    player.CollisionTest(wall);
                //}
            }

            foreach (var player in m_players)
            {
                Player.CollisionTest2(player);
            }

            m_triangles.AddRange(m_player.ToTriangles());

            foreach (var player in m_players)
            {
                m_triangles.AddRange(player.ToTriangles());

                foreach (var s in player.GetSegments())
                {
                    m_SRenderer.AddSegment(s);
                }
            }

            foreach (var triangle in m_triangles)
            {
                m_renderer.AddTriangle(triangle);
            }

            //foreach (var inter in m_intersections)
            //{
            //    foreach (var triangle in inter.ToTriangles())
            //    {
            //        m_renderer.AddTriangle(triangle);
            //    }
            //}

        }


        public void Update(double interval)
        {
            Triangles();

            var size = Engine.Display.GetSize();
            m_camera.SetSize(new Vector2(size.X, size.Y));

            var elapsed = TimeSpan.FromSeconds(interval);
            m_player.Update(elapsed);
            m_camera.Update(elapsed);

            foreach (var player in m_players)
            {
                player.Update(elapsed);
            }
        }

        public void UpdatePlayers(double interval)
        {
            var elapsed = TimeSpan.FromMilliseconds(interval);
            foreach (var player in m_players)
            {
                player.SetPosition(player.LocationFinal.Position);

                var x = m_random.Next(-50, 50);
                var y = m_random.Next(-50, 50);
                player.SetPositionNext(new Vector2(player.Location.Position.X + x, player.Location.Position.Y + y));

                player.Update(elapsed);
            }
        }

        public void Update(TimeSpan elapsed)
        {
            //Triangles();

            //var size = Engine.Display.GetSize();
            //m_camera.SetSize(new Vector2(size.X, size.Y));

            //m_player.Update(elapsed);
            //m_playerDest.Update(elapsed);
            //m_camera.Update(elapsed);
        }

        public void Render(Matrix4 transform)
        {
            transform *= m_camera.CreateWorldToCameraTransform();

            

            m_renderer.Render(transform);
            m_SRenderer.Render(transform);
        }

    }
}
