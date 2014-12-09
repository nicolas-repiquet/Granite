using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zombie.Game.Entities.Tools
{
    public class Cone : ICloneable
    {
        private struct Slot
        {
            public float Radius;
            public int Segment;
        }

        public struct PointRadius
        {
            public Color4ub Color;
            public Vector3 Point;
        }

        private const int SLOTS = 512;
        private const int INITIAL_SEGMENTS = 256;
        private const int SLOTS_PER_SEGMENT = SLOTS / INITIAL_SEGMENTS;
        private const double PI_2 = Math.PI * 2;
        private const double SLOT_ANGLE = (PI_2) / SLOTS;
        private const double HALF_SLOT_ANGLE = SLOT_ANGLE / 2;

        private static Vector2[] s_rays;
        private readonly Slot[] m_slots;
        private int m_segment = 0;

        public Vector2 Center { get; set; }
        public float Radius { get; set; }
        public float Angle { get; set; }
        public float StartAngle { get; set; }
        public Color4ub StartColor { get; set; }
        public Color4ub EndColor { get; set; }
        public Triangle[] Triangles { get; set; }

        static Cone()
        {
            s_rays = new Vector2[SLOTS];

            for (int i = 0; i < SLOTS; i++)
            {
                var t = i * SLOT_ANGLE + HALF_SLOT_ANGLE;
                s_rays[i] = new Vector2((float)Math.Cos(t), (float)Math.Sin(t));
            }
        }

        public Cone()
        {

        }

        public Cone(Vector2 p, float radius, float angle, float startAngle = 0)
        {
            Center = p;
            Radius = radius;
            Angle = angle;
            StartAngle = startAngle;
            StartColor = new Color4ub(0, 0, 255, 255);
            EndColor = new Color4ub(0, 0, 255, 255);

            m_slots = new Slot[SLOTS];
            Clear();
        }

        public Cone(Vector2 p, float radius, float angle, Color4ub startColor, Color4ub endColor, float startAngle = 0)
        {
            Center = p;
            Radius = radius;
            Angle = angle;
            StartAngle = startAngle;
            StartColor = startColor;
            EndColor = endColor;

            m_slots = new Slot[SLOTS];
            Clear();
        }

        public void Clear()
        {
            for (int i = 0; i < SLOTS; i++)
            {
                m_slots[i] = new Slot
                {
                    Radius = Radius,
                    Segment = i / SLOTS_PER_SEGMENT
                };
            }
            m_segment = INITIAL_SEGMENTS;
        }

        public void Add(Vector2 from, Vector2 to)
        {
            var x1 = from.X - Center.X;
            var x2 = to.X - Center.X;
            var y1 = from.Y - Center.Y;
            var y2 = to.Y - Center.Y;

            var t1 = Math.Atan2(y1, x1) + PI_2;
            var t2 = Math.Atan2(y2, x2) + PI_2;
            var diff = t2 - t1;

            if (diff == 0)
            {
                return;
            }
            else if (diff > Math.PI)
            {
                var tmp = t1;
                t1 = t2;
                t2 = tmp;

                t2 += PI_2;
            }
            else if (diff < -Math.PI)
            {
                t2 += PI_2;
            }
            else if (diff < 0)
            {
                var tmp = t1;
                t1 = t2;
                t2 = tmp;
            }

            var a = y1 - y2;
            var b = x2 - x1;
            var c = a * x1 + b * y1;

            var i0 = (int)Math.Floor(t1 / SLOT_ANGLE);
            var i1 = (int)Math.Ceiling(t2 / SLOT_ANGLE);

            for (int i = i0; i < i1; i++)
            {
                var index = i % SLOTS;

                var ray = s_rays[index];

                var det = ray.X * a + ray.Y * b;

                var x = (ray.X * c) / det;
                var y = (ray.Y * c) / det;

                var radius = (float)Math.Sqrt(x * x + y * y);

                if (radius < m_slots[index].Radius)
                {
                    m_slots[index] = new Slot
                    {
                        Radius = radius,
                        Segment = m_segment
                    };
                }
            }

            m_segment++;
        }

        public IEnumerable<PointRadius> GetPath()
        {
            var points = new List<PointRadius>();

            points.Add(new PointRadius()
            {
                Point = new Vector3(Center.X, Center.Y, 0),
                Color = StartColor
            });

            var i0 = 0;
            var i1 = SLOTS;

            if (Angle < PI_2)
            {
                i0 = (int)(Math.Floor(((StartAngle + PI_2) % PI_2) / SLOT_ANGLE));
                i1 = (int)(Math.Ceiling(((StartAngle + Angle + PI_2) % PI_2) / SLOT_ANGLE));
            }
            
                
            for (int i = i0; i < i1; i++)
            {
                var prev = (SLOTS + i - 1) % SLOTS;

                if (m_slots[i].Segment != m_slots[prev].Segment)
                {
                    Vector3 p0;
                    Vector3 p1;

                    {
                        var ray = s_rays[i];
                        var slot = m_slots[prev];
                        var x = ray.X * slot.Radius + Center.X;
                        var y = ray.Y * slot.Radius + Center.Y;

                        p0 = new Vector3(x, y, 0);
                    }

                    {
                        var ray = s_rays[i];
                        var slot = m_slots[i];
                        var x = ray.X * slot.Radius + Center.X;
                        var y = ray.Y * slot.Radius + Center.Y;

                        p1 = new Vector3(x, y, 0);
                    }

                    if (p0 != p1)
                    {
                        points.Add(new PointRadius()
                        {
                            Point = p0,
                            Color = Color4ub.Mix(StartColor, EndColor, (m_slots[prev].Radius / Radius))
                        });
                        points.Add(new PointRadius()
                        {
                            Point = p1,
                            Color = Color4ub.Mix(StartColor, EndColor, (m_slots[i].Radius / Radius))
                        });
                    }
                    else
                    {
                        points.Add(new PointRadius()
                        {
                            Point = p0,
                            Color = Color4ub.Mix(StartColor, EndColor, (m_slots[prev].Radius / Radius))
                        });
                    }
                }
            }

            if (Angle >= PI_2)
            {
                points.Add(points[1]);
            }

            return points;
        }

        public IEnumerable<PointRadius> GetPathBetweenIndex(int i0, int i1)
        {
            var points = new List<PointRadius>();

            points.Add(new PointRadius()
            {
                Point = new Vector3(Center.X, Center.Y, 0),
                Color = StartColor
            });

            for (int i = i0+1; i < i1; i++)
            {
                var prev = (SLOTS + i - 1) % SLOTS;

                Vector3 p0;
                Vector3 p1;

                {
                    var ray = s_rays[i];
                    var slot = m_slots[prev];
                    var x = ray.X * slot.Radius + Center.X;
                    var y = ray.Y * slot.Radius + Center.Y;

                    p0 = new Vector3(x, y, 0);
                }

                {
                    var ray = s_rays[i];
                    var slot = m_slots[i];
                    var x = ray.X * slot.Radius + Center.X;
                    var y = ray.Y * slot.Radius + Center.Y;

                    p1 = new Vector3(x, y, 0);
                }

                if (p0 != p1)
                {
                    points.Add(new PointRadius()
                    {
                        Point = p0,
                        Color = Color4ub.Mix(StartColor, EndColor, (m_slots[prev].Radius / Radius))
                    });
                    points.Add(new PointRadius()
                    {
                        Point = p1,
                        Color = Color4ub.Mix(StartColor, EndColor, (m_slots[i].Radius / Radius))
                    });
                }
                else
                {
                    points.Add(new PointRadius()
                    {
                        Point = p0,
                        Color = Color4ub.Mix(StartColor, EndColor, (m_slots[prev].Radius / Radius))
                    });
                }
            }

            return points;
        }

        //public Triangle[] ToTriangles()
        //{
        //    var center = new Vector3(Center.X, Center.Y, 0);

        //    Triangle[] triangles = null;

        //    if (Angle >= PI_2)
        //    {
        //        var points = GetPath().ToArray();
        //        triangles = new Triangle[points.Length];

        //        for (var i = 0; i < triangles.Length; i++)
        //        {
        //            if (i == triangles.Length - 1)
        //            {
        //                var t = new Triangle()
        //                {
        //                    P1 = center,
        //                    P2 = points[i].Point,
        //                    P3 = points[0].Point,
        //                    ColorP1 = StartColor,
        //                    ColorP2 = Color4ub.Mix(StartColor, EndColor, (points[i].Radius / Radius)),
        //                    ColorP3 = Color4ub.Mix(StartColor, EndColor, (points[0].Radius / Radius))
        //                };

        //                triangles[i] = t;
        //            }
        //            else if (i != triangles.Length - 1)
        //            {
        //                var t = new Triangle()
        //                {
        //                    P1 = center,
        //                    P2 = points[i].Point,
        //                    P3 = points[i + 1].Point,
        //                    ColorP1 = StartColor,
        //                    ColorP2 = Color4ub.Mix(StartColor, EndColor, (points[i].Radius / Radius)),
        //                    ColorP3 = Color4ub.Mix(StartColor, EndColor, (points[i + 1].Radius / Radius))
        //                };

        //                triangles[i] = t;
        //            }

        //        }
        //    }
        //    else
        //    {
        //        //On cherche les index de début et de fin de l'angle
        //        var i0 = (int)((Math.Floor(StartAngle / SLOT_ANGLE) + PI_2) % PI_2);
        //        var i1 = (int)((Math.Ceiling((StartAngle + Angle) / SLOT_ANGLE) + PI_2) % PI_2);

        //        var points = GetPathBetweenIndex(i0, i1).ToArray();

        //        if (points.Length > 0)
        //        {
        //            triangles = new Triangle[points.Length - 1];

        //            //=========================================
        //            for (var i = 0; i < triangles.Length; i++)
        //            {
        //                var t = new Triangle()
        //                {
        //                    P1 = center,
        //                    P2 = points[i].Point,
        //                    P3 = points[i + 1].Point,
        //                    ColorP1 = StartColor,
        //                    ColorP2 = Color4ub.Mix(StartColor, EndColor, (points[i].Radius / Radius)),
        //                    ColorP3 = Color4ub.Mix(StartColor, EndColor, (points[i + 1].Radius / Radius))
        //                };

        //                triangles[i] = t;
        //            }
        //        }
        //        else
        //        {
        //            triangles = new Triangle[0];
        //        }
        //    }

        //    Triangles = triangles;

        //    return Triangles;
        //}

        public bool Collision(Vector2 point, float r = 5)
        {
            var x1 = point.X - Center.X;
            var y1 = point.Y - Center.Y;

            //Calcul de la normal de l'origin du tir jusqu'au point
            var normal = new Vector2(-y1, x1).Normalize() * r;

            var point1 = new Vector2(point.X + normal.X, point.Y + normal.Y);
            var point2 = new Vector2(point.X - normal.X, point.Y - normal.Y);

            var t0 = Math.Atan2(point.Y - Center.Y, point.X - Center.X) + PI_2;
            var t1 = Math.Atan2(point1.Y - Center.Y, point1.X - Center.X) + PI_2;
            var t2 = Math.Atan2(point2.Y - Center.Y, point2.X - Center.X) + PI_2;

            var start = (double)StartAngle + PI_2;

            if (t0 - t1 > Math.PI)
            {
                t0 -= PI_2;
            }

            if (t2 - t1 > Math.PI)
            {
                t2 -= PI_2;
                start = start < PI_2 ? start : start - PI_2;
            }

            if (t1 > t2)
            {
                var temp = t2;
                t2 = t1;
                t1 = temp;

                var tempPoint = point2;
                point2 = point1;
                point1 = tempPoint;
            }



            //Cible entierement inclut dans l'angle du tir
            if (t1 >= start && t1 < start + Angle
                && t2 >= start && t2 < start + Angle)
            {
                var vecteurDirecteur = new Vector2(x1, y1);
                var radius = (float)Math.Sqrt(vecteurDirecteur.X * vecteurDirecteur.X + vecteurDirecteur.Y * vecteurDirecteur.Y);

                if (radius <= Radius)
                {
                    //Console.WriteLine("Cible entierement inclut dans l'angle du tir");

                    return true;
                }
            }
            //Tir entierement inclut dans l'angle de la cible
            else if (start >= t1 && start + Angle < t2)
            {
                var vecteurDirecteur = new Vector2(x1, y1);
                var radius = (float)Math.Sqrt(vecteurDirecteur.X * vecteurDirecteur.X + vecteurDirecteur.Y * vecteurDirecteur.Y);

                if (radius <= Radius)
                {
                    //Console.WriteLine(string.Format("Tir entierement inclut dans l'angle de la cible : t1={0} < start={1} < s+a={2} < t2={3}", t1, start, start + Angle, t2));

                    return true;
                }
            }
            //Cible partiellement inclut dans l'angle du tir (point gauche)
            else if (t1 >= start && t1 < start + Angle)
            {
                var vecteurDirecteur = new Vector2(point1.X, point1.Y);
                var radius = (float)Math.Sqrt(vecteurDirecteur.X * vecteurDirecteur.X + vecteurDirecteur.Y * vecteurDirecteur.Y);

                if (radius <= Radius)
                {
                    //Console.WriteLine("Cible partiellement inclut dans l'angle du tir (point gauche)");

                    return true;
                }
            }
            //Cible partiellement inclut dans l'angle du tir (point droite)
            else if (t2 >= start && t2 < start + Angle)
            {
                var vecteurDirecteur = new Vector2(point2.X, point2.Y);
                var radius = (float)Math.Sqrt(vecteurDirecteur.X * vecteurDirecteur.X + vecteurDirecteur.Y * vecteurDirecteur.Y);

                if (radius <= Radius)
                {
                    //Console.WriteLine("Cible partiellement inclut dans l'angle du tir (point droite)");

                    return true;
                }
            }
            //Cible partiellement inclut dans l'angle du tir (point central)
            else if (t0 >= start && t0 < start + Angle)
            {
                var vecteurDirecteur = new Vector2(point.X, point.Y).Normalize();
                var radius = (float)Math.Sqrt(vecteurDirecteur.X * vecteurDirecteur.X + vecteurDirecteur.Y * vecteurDirecteur.Y);

                if (radius <= Radius)
                {
                    //Console.WriteLine("Cible partiellement inclut dans l'angle du tir (point central)");

                    return true;
                }
            }

            return false;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
