using Granite.Core;
using Granite.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zombie.Game.Entities.Zones;

namespace Zombie.Game.Entities.World
{
    public class DayLight
    {
        private Graphics m_graphics;
        private double m_timeOfDay;
        private double m_currentTime;
        private Color4 m_maxLight;
        private Color4 m_maxDark;
        private Map m_map;
        private TimeSpan m_time;

        private Framebuffer m_framebufferAllLight;
        private Texture2D m_textureLight;

        private TimeSpan m_timeStartNight;
        private TimeSpan m_timeStartDay;
        private TimeSpan m_timeTransition;

        private bool m_isUpdated;

        public double DayProgress { get { return m_currentTime * 100 / m_timeOfDay; } }
        public TimeSpan DayTime { get { return m_time; } }

        public DayLight(Map map, double timeOfDay)
        {
            m_graphics = new Graphics();
            m_timeOfDay = timeOfDay;
            m_currentTime = timeOfDay;
            m_map = map;
            m_maxLight = new Color4(1, 1, 1, 1);
            //m_maxLight = new Color4(0.6f, 0.6f, 0.6f, 1);
            m_maxDark = new Color4(0.1f, 0.1f, 0.05f, 1);

            m_timeStartDay = new TimeSpan(07, 0, 0);
            m_timeStartNight = new TimeSpan(19, 0, 0);
            m_timeTransition = new TimeSpan(2, 0, 0);

            //Framebuffers
            m_framebufferAllLight = new Framebuffer();
            m_textureLight = new Texture2D();
            var size = Engine.Display.GetSize();
            m_textureLight.SetData<Color4ub>(size.X, size.Y, null);
            m_framebufferAllLight.Attach(m_textureLight);
        }

        public void CameraHasChanged()
        {
            m_isUpdated = true;

            m_textureLight = new Texture2D();
            var size = Engine.Display.GetSize();
            m_textureLight.SetData<Color4ub>(size.X, size.Y, null);
            m_framebufferAllLight.Attach(m_textureLight);

            m_isUpdated = false;
        }

        public void ConvertDayProgressToTime()
        {
            var secondsInDay = 24 * 3600;

            var progress = (1-(DayProgress/100.0)) * secondsInDay;

            m_time = TimeSpan.FromSeconds(progress);
        }

        public void Update(TimeSpan elapsed)
        {
            m_currentTime -= elapsed.TotalSeconds;

            if (m_currentTime < 0)
            {
                m_currentTime = m_timeOfDay;
            }

            var size = Engine.Display.GetSize();
            if (m_textureLight.Size != size)
            {
                m_textureLight = new Texture2D();
                m_textureLight.SetData<Color4ub>(size.X, size.Y, null);
                m_framebufferAllLight.Attach(m_textureLight);
            }

            ConvertDayProgressToTime();
        }

        public void Render(Matrix4 transform)
        {
            GL.BindFramebuffer(m_framebufferAllLight);

            //Calcul du pourcentage de la journée passé
            if (m_time > m_timeStartNight && m_time <= m_timeStartNight + m_timeTransition)
            {
                var percentOfTransitionInDay = m_timeTransition.TotalSeconds;
                var percentOfTransition = (m_time - m_timeStartNight).TotalSeconds;
                var percentOfNight = percentOfTransition / percentOfTransitionInDay;

                var color = new Color4(
                    (float)((m_maxLight.R - m_maxDark.R) * (1-percentOfNight) + m_maxDark.R),
                    (float)((m_maxLight.G - m_maxDark.G) * (1 - percentOfNight) + m_maxDark.G),
                    (float)((m_maxLight.B - m_maxDark.B) * (1 - percentOfNight) + 0.2 + m_maxDark.B),
                    1);

                GL.ClearColor(color);
            }
            else if (m_time > m_timeStartDay && m_time <= m_timeStartDay + m_timeTransition)
            {
                var percentOfTransitionInDay = m_timeTransition.TotalSeconds;
                var percentOfTransition = (m_time - m_timeStartDay).TotalSeconds;
                var percentOfDay = percentOfTransition / percentOfTransitionInDay;

                var color = new Color4(
                    (float)((m_maxLight.R - m_maxDark.R) * percentOfDay + 0.3f + m_maxDark.R),
                    (float)((m_maxLight.G - m_maxDark.G) * percentOfDay + 0.1f + m_maxDark.G),
                    (float)((m_maxLight.B - m_maxDark.B) * percentOfDay + m_maxDark.B),
                    1);

                GL.ClearColor(color);
            }
            else if (m_time > m_timeStartDay + m_timeTransition && m_time <= m_timeStartNight)
            {
                GL.ClearColor(m_maxLight);
            }
            else
            {
                GL.ClearColor(m_maxDark);
            }

            GL.Clear(GL.COLOR_BUFFER_BIT | GL.DEPTH_BUFFER_BIT);

            GL.BlendFunc(GL.ONE, GL.ONE);
            GL.BlendEquation(GL.FUNC_ADD);

            //GL.PolygonMode(GL.FRONT_AND_BACK, GL.LINE);
            m_map.RenderLights(transform);
            //GL.PolygonMode(GL.FRONT_AND_BACK, GL.FILL);

            GL.BindFramebuffer(null);

            GL.BlendFunc(GL.ZERO, GL.SRC_COLOR);

            var size = Engine.Display.GetSize();
            m_graphics.Draw(new Box2(new Vector2(-1, -1), new Vector2(2, 2)),
                m_textureLight, Vector2.Zero, Vector2.One);

            m_graphics.Flush();
        }
    }
}
