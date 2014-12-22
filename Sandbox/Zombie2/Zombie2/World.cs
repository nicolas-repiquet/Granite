using Granite.Core;
using Granite.Render;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Zombie2
{
    public class World
    {
        private static World s_instance;
        public static World Instance
        {
            get
            {
                return s_instance;
            }
        }

        private readonly Camera m_camera;
        private List<Triangle> m_triangles;

        public World()
        {
            var vertex = Assembly.GetExecutingAssembly().GetManifestResourceStream("Zombie2.Shaders.Vertex.glsl");
            var fragment = Assembly.GetExecutingAssembly().GetManifestResourceStream("Zombie2.Shaders.Fragment.glsl");

            var renderer = new Renderer(new TriangleProgram(vertex, fragment));
            RenderManager.Instance.SetRenderer(renderer);

            m_camera = new Camera();
            m_camera.Bounds = new Box2(0, 0, 1000, 1000);

            RenderManager.Instance.AddLayer("Floor");
            RenderManager.Instance.AddLayer("Test");

            m_triangles = new List<Triangle>();
            var random = new Random();

            for (var i = 0; i < 10000; i++)
            {
                var x = random.Next(-1000, 1000);
                var y = random.Next(-1000, 1000);
                var pos1 = new Vector2(x, y);
                var pos2 = new Vector2(x + 100, y);
                var pos3 = new Vector2(x, y + 100);
                var t = new Triangle()
                {
                    Position = new Vector2[]{ pos1, pos2, pos3 },
                    Color = new Color4ub(
                        (byte)random.Next(0, 255), 
                        (byte)random.Next(0, 255), 
                        (byte)random.Next(0, 255), 
                        255)
                };
                m_triangles.Add(t);
            }

            s_instance = this;
        }

        public void Update(TimeSpan elapsed)
        {
            var size = Engine.Display.GetSize();
            m_camera.SetSize(new Vector2(size.X, size.Y));

            m_camera.Update(elapsed);

            foreach (var t in m_triangles)
            {
                RenderManager.Instance.AddTriangle(
                    t.Position,
                    "Floor",
                    null,
                    t.Color);

                RenderManager.Instance.AddTriangle(
                    t.Position,
                    "Test",
                    null,
                    t.Color);
            }
        }

        public void Render(TimeSpan elapsed, Matrix4 transform)
        {
            transform *= m_camera.CreateWorldToCameraTransform();

            RenderManager.Instance.Render(elapsed, transform);
        }
    }
}
