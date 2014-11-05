using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Test.Game_02
{
    public class Game : ApplicationLogicBase
    {
        private Geode m_geode;
        private Camera m_camera;
        public Camera Camera { get { return m_camera; } }

        public static void Main(string[] args)
        {
            Engine.Run(new Game(), new ApplicationSettings()
            {
                DisplayStyle = DisplayStyle.ResizeableWithTitle
            });
        }

        public override void Start()
        {
            m_geode = new Geode();

            m_camera = new Camera();
            m_camera.Location.Location = new Box3(new Vector3(-200, 100, -200), new Vector3(10, 10, 10));
            var size = Engine.Display.GetSize();
            //m_camera.Target = m_geode;
        }

        public override void Render(TimeSpan elapsed)
        {
            Engine.Display.Invalidate();

            Engine.Display.SetTitle(string.Format("{0:0} FPS, Triangles : {1}", Engine.Display.FramesPerSecond,
                m_geode.NbTriangles));

            var size = Engine.Display.GetSize();
            m_camera.Update(elapsed);

            m_geode.Update(elapsed);

            GL.Viewport(size);
            GL.Enable_DEPTH_TEST();
            GL.ClearColor(0.6f, 0.8f, 1.0f, 1.0f);
            GL.Clear(GL.COLOR_BUFFER_BIT | GL.DEPTH_BUFFER_BIT);
            GL.Enable_BLEND();
            GL.BlendFunc(GL.SRC_ALPHA, GL.ONE_MINUS_SRC_ALPHA);

            var aspect = (float)size.X / (float)size.Y;
            var fov = 45f;



            var projection = m_camera.CreateWorldToCameraTransform(fov, aspect, 0.1f, 1000f);

            var view = Matrix4.LookAt(
                m_camera.Location.Location.Position,
                Vector3.Zero,
                Vector3.UnitY);
            //var view = m_camera.Look();

            //var view = Matrix4.Translate(0, 0, 0);



            var model = Matrix4.Identity * Matrix4.Scale(1, 1, -1);
            //projection *= Matrix4.Translate(
            // -m_camera.Location.Location.Position.X,
            // -m_camera.Location.Location.Position.Y,
            // -m_camera.Location.Location.Position.Z);
            

            //var rotation = Matrix4.RotateX(-m_camera.Location.Direction.X);
            //rotation *= Matrix4.RotateY(-m_camera.Location.Direction.Y);
            
            ////rotation *= Matrix4.RotateZ(m_camera.Location.Direction.Z);

            //transform *= rotation;

            var transform = projection * model * view;
            //var transform = projection * view * model;
            //var transform = view * model * projection;
            
            //var transform = projection  * model;

            m_geode.Render(transform);

            GL.Finish();
        }
    }
}
