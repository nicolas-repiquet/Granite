using Granite.Collision;
using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestJulien.Game_01.Entities
{
    public class Player : Entity, ILocated, IUpdatable, IRenderable
    {
        public Triangle[] Triangles { get; set; }
        public Segment[] Segments { get; set; }
        public List<Tuple<Vector2, int, double>> Intersections { get; set; }

        private readonly LocationComponent m_location;
        private readonly LocationComponent m_locationNext;
        private readonly LocationComponent m_locationFinal;

        public Box2 Location { get { return m_location.Location; } }
        public Box2 LocationNext { get { return m_locationNext.Location; } }
        public Box2 LocationFinal { get { return m_locationFinal.Location; } }


        public Player()
        {
            m_location = new LocationComponent(this);
            m_locationNext = new LocationComponent(this);
            m_locationFinal = new LocationComponent(this);
            Intersections = new List<Tuple<Vector2, int, double>>();
        }


        public void SetPosition(Vector2 position)
        {
            m_location.Location = new Box2(position, new Vector2(32, 32));
            m_locationNext.Location = new Box2(position, new Vector2(32, 32));
            m_locationFinal.Location = new Box2(position, new Vector2(32, 32));
        }

        public void SetPositionNext(Vector2 position)
        {
            m_locationNext.Location = new Box2(position, new Vector2(32, 32));
        }

        public void SetPositionFinal(Vector2 position)
        {
            m_locationFinal.Location = new Box2(position, new Vector2(32, 32));
        }

        public void Update(TimeSpan elapsed)
        {
            //On cerche l'intersection la plus proche
            if (Intersections.Count > 0)
            {
                var distMin = Intersections.Min(x => x.Item3);

                var inter = Intersections.First(x => x.Item3 == distMin);

                SetPositionFinal(new Vector2(
                        (Location.Position.X + inter.Item1.X),
                        (Location.Position.Y + inter.Item1.Y)));

                //if (inter.Item2 == 0)
                //{
                //    SetPositionFinal(new Vector2(
                //        (Location.Position.X + inter.Item1.X),
                //        (Location.Position.Y + inter.Item1.Y)));
                //}
                //else if (inter.Item2 == 1)
                //{
                //    SetPositionFinal(new Vector2(
                //        (Location.Position.X + inter.Item1.X) - LocationFinal.Size.X,
                //        (Location.Position.Y + inter.Item1.Y)));
                //}
                //else if (inter.Item2 == 2)
                //{
                //    SetPositionFinal(new Vector2(
                //        (Location.Position.X + inter.Item1.X) - LocationFinal.Size.X,
                //        (Location.Position.Y + inter.Item1.Y) - LocationFinal.Size.Y));
                //}
                //else if (inter.Item2 == 3)
                //{
                //    SetPositionFinal(new Vector2(
                //        (Location.Position.X + inter.Item1.X),
                //        (Location.Position.Y + inter.Item1.Y) - LocationFinal.Size.Y));
                //}

                Intersections.Clear();
            }
            else
            {
                SetPositionFinal(LocationNext.Position);
            }
        }

        public void Render(Matrix4 transform)
        {
            
        }

        public void CollisionTest(Segment test)
        {

                GetSegments();

            
            if(LocationNext != Location)
            {
                for (var i = 0; i < Segments.Length; i++)
                {
                    Segment s1 = Segments[i];

                    //Collisions
                    var inter = Collision.IntersectSegmentSegment(
                        new Vector2(test.P1.X, test.P1.Y),
                        new Vector2(test.P2.X, test.P2.Y),
                        new Vector2(s1.P1.X, s1.P1.Y),
                        new Vector2(s1.P2.X, s1.P2.Y)
                        );

                    if (inter != null)
                    {
                        var dist = Distance(s1.P1, new Vector3(s1.P1.X + inter.Value.X, s1.P1.Y + inter.Value.Y, 0));
                        Intersections.Add(new Tuple<Vector2, int, double>(inter.Value, i, dist));
                    }
                }
            }
        }

        public double Distance(Vector3 p1, Vector3 p2)
        {
            var v = new Vector3(p2.X - p1.X, p2.Y - p1.Y, 0);
            return Math.Sqrt(Math.Pow(v.X, 2) + Math.Pow(v.Y, 2));
        }

        public Segment[] GetSegments()
        {
            var b1 = Location;
            var b2 = LocationNext;

            //Les 4 coins
            var s1 = new Segment(
                new Vector3(b1.MinX, b1.MinY, 0),
                new Vector3(b2.MinX, b2.MinY, 0),
                new Vector4(1, 0, 0, 1));

            var s2 = new Segment(
                new Vector3(b1.MaxX, b1.MinY, 0),
                new Vector3(b2.MaxX, b2.MinY, 0),
                new Vector4(1, 0, 0, 1));

            var s3 = new Segment(
                new Vector3(b1.MaxX, b1.MaxY, 0),
                new Vector3(b2.MaxX, b2.MaxY, 0),
                new Vector4(1, 0, 0, 1));

            var s4 = new Segment(
                new Vector3(b1.MinX, b1.MaxY, 0),
                new Vector3(b2.MinX, b2.MaxY, 0),
                new Vector4(1, 0, 0, 1));

            //Le milieux
            var s5 = new Segment(
               new Vector3(b1.MinX + b1.Size.X / 2, b1.MinY, 0),
               new Vector3(b2.MinX + b2.Size.X / 2, b2.MinY, 0),
               new Vector4(1, 0, 0, 1));

            var s6 = new Segment(
                new Vector3(b1.MaxX, b1.MinY + b1.Size.Y / 2, 0),
                new Vector3(b2.MaxX, b2.MinY + b2.Size.Y / 2, 0),
                new Vector4(1, 0, 0, 1));

            var s7 = new Segment(
                new Vector3(b1.MinX, b1.MinY + b1.Size.Y / 2, 0),
                new Vector3(b2.MinX, b2.MinY + b2.Size.Y / 2, 0),
                new Vector4(1, 0, 0, 1));

            var s8 = new Segment(
                new Vector3(b1.MinX + b1.Size.X / 2, b1.MaxY, 0),
                new Vector3(b2.MinX + b1.Size.X / 2, b2.MaxY, 0),
                new Vector4(1, 0, 0, 1));

            Segments = new Segment[]{
                s1, s2, s3, s4, s5, s6, s7, s8
            };

            return Segments;
        }

        public Triangle[] ToTriangles()
        {
            Triangles = new Triangle[6];

            var color = new Vector4(0, 1, 0, 1);

            //position
            Triangles[0] = new Triangle()
            {
                P1 = new Vector3(Location.MinX, Location.MinY, 0),
                P2 = new Vector3(Location.MaxX, Location.MinY, 0),
                P3 = new Vector3(Location.MaxX, Location.MaxY, 0),
                Color = color
            };

            Triangles[1] = new Triangle()
            {
                P1 = new Vector3(Location.MinX, Location.MinY, 0),
                P2 = new Vector3(Location.MaxX, Location.MaxY, 0),
                P3 = new Vector3(Location.MinX, Location.MaxY, 0),
                Color = color
            };

            color = new Vector4(1, 1, 0, 1);

            //Predicted
            Triangles[2] = new Triangle()
            {
                P1 = new Vector3(LocationNext.MinX, LocationNext.MinY, 0),
                P2 = new Vector3(LocationNext.MaxX, LocationNext.MinY, 0),
                P3 = new Vector3(LocationNext.MaxX, LocationNext.MaxY, 0),
                Color = color
            };

            Triangles[3] = new Triangle()
            {
                P1 = new Vector3(LocationNext.MinX, LocationNext.MinY, 0),
                P2 = new Vector3(LocationNext.MaxX, LocationNext.MaxY, 0),
                P3 = new Vector3(LocationNext.MinX, LocationNext.MaxY, 0),
                Color = color
            };

            color = new Vector4(1, 0.5f, 0, 1);

            //Final
            Triangles[4] = new Triangle()
            {
                P1 = new Vector3(LocationFinal.MinX, LocationFinal.MinY, 0),
                P2 = new Vector3(LocationFinal.MaxX, LocationFinal.MinY, 0),
                P3 = new Vector3(LocationFinal.MaxX, LocationFinal.MaxY, 0),
                Color = color
            };

            Triangles[5] = new Triangle()
            {
                P1 = new Vector3(LocationFinal.MinX, LocationFinal.MinY, 0),
                P2 = new Vector3(LocationFinal.MaxX, LocationFinal.MaxY, 0),
                P3 = new Vector3(LocationFinal.MinX, LocationFinal.MaxY, 0),
                Color = color
            };

            return Triangles;
        }
    }
}
