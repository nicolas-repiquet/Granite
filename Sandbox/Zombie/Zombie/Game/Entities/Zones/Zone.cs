using Granite.Core;
using Granite.Particle;
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
        public FireCamp FireCamp { get; set; }
        //public ParticleEngine ParticleEngine { get; set; }

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
            //for (var i = 0; i < 1; i++)
            //{
            //    var x = m_map.Random.Next(0, m_map.ZoneSize.X);
            //    var y = m_map.Random.Next(0, m_map.ZoneSize.Y);

            //    var width = m_map.Random.Next(10, 100);
            //    var height = m_map.Random.Next(10, 100);
                 
            //    //var x = m_map.ZoneSize.X / 2 + 50;
            //    //var y = m_map.ZoneSize.Y / 2 + 50;

            //    //var width = 50;
            //    //var height = 50;

            //    var p1 = new Vector2(x, y);
            //    var p2 = new Vector2(x + width, y);
            //    var p3 = new Vector2(x + width, y + height);
            //    var p4 = new Vector2(x, y + height);

            //    Walls.Add(
            //        new Wall(
            //            new List<Segment>()
            //            {
            //                new Segment(p1, p2),
            //                new Segment(p2, p3),
            //                new Segment(p3, p4),
            //                new Segment(p4, p1)
            //            }
            //        )
            //    );
            //}

            //Trees
            for (var i = 0; i < 3; i++)
            {
                var x = m_map.Random.Next(0+50, m_map.ZoneSize.X-50);
                var y = m_map.Random.Next(0+50, m_map.ZoneSize.Y-50);

                var t1 = new Tree1();
                t1.SetPosition(new Vector2(x, y));
                AddTree(t1);

                y -= (int)(t1.Box.Y / 3f);

                var p1 = new Vector2(x - t1.Box.X / 6, y);
                var p2 = new Vector2(x + t1.Box.X / 6, y);
                var p3 = new Vector2(x, y - t1.Box.Y / 6);
                var p4 = new Vector2(x, y + t1.Box.Y / 6);

                Walls.Add(
                    new Wall(
                        new List<Segment>()
                        {
                            new Segment(p1, p2),
                            new Segment(p3, p4)
                        }
                    )
                );

                x = m_map.Random.Next(0 + 50, m_map.ZoneSize.X - 50);
                y = m_map.Random.Next(0 + 50, m_map.ZoneSize.Y - 50);

                var t2 = new Tree2();
                t2.SetPosition(new Vector2(x, y));
                AddTree(t2);

                y -= (int)(t2.Box.Y / 3f);

                p1 = new Vector2(x - t2.Box.X / 6, y);
                p2 = new Vector2(x + t2.Box.X / 6, y);
                p3 = new Vector2(x, y - t2.Box.Y / 6);
                p4 = new Vector2(x, y + t2.Box.Y / 6);

                Walls.Add(
                    new Wall(
                        new List<Segment>()
                        {
                            new Segment(p1, p2),
                            new Segment(p3, p4)
                        }
                    )
                );

                x = m_map.Random.Next(0 + 50, m_map.ZoneSize.X - 50);
                y = m_map.Random.Next(0 + 50, m_map.ZoneSize.Y - 50);

                var t3 = new Tree3();
                t3.SetPosition(new Vector2(x, y));
                AddTree(t3);

                y -= (int)(t3.Box.Y / 4f);

                p1 = new Vector2(x - t3.Box.X/4, y);
                p2 = new Vector2(x + t3.Box.X / 4, y);
                p3 = new Vector2(x, y - t3.Box.Y / 4);
                p4 = new Vector2(x, y + t3.Box.Y / 4);

                Walls.Add(
                    new Wall(
                        new List<Segment>()
                        {
                            new Segment(p1, p2),
                            new Segment(p3, p4)
                        }
                    )
                );
            }

            //Fire
            //var peX = m_map.Random.Next((int)(m_map.ZoneSize.X * 0.1f), (int)(m_map.ZoneSize.X * 0.9f));
            //var peY = m_map.Random.Next((int)(m_map.ZoneSize.Y * 0.1f), (int)(m_map.ZoneSize.Y * 0.9f));
            //ParticleEngine = new ParticleEngine(new List<Texture2D>(),
            //    new Vector2(peX, peY),
            //    new Vector2(0, 20),
            //    150,
            //    0.2f);

            var peX = m_map.Random.Next((int)(m_map.ZoneSize.X * 0.1f), (int)(m_map.ZoneSize.X * 0.9f));
            var peY = m_map.Random.Next((int)(m_map.ZoneSize.Y * 0.1f), (int)(m_map.ZoneSize.Y * 0.9f));
            var firePosition = new Vector2(peX, peY);
            FireCamp = new FireCamp();
            FireCamp.SetPosition(firePosition);

            //Lights
            for (var i = 0; i < 1; i++)
            {
                //var x = m_map.Random.Next(0, m_map.ZoneSize.X);
                //var y = m_map.Random.Next(0, m_map.ZoneSize.Y);
                //var x = m_map.ZoneSize.X / 2;
                //var y = m_map.ZoneSize.Y / 2;

                var radius = 200 + m_map.Random.Next(0, 10);

                Lights.Add(
                    new Light(
                        new Vector2(firePosition.X, firePosition.Y - FireCamp.Box.Y/4),
                        radius,
                        new Color4ub(255, 255, 255, 255),
                        new Color4ub(0, 0, 0, 255))
                );
            }

            var segments = Walls.SelectMany(x => x.Walls).ToList();

            Parallel.ForEach(segments, segment =>
                {
                    foreach (var light in Lights)
                    {
                        light.Cone.Add(segment.P1, segment.P2);
                    }
                    //m_wallRenderer.AddSegment(segment);
                });

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
            //Parallel.ForEach(Trees, x => 
            //    {
            //        x.Update(elapsed);
            //    });

            //ParticleEngine.Update(elapsed);

            //var particles = ParticleEngine.Particles;

            //Lights
            //Lights.Clear();
            //m_lightRenderer.Clear();

            //foreach (var particle in particles.Where(x => x.TTL > x.TTLMax/2))
            //{
            //    var radius = 70 + m_map.Random.Next(0, 5);

            //    Lights.Add(
            //        new Light(
            //            particle.Position,
            //            radius,
            //            new Color4ub(255, 255, 200, 255),
            //            new Color4ub(0, 0, 0, 255))
            //    );
            //}

            //var radius = 300 + m_map.Random.Next(0, 2);
            //var position = new Vector2(ParticleEngine.EmitterLocation.X + m_map.Random.Next(-1, 1), 
            //    ParticleEngine.EmitterLocation.Y + m_map.Random.Next(-1, 1));

            //Lights.Add(
            //    new Light(
            //        position,
            //        radius,
            //        new Color4ub(255, 255, 200, 255),
            //        new Color4ub(0, 0, 0, 255))
            //);

            //var segments = Walls.SelectMany(x => x.Walls).ToList();

            //Parallel.ForEach(segments, segment =>
            //    {
            //        foreach (var light in Lights)
            //        {
            //            light.Cone.Add(segment.P1, segment.P2);
            //        }
            //        //m_wallRenderer.AddSegment(segment);
            //    });

            //foreach (var light in Lights)
            //{
            //    var points = light.Cone.GetPath();
            //    foreach (var point in points)
            //    {
            //        m_lightRenderer.AddVertex(point.Point, point.Color);
            //    }
            //}

            FireCamp.Update(elapsed);

            //On modifie l'intensité des lumières en fonction de la distance avec le player
            //m_lightRenderer.Clear();

            //var size = Engine.Display.GetSize();
            //var screenSize = Math.Max(size.X, size.Y)/2;
            //var player = World.World.Instance.Player;

            //foreach (var light in Lights)
            //{
            //    //pour chaque lumiere on calcul la distance avec le joueur
            //    var vecteur = light.Position - player.Location.Position;
            //    var distance = Math.Sqrt(Math.Pow(vecteur.X, 2) + Math.Pow(vecteur.Y, 2));
            //    var percent = (1f - (distance/screenSize)) * 255;
            //    if(percent < 0)
            //    {
            //        percent = 0;
            //    }

            //    light.Cone.StartColor = Color4ub.Mix(new Color4ub(255, 255, 255, 255), new Color4ub(0, 0, 0, 255), (float)(1-percent));

            //    var points = light.Cone.GetPath();
            //    foreach (var point in points)
            //    {
            //        m_lightRenderer.AddVertex(point.Point, point.Color);
            //    }
            //}
        }

        public void Render(Matrix4 transform)
        {
            transform *= Matrix4.Translate(m_map.ZoneSize.X * m_id.X, m_map.ZoneSize.Y * m_id.Y, 0);

            Floor.Render(transform);

            GL.Enable(GL.DEPTH_TEST);

            //m_wallRenderer.Render(transform);
            m_treeRenderer.Render(transform);

            //GL.BlendFunc(GL.SRC_ALPHA, GL.ONE);
            //GL.BlendEquation(GL.FUNC_ADD);

            //ParticleEngine.Draw(transform);
            FireCamp.Render(transform);

            GL.Disable(GL.DEPTH_TEST);

            GL.BlendFunc(GL.SRC_ALPHA, GL.ONE_MINUS_SRC_ALPHA);

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
