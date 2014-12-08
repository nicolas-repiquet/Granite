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

        private Framebuffer m_framebufferAllLight;
        private Texture2D m_textureLight;

        public DayLight(Map map, double timeOfDay)
        {
            m_graphics = new Graphics();
            m_timeOfDay = timeOfDay;
            m_currentTime = timeOfDay;
            m_map = map;
            m_maxLight = new Color4(1, 1, 1, 1);
            //m_maxLight = new Color4(0.6f, 0.6f, 0.6f, 1);
            m_maxDark = new Color4(0.5f, 0.5f, 0.4f, 1);

            //Framebuffers
            m_framebufferAllLight = new Framebuffer();
            m_textureLight = new Texture2D();
            var size = Engine.Display.GetSize();
            m_textureLight.SetData<Color4ub>(size.X, size.Y, null);
            m_framebufferAllLight.Attach(m_textureLight);
        }

        public void Update(TimeSpan elapsed)
        {
            m_currentTime -= elapsed.TotalSeconds;

            if (m_currentTime < 0)
            {
                m_currentTime = m_timeOfDay;
            }
        }

        public void Render(Matrix4 transform)
        {
            GL.BindFramebuffer(m_framebufferAllLight);

            //Calcul du pourcentage de la journée passé
            var percentOfDay = m_currentTime * 100 / m_timeOfDay;
            if (percentOfDay < 40 && percentOfDay > 10)
            {
                var percentOfNight = (percentOfDay - 10) / (40f - 10f);

                var color = new Color4(
                    (float)((m_maxLight.R - m_maxDark.R) * percentOfNight + m_maxDark.R),
                    (float)((m_maxLight.G - m_maxDark.G) * percentOfNight + m_maxDark.G),
                    (float)((m_maxLight.B - m_maxDark.B) * percentOfNight + 0.2 + m_maxDark.B),
                    1);

                GL.ClearColor(color);
            }
            else if (percentOfDay > 60 && percentOfDay < 90)
            {
                var percentOfNight = (90f - percentOfDay) / (90f - 60f);

                var color = new Color4(
                    (float)((m_maxLight.R - m_maxDark.R) * percentOfNight + 0.3f + m_maxDark.R),
                    (float)((m_maxLight.G - m_maxDark.G) * percentOfNight + 0.1f + m_maxDark.G),
                    (float)((m_maxLight.B - m_maxDark.B) * percentOfNight + m_maxDark.B),
                    1);

                GL.ClearColor(color);
            }
            else if (percentOfDay > 40 && percentOfDay < 60)
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
