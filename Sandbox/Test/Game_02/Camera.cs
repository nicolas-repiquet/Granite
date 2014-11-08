using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test.Game_02
{
    public sealed class Camera : Entity, IUpdatable
    {
        private readonly LocationComponent m_location;
        //private readonly FollowTargetComponent m_target;
        private DateTime m_lastInput;

        private readonly Vector3 m_up = new Vector3(0, 0, 1);
        private Vector3 m_forward;
        private Vector3 m_left;
        private Vector3 m_target;
        private float m_phi;
        private float m_theta;
        private double m_speed;
        private double m_sensivity;


        private bool m_is3D;

        public LocationComponent Location { get { return m_location; } }
        //public ILocated Target { get { return m_target.Target; } set { m_target.Target = value; } }

        public Camera()
        {
            m_location = new LocationComponent(this);
            //m_target = new FollowTargetComponent(this, m_location);
            m_lastInput = DateTime.Now;

            m_theta = 0;
            m_phi = 0;
            m_speed = 0.01;
            m_sensivity = 0.2;
        }

        public void SetSize(Vector3 size)
        {
            var center = m_location.Location.Center;
            m_location.Location = new Box3(center - size / 2, size);
        }

        private void Input(TimeSpan elapsed)
        {
            if ((DateTime.Now - m_lastInput).TotalMilliseconds > 100)
            {
                if (Engine.Keyboard.IsKeyPressed(Key.Left))
                {
                    //this.Location.Location = this.Location.Location.Translate(m_left * (float)(m_speed  * elapsed.TotalMilliseconds));
                    this.Location.Location = this.Location.Location.Translate(new Vector3(-10, 0, 0));
                }

                if (Engine.Keyboard.IsKeyPressed(Key.Right))
                {
                    //this.Location.Location = this.Location.Location.Translate(m_left * -1f * (float)(m_speed  * elapsed.TotalMilliseconds));
                    this.Location.Location = this.Location.Location.Translate(new Vector3(10, 0, 0));
                }

                if (Engine.Keyboard.IsKeyPressed(Key.Up))
                {
                    //this.Location.Location = this.Location.Location.Translate(m_forward * (float)(m_speed  * elapsed.TotalMilliseconds));
                    this.Location.Location = this.Location.Location.Translate(new Vector3(0, 10, 0));
                }

                if (Engine.Keyboard.IsKeyPressed(Key.Down))
                {
                    //this.Location.Location = this.Location.Location.Translate(m_forward * -1f * (float)(m_speed  * elapsed.TotalMilliseconds));
                    this.Location.Location = this.Location.Location.Translate(new Vector3(0, -10, 0));
                }

                if (Engine.Keyboard.IsKeyPressed(Key.P))
                {
                    //this.Location.Location = this.Location.Location.Translate(new Vector3(0, 0, 10));
                    this.Location.Location = this.Location.Location.Translate(new Vector3(0, 0, -10));
                }

                if (Engine.Keyboard.IsKeyPressed(Key.M))
                {
                    //this.Location.Location = this.Location.Location.Translate(new Vector3(0, 0, -10));
                    this.Location.Location = this.Location.Location.Translate(new Vector3(0, 0, 10));
                }

                m_target = this.Location.Location.Position + m_forward;

                //VectorsFromAngles();
                m_lastInput = DateTime.Now;
            }
        }

        public void Update(TimeSpan elapsed)
        {
            Input(elapsed);

            //m_target.Update(elapsed);
        }

        public Matrix4 Look()
        {
            return Matrix4.LookAt(
                this.Location.Location.Position,
                m_target,
                m_up);
        }

        public Matrix4 CreateWorldToCameraTransform(float fov, float aspect, float zNear, float zFar)
        {
            float fH = (float)(Math.Tan(fov / 360 * Math.PI) * zNear);
            float fW = fH * aspect;

            var transform = Matrix4.Frustum(
                -fW,
                fW,
                -fH,
                fH,
                zNear,
                zFar);

            //transform *= Matrix4.Translate(
            // -m_location.Location.Position.X,
            // -m_location.Location.Position.Y,
            // -m_location.Location.Position.Z);



            return transform;

        }

        public Matrix4 CreateCameraToWorldTransform()
        {
            var location = m_location.Location;

            var transform = Matrix4.Identity;

            transform *= Matrix4.Translate((int)location.Position.X, (int)location.Position.Y, 0);
            transform *= Matrix4.Scale((float)location.Size.X / 2f, (float)location.Size.Y / 2f, 1f);
            transform *= Matrix4.Translate(1f, 1f, 0.0f);

            return transform;
        }

        public void VectorsFromAngles()
        {

            //On limite les valeurs de _phi, on vole certes, mais on en fait pas de loopings :p
            if (m_phi > 89)
                m_phi = 89;
            else if (m_phi < -89)
                m_phi = -89;

            //passage des coordonnées sphériques aux coordonnées cartésiennes
            double r_temp = Math.Cos(m_phi*Math.PI/180);
            m_forward =  new Vector3(
                (float)(r_temp * Math.Cos(m_theta*Math.PI/180)),
                (float)(r_temp * Math.Sin(m_theta*Math.PI/180)),
                (float)(Math.Sin(m_phi*Math.PI/180)));

            //diantre mais que fait ce passage ?
            m_left = Vector3.Cross(m_up, m_forward);
            m_left.Normalize();

            //avec la position de la caméra et la direction du regard, on calcule facilement ce que regarde la caméra (la cible)
            m_target = m_location.Location.Position + m_forward;
        }
    }
}
