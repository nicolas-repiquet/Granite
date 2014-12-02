using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Systems
{
    /// <summary>
    /// Pour l'instant je n'ai séparé que que les updates des renders,
    /// mais il faudrait un moyen de dire que tel ou tel system peuvent s'update ensemble ou non,
    /// ou qu'ils sont dépendants
    /// </summary>
    public class SystemManager
    {
        private static SystemManager s_instance;
        public static SystemManager Instance
        {
            get
            {
                if (s_instance == null)
                {
                    s_instance = new SystemManager();
                }

                return s_instance;
            }
        }

        private Dictionary<SystemType, System> m_updateSystems;
        private Dictionary<SystemType, IRenderSystem> m_renderSystems;
        private Dictionary<SystemType, System> m_systems;
        private TimeSpan m_timeElapsed;

        public TimeSpan TimeElapsed
        {
            get
            {
                return m_timeElapsed;
            }
        }

        public Dictionary<SystemType, System> Systems
        {
            get
            {
                return m_systems;
            }
        }

        public SystemManager()
        {
            m_updateSystems = new Dictionary<SystemType, System>();
            m_renderSystems = new Dictionary<SystemType, IRenderSystem>();
            m_systems = new Dictionary<SystemType, System>();
        }

        public void Initialize()
        {
            var move = new MoveSystem();
            m_updateSystems.Add(SystemType.MoveSystem, move);
            m_systems.Add(SystemType.MoveSystem, move);

            var collision = new CollisionSystem();
            m_updateSystems.Add(SystemType.CollisionSystem, collision);
            m_systems.Add(SystemType.CollisionSystem, collision);

            var render = new SpriteRenderSystem();
            m_renderSystems.Add(SystemType.SpriteRenderSystem, render);
            m_systems.Add(SystemType.SpriteRenderSystem, render);

            //On créé le graph de succession des systèmes
            foreach (var system in m_systems)
            {
                var predecessors = system.Value.Predecessors;
                foreach (var predecessor in predecessors)
                {
                    m_systems[predecessor].Subscribe(system.Value);
                }
            }
        }

        public void Update(TimeSpan elapsed)
        {
            m_timeElapsed = elapsed;
            Parallel.ForEach(m_updateSystems.Where(x => !x.Value.Predecessors.Any()).ToList(), x => x.Value.Update(elapsed));
        }

        public void Render(Matrix4 transform, TimeSpan elapsed)
        {
            Parallel.ForEach(m_renderSystems, x => x.Value.Update(elapsed));

            foreach(var render in m_renderSystems)
            {
                render.Value.Render(transform);
            }
        }
    }
}
