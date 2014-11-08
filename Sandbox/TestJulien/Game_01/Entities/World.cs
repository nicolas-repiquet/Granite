using Granite.Collision;
using Granite.Core;
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
        private readonly PlayerFinal m_playerFinal;
        private readonly PlayerDestination m_playerDest;
        private readonly TriangleRenderer m_renderer;
        private readonly SegmentRenderer m_SRenderer;

        private List<Triangle> m_triangles;
        private List<Segment> m_walls;
        private List<Point> m_intersections;

        public Player Player { get { return m_player; } }
        public PlayerDestination PlayerDestination { get { return m_playerDest; } }
        public PlayerFinal PlayerFinal { get { return m_playerFinal; } }
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

            m_camera = new Camera();

            //Creation des joueurs
            m_player = new Player();
            m_playerDest = new PlayerDestination();
            m_playerFinal = new PlayerFinal();

            m_camera.Bounds = new Box2(0, 0, 1000, 1000);
            m_camera.Target = m_player;

            Player.SetPosition(new Vector2(200, 200));
            PlayerDestination.SetPosition(new Vector2(200, 200));
            PlayerFinal.SetPosition(new Vector2(200, 200));

            var random = new Random();

            for (var i = 0; i < 10; i++)
            {
                var t = random.NextDouble();

                if (t < 0.5)
                {
                    var p1X = random.Next(0, 1000);
                    var p1Y = random.Next(0, 1000);
                    var p2X = random.Next(0, 1000);
                    var p2Y = p1Y;

                    m_walls.Add(new Segment()
                    {
                        P1 = new Vector3(p1X, p1Y, 0),
                        P2 = new Vector3(p2X, p2Y, 0),
                        Color = new Vector4(0.5f, 0.2f, 0, 1)
                    });
                }
                else
                {
                    var p1X = random.Next(0, 1000);
                    var p1Y = random.Next(0, 1000);
                    var p2X = p1X;
                    var p2Y = random.Next(0, 1000);

                    m_walls.Add(new Segment()
                    {
                        P1 = new Vector3(p1X, p1Y, 0),
                        P2 = new Vector3(p2X, p2Y, 0),
                        Color = new Vector4(0.5f, 0.2f, 0, 1)
                    });
                }
            }

           

            s_instance = this;
        }

        private void Triangles()
        {
            m_triangles.Clear();

            //Ajout triangle joueurs
            m_triangles.AddRange(m_player.ToTriangles());
            m_triangles.AddRange(m_playerDest.ToTriangles());

            //Creation des segments entre les joueurs
            var b1 = m_player.Location;
            var b2 = m_playerDest.Location;

            var s1 = new Segment(
                new Vector3(b1.MinX, b1.MinY, 0),
                new Vector3(b2.MinX, b2.MinY, 0), 
                new Vector4(1, 0, 0, 1));

            var s2 = new Segment(
                new Vector3(b1.MinX, b1.MaxY, 0),
                new Vector3(b2.MinX, b2.MaxY, 0),
                new Vector4(1, 0, 0, 1));

            var s3 = new Segment(
                new Vector3(b1.MaxX, b1.MinY, 0),
                new Vector3(b2.MaxX, b2.MinY, 0),
                new Vector4(1, 0, 0, 1));

            var s4 = new Segment(
                new Vector3(b1.MaxX, b1.MaxY, 0),
                new Vector3(b2.MaxX, b2.MaxY, 0),
                new Vector4(1, 0, 0, 1));

           


            m_renderer.Clear();
            m_SRenderer.Clear();
            m_intersections.Clear();

            m_SRenderer.AddSegment(s1);
            m_SRenderer.AddSegment(s2);
            m_SRenderer.AddSegment(s3);
            m_SRenderer.AddSegment(s4);

            Tuple<double, int, Point> intersectMin = null;

            foreach (var wall in m_walls)
            {
                m_SRenderer.AddSegment(wall);

                //Collisions
                var inter = Collision.IntersectSegmentSegment(
                    new Vector2(wall.P1.X, wall.P1.Y), 
                    new Vector2(wall.P2.X, wall.P2.Y),
                    new Vector2(s1.P1.X, s1.P1.Y), 
                    new Vector2(s1.P2.X, s1.P2.Y)
                    );

                if (inter != null)
                {
                    var p = new Point(new Vector3(inter.Value.X, inter.Value.Y, 0), 10);

                    m_intersections.Add(p);

                    var dist = Distance(s1.P1, new Vector3(p.Center.X, p.Center.Y, 0));
                    if (intersectMin == null || dist < intersectMin.Item1)
                    {
                        intersectMin = new Tuple<double, int, Point>(dist, 0, p);
                    }
                }

                inter = Collision.IntersectSegmentSegment(
                    new Vector2(wall.P1.X, wall.P1.Y),
                    new Vector2(wall.P2.X, wall.P2.Y),
                    new Vector2(s2.P1.X, s2.P1.Y),
                    new Vector2(s2.P2.X, s2.P2.Y));
                    

                if (inter != null)
                {
                    var p = new Point(new Vector3(inter.Value.X, inter.Value.Y, 0), 10);

                    m_intersections.Add(p);

                    var dist = Distance(s2.P1, new Vector3(p.Center.X, p.Center.Y, 0));
                    if (intersectMin == null || dist < intersectMin.Item1)
                    {
                        intersectMin = new Tuple<double, int, Point>(dist, 3, p);
                    }
                }

                inter = Collision.IntersectSegmentSegment(
                    new Vector2(wall.P1.X, wall.P1.Y),
                    new Vector2(wall.P2.X, wall.P2.Y),
                    new Vector2(s3.P1.X, s3.P1.Y),
                    new Vector2(s3.P2.X, s3.P2.Y));

                if (inter != null)
                {
                    var p = new Point(new Vector3(inter.Value.X, inter.Value.Y, 0), 10);

                    m_intersections.Add(p);

                    var dist = Distance(s3.P1, new Vector3(p.Center.X, p.Center.Y, 0));
                    if (intersectMin == null || dist < intersectMin.Item1)
                    {
                        intersectMin = new Tuple<double, int, Point>(dist, 1, p);
                    }
                }

                inter = Collision.IntersectSegmentSegment(
                    new Vector2(wall.P1.X, wall.P1.Y),
                    new Vector2(wall.P2.X, wall.P2.Y),
                    new Vector2(s4.P1.X, s4.P1.Y),
                    new Vector2(s4.P2.X, s4.P2.Y)
                    );

                if (inter != null)
                {
                    var p = new Point(new Vector3(inter.Value.X, inter.Value.Y, 0), 10);

                    m_intersections.Add(p);

                    var dist = Distance(s4.P1, new Vector3(p.Center.X, p.Center.Y, 0));
                    if (intersectMin == null || dist < intersectMin.Item1)
                    {
                        intersectMin = new Tuple<double, int, Point>(dist, 2, p);
                    }
                }
            }

            

            if (intersectMin != null)
            {
                if (intersectMin.Item2 == 0)
                {
                    m_playerFinal.SetPosition(new Vector2(
                        intersectMin.Item3.Center.X,
                        intersectMin.Item3.Center.Y));
                }
                else if (intersectMin.Item2 == 1)
                {
                    m_playerFinal.SetPosition(new Vector2(
                        intersectMin.Item3.Center.X - m_playerFinal.Location.Size.X,
                        intersectMin.Item3.Center.Y));
                }
                else if (intersectMin.Item2 == 2)
                {
                    m_playerFinal.SetPosition(new Vector2(
                        intersectMin.Item3.Center.X - m_playerFinal.Location.Size.X,
                        intersectMin.Item3.Center.Y - m_playerFinal.Location.Size.Y));
                }
                else if (intersectMin.Item2 == 3)
                {
                    m_playerFinal.SetPosition(new Vector2(
                        intersectMin.Item3.Center.X,
                        intersectMin.Item3.Center.Y - m_playerFinal.Location.Size.Y));
                }

                m_triangles.AddRange(m_playerFinal.ToTriangles());
            }

            foreach (var triangle in m_triangles)
            {
                m_renderer.AddTriangle(triangle);
            }

            foreach (var inter in m_intersections)
            {
                foreach (var triangle in inter.ToTriangles())
                {
                    m_renderer.AddTriangle(triangle);
                }
            }

        }

        public double Distance(Vector3 p1, Vector3 p2)
        {
            var v = new Vector3(p2.X-p1.X, p2.Y-p1.Y, 0);
            return Math.Sqrt(Math.Pow(v.X, 2) + Math.Pow(v.Y, 2));
        }

        public void Update(TimeSpan elapsed)
        {
            var size = Engine.Display.GetSize();
            m_camera.SetSize(new Vector2(size.X, size.Y));

            m_player.Update(elapsed);
            m_playerDest.Update(elapsed);
            m_camera.Update(elapsed);
        }

        public void Render(Matrix4 transform)
        {
            transform *= m_camera.CreateWorldToCameraTransform();

            Triangles();

            m_renderer.Render(transform);
            m_SRenderer.Render(transform);
        }

    }
}
