using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Systems
{
    public enum SystemType
    {
        MoveSystem = 0
    }

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

        private Dictionary<SystemType, IUpdateSystem> m_updateSystems;
        private Dictionary<SystemType, IRenderSystem> m_renderSystems;
        private List<ISystem> m_systems;

        public List<ISystem> Systems
        {
            get
            {
                return m_systems;
            }
        }

        public SystemManager()
        {
            m_updateSystems = new Dictionary<SystemType, IUpdateSystem>();
            m_renderSystems = new Dictionary<SystemType, IRenderSystem>();
            m_systems = new List<ISystem>();
        }

        public void Initialize()
        {
            var move = new MoveSystem();
            m_updateSystems.Add(SystemType.MoveSystem, move);
            m_systems.Add(move);
            //m_renderSystems.Add(SystemType.MoveSystem, move);
        }

        public void Update(TimeSpan elapsed)
        {
            Parallel.ForEach(m_updateSystems, x => x.Value.Update(elapsed));
        }

        public void Render(Matrix4 transform)
        {
            foreach(var render in m_renderSystems)
            {
                render.Value.Render(transform);
            }
        }
    }
}
