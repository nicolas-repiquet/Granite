using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granite.Collision
{
    public class Collision
    {
        #region Autres
        public static float Determinant(Vector2 v1, Vector2 v2)
        {
            return v1.X * v2.Y - v1.Y * v2.X;
        }
        #endregion

        #region Detections
        public static bool Detection(Box2 b1, Box2 b2)
        {
            if ((b2.MinX >= b1.MaxX)        // trop à droite
                || (b2.MaxX <= b1.MinX)     // trop à gauche
                || (b2.MinY >= b1.MaxY)     // trop en bas
                || (b2.MaxY <= b1.MinY))    // trop en haut
                return false;
            else
                return true; 
        }

        public static bool Detection(List<Vector2> shape1, List<Vector2> shape2)
        {
            if (shape1 == null || shape1.Count == 0
                || shape2 == null || shape2.Count == 0)
            {
                return false;
            }

            var collision = false;
            var sousCollision = true;
            int iterShape1 = 0;
            int iterShape2 = 0;

            while (!collision && iterShape2 < shape2.Count)
            {
                Vector2 point = shape2.ElementAt(iterShape2);

                //On test si le points est à 
                sousCollision = true;
                iterShape1 = 0;
                while (sousCollision && iterShape1 < shape1.Count)
                {
                    Vector2 p1 = shape1.ElementAt(iterShape1);
                    Vector2 p2;

                    //Si on est sur le dernier point, on relie au premier
                    if (iterShape1 == shape1.Count - 1)
                    {
                        p2 = shape1.ElementAt(0);
                    }
                    else
                    {
                        p2 = shape1.ElementAt(iterShape1 + 1);
                    }

                    //Calcul des 2 vecteurs
                    var v1 = new Vector2(
                        p2.X - p1.X,
                        p2.Y - p1.Y
                        );

                    var v2 = new Vector2(
                        point.X - p1.X,
                        point.Y - p1.Y
                        );

                    //Calcul du déterminant
                    var det = Collision.Determinant(v1, v2);

                    if (det < 0) //Si le point est à droite
                        sousCollision = false;

                    iterShape1++;
                }

                collision = sousCollision;

                iterShape2++;
            }

            return collision;
        }


        public static bool DetectionDroiteSegment(
            Vector2 A, Vector2 B, Vector2 O, Vector2 P)
        {
            var AB = new Vector2(B.X - A.X, B.Y - A.Y);
            var AP = new Vector2(P.X - A.X, P.Y - A.Y);
            var AO = new Vector2(O.X - A.X, O.Y - A.Y);

            if ((AB.X * AP.Y - AB.Y * AP.X) * (AB.X * AO.Y - AB.Y * AO.X) < 0)
                return true;
            else
                return false; 
        }
        #endregion

        #region Intersects
        public static List<Vector2> Intersect(Box2 b1, Box2 b2)
        {
            var intersections = new List<Vector2>();



            return intersections;
        }

        public static Vector2? IntersectSegmentSegment(
            Vector2 A, Vector2 B, Vector2 O, Vector2 P)
        {
            if (DetectionDroiteSegment(A, B, O, P) == false)
                return null;  // inutile d'aller plus loin si le segment [OP] ne touche pas la droite (AB) 
            Vector2 AB, OP;
            AB = new Vector2(B.X - A.X, B.Y - A.Y);
            OP = new Vector2(P.X - O.X, P.Y - O.Y);

            float k = -(A.X * OP.Y - O.X * OP.Y - OP.X * A.Y + OP.X * O.Y) / (AB.X * OP.Y - AB.Y * OP.X);

            if (k < 0 || k > 1)
            {
                return null;
            }
            else
            {
                float l = -(-AB.X * A.Y + AB.X * O.Y + AB.Y * A.X - AB.Y * O.X) / (AB.X * OP.Y - AB.Y * OP.X);

                return O + (OP * l);
                //return O + (OP * (l - 0.001f));
            }
        }
        #endregion
    }
}
