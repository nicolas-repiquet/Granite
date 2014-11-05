using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test.Game_02
{
    public class Geode : Entity, ILocated, IUpdatable, IRenderable
    {
        private readonly GeodeRenderer m_renderer;

        private List<Triangle> m_origin;
        private List<Triangle> m_triangles;
        private bool m_trianglesHasChanged;

        private int N = 4;
        private int R = 100;
        public int NbTriangles = 0;

        private DateTime m_lastInput;

        public Geode()
        {
            
            m_lastInput = DateTime.Now;

            m_origin = new List<Triangle>();
            m_triangles = new List<Triangle>();

            BuildOrigin();
            Build();
            

            m_renderer = new GeodeRenderer();
        }

        private void Build()
        {
            BuildSphere(R, N, true);

            m_trianglesHasChanged = true;
        }

        private List<Triangle> BuildOcto(double R)
        {
            return null;
        }

        private List<Triangle> BuildIco(double R)
        {
            float phi = (float)((Math.Sqrt(5.0) - 1.0) / 2.0);
            float radius = (float)Math.Sqrt((5 - Math.Sqrt(5)) / 2.0);
            float A = (float)R / radius;
            float B = phi * A;

            var I0 = new Vector3(A, B, 0);
            var I1 = new Vector3(-A, B, 0);
            var I2 = new Vector3(-A, -B, 0);
            var I3 = new Vector3(A, -B, 0);
            var J0 = new Vector3(0, A, B);
            var J1 = new Vector3(0, -A, B);
            var J2 = new Vector3(0, -A, -B);
            var J3 = new Vector3(0, A, -B);
            var K0 = new Vector3(B, 0, A);
            var K1 = new Vector3(B, 0, -A);
            var K2 = new Vector3(-B, 0, -A);
            var K3 = new Vector3(-B, 0, A);

            var list = new List<Triangle>();

            var t = new Triangle(I3, I0, K0);
            list.Add(t);
            t = new Triangle(I0, I3, K1);
            list.Add(t);
            t = new Triangle(I2, I1, K2);
            list.Add(t);
            t = new Triangle(I1, I2, K3);
            list.Add(t);

            t = new Triangle(J3, J0, I0);
            list.Add(t);
            t = new Triangle(J0, J3, I1);
            list.Add(t);
            t = new Triangle(J2, J1, I2);
            list.Add(t);
            t = new Triangle(J1, J2, I3);
            list.Add(t);

            t = new Triangle(K3, K0, J0);
            list.Add(t);
            t = new Triangle(K0, K3, J1);
            list.Add(t);
            t = new Triangle(K2, K1, J2);
            list.Add(t);
            t = new Triangle(K1, K2, J3);
            list.Add(t);

            t = new Triangle(I0, J0, K0);
            list.Add(t);
            t = new Triangle(I0, K1, J3);
            list.Add(t);
            t = new Triangle(I3, K0, J1);
            list.Add(t);
            t = new Triangle(I3, J2, K1);
            list.Add(t);
            t = new Triangle(I1, K3, J0);
            list.Add(t);
            t = new Triangle(I1, J3, K2);
            list.Add(t);
            t = new Triangle(I2, J1, K3);
            list.Add(t);
            t = new Triangle(I2, K2, J2);
            list.Add(t);

            return list;
        }

        private void BuildSphere(float R, int N, bool ico)
        {
            /* nombre total de triangles */
            int nbT = ico?20:8;
            int nb = nbT * N * N;
            List<Triangle> poly = ico?BuildIco(R):BuildOcto(R);

            /* tableaux des triangles que l'on va produire et index dans ce tableau */
            List<Triangle> sphere = new List<Triangle>();

            /* coordonnée barycentrique (sans la division par N),
                du sommet C */
            var init_coef = new Vector3(0, 0, N );
            /* direction pour aller de C vers A (en bas à gauche) */
            var left_down = new Vector3( 1, 0, -1 );
            /* direction pour aller de C vers B (en bas à droite) */
            var right_down = new Vector3( 0, 1, -1 );

            /* points de la ligne au dessus des triangles que l'on est en train de créer */
            var up = new Vector3[N];
            /* points en dessous de la même ligne (un point de plus */
            var down = new Vector3[N+1];
            /* coefficients barycentrique de ces points (non divisé par N) */
            var coef_up = new Vector3[N];
            var coef_down = new Vector3[N+1];
            /* tous les vecteurs ci-dessous sont alloués à N ou N+1, leur taille maximale */

            /* variables de boucles */

            var random = new Random();

            int i,j,k;

            /* boucles sur les 8 ou 20 triangles */
            for(i=0;i<nbT;i++) {
                Triangle T = poly[i];

                /* première ligne, un seul point "C" */
                up[0] = T.P3;
                coef_up[0] = init_coef;

                /* boucle sur les lignes */

                for(j=0;j<N;j++) {

                    /* initialisation de la ligne "down" à partir de "up" */
                    coef_down[0] = coef_up[0] + left_down;
                    down[0] = Barycentre2(T, coef_down[0].X, coef_down[0].Y, coef_down[0].Z);
                    down[0] = SetNorm(down[0], R);

                    for(k=1;k<=j+1;k++) {
                        coef_down[k] = coef_up[k-1] + right_down;
                        down[k] = Barycentre2(T, coef_down[k].X, coef_down[k].Y, coef_down[k].Z);
                        down[k] = SetNorm(down[k], R);
                    }

                    /* production des triangles entre les deux lignes */
                    sphere.Add(new Triangle(up[0], down[0], down[1], 
                        new Vector4(
                            (float)random.NextDouble(),
                            (float)random.NextDouble(),
                            (float)random.NextDouble(),
                            1
                            )));
                    for (k=1;k<=j;k++) {
                        sphere.Add(new Triangle(up[k - 1], down[k], up[k],
                        new Vector4(
                            (float)random.NextDouble(),
                            (float)random.NextDouble(),
                            (float)random.NextDouble(),
                            1
                            )));
                        sphere.Add(new Triangle(up[k], down[k], down[k + 1],
                        new Vector4(
                            (float)random.NextDouble(),
                            (float)random.NextDouble(),
                            (float)random.NextDouble(),
                            1
                            )));
                    }

                    /* recopie de down dans up pour le prochain tour de boucle */
                    /* inutile au dernier tour de boucle */
                    if (j < N - 1) for (k=0;k<=j+1;k++) {
                        up[k] = down[k];
                        coef_up[k] = coef_down[k];
                    }
                }
            }
            m_triangles = sphere;

            NbTriangles = m_triangles.Count();

            CalculNormal();
        }

        private void CalculNormal()
        {
            foreach (var triangle in m_triangles)
            {
                var normal = Normal(triangle);
                triangle.Color = new Vector4(normal.X, normal.Y, normal.Z, 1);
            };
        }

        private Vector3 Normal(Triangle t)
        {
            var u = new Vector3(
                t.P2.X - t.P1.X,
                t.P2.Y - t.P1.Y,
                t.P2.Z - t.P1.Z
                );

            var v = new Vector3(
                t.P3.X - t.P1.X,
                t.P3.Y - t.P1.Y,
                t.P3.Z - t.P1.Z
                );

            var normal = new Vector3(
                u.Y * v.Z - v.Y * u.Z,
                -(u.X * v.Z - v.X * u.Z),
                u.X * v.Y - v.X * u.Y);

            return normal;
        }

        private void BuildOrigin()
        {
            m_origin.Add(
              new Triangle()
              {
                  P1 = new Vector3(-100, 0, 0),
                  P2 = new Vector3(100, 10, 0),
                  P3 = new Vector3(100, 0, 0),
                  Color = new Vector4(1, 0, 0, 1)
              }
          );

            m_origin.Add(
               new Triangle()
               {
                   P1 = new Vector3(0, -100, 0),
                   P2 = new Vector3(10, 100, 0),
                   P3 = new Vector3(0, 100, 0),
                   Color = new Vector4(0, 1, 0, 1)
               }
           );

            m_origin.Add(
             new Triangle()
             {
                 P1 = new Vector3(0, 0, -100),
                 P2 = new Vector3(10, 0, 100),
                 P3 = new Vector3(0, 0, 100),
                 Color = new Vector4(0, 0, 1, 1)
             }
          );
        }

        private Vector3 Barycentre(Triangle triangle, float p1, float p2, float p3)
        {
            float x = (triangle.P1.X * p1 + triangle.P2.X * p2 + triangle.P3.X * p3) / p1 + p2 + p3;
            float y = (triangle.P1.Y * p1 + triangle.P2.Y * p2 + triangle.P3.Y * p3) / p1 + p2 + p3;
            float z = (triangle.P1.Z * p1 + triangle.P2.Z * p2 + triangle.P3.Z * p3) / p1 + p2 + p3;

            return new Vector3(x, y, z);
        }

        private Vector3 Barycentre2(Triangle triangle, float p1, float p2, float p3)
        {
            return new Vector3(p1 * triangle.P1.X + p2 * triangle.P2.X + p3 * triangle.P3.X,
                     p1 * triangle.P1.Y + p2 * triangle.P2.Y + p3 * triangle.P3.Y,
                     p1 * triangle.P1.Z + p2 * triangle.P2.Z + p3 * triangle.P3.Z);
        }

        private double Norm(Vector3 P) {
            return(Math.Sqrt(P.X * P.X + P.Y * P.Y + P.Z * P.Z));
        }

        private Vector3 SetNorm(Vector3 P, float R)
        {
            float n = (float)Norm(P);

            return new Vector3(
                P.X / n * R,
                P.Y / n * R,
                P.Z / n * R
                );
        }


        private void Input(TimeSpan elapsed)
        {
            if ((DateTime.Now - m_lastInput).TotalMilliseconds > 100)
            {
                if (Engine.Keyboard.IsKeyPressed(Key.PageUp))
                {
                    N += 10;
                    Build();
                }

                if (Engine.Keyboard.IsKeyPressed(Key.PageDown))
                {
                    N -= 10;
                    if (N < 4)
                    {
                        N = 4;
                    }
                    Build();
                }

                //VectorsFromAngles();
                m_lastInput = DateTime.Now;
            }
        }

        public void Update(TimeSpan elapsed)
        {
            Input(elapsed);
            if (m_trianglesHasChanged)
            {
                m_renderer.Clear();

                foreach (var triangle in m_origin)
                {
                    m_renderer.AddTriangle(triangle);
                }

                foreach (var triangle in m_triangles)
                {
                    m_renderer.AddTriangle(triangle);
                }

                m_trianglesHasChanged = false;
            }
        }

        public void Render(Matrix4 transform)
        {
            m_renderer.Render(transform);
        }

        public Box3 Location
        {
            get { return new Box3(0, 0, 0, 0, 0, 0); }
        }
    }
}
