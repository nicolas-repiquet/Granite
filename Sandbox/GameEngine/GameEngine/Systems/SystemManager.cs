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

        private Dictionary<int, List<ISystem>> m_systems;

        public bool AddSystem(ISystem system, int priority)
        {
            if (m_systems == null)
            {
                m_systems = new Dictionary<int, List<ISystem>>();
            }

            if (system.Start())
            {
                if (!m_systems.ContainsKey(priority))
                {
                    m_systems.Add(priority, new List<ISystem>());
                }
                m_systems[priority].Add(system);
                return true;
            }
            return false;
        }

        public void Update(TimeSpan elapsed, Matrix4 transform)
        {
            foreach (var proc in m_systems)
            {
                Parallel.ForEach(proc.Value, x => x.Update(elapsed, transform));
            }
        }

        public void RemoveSystem(ISystem system)
        {
            system.End();
            foreach (var priority in m_systems)
            {
                if (priority.Value.Contains(system))
                {
                    priority.Value.Remove(system);
                }
            }
        }

        public void RemoveAllSystems()
        {
            foreach (var priority in m_systems)
            {
                Parallel.ForEach(priority.Value, x =>
                {
                    x.End();
                });
            }

            m_systems.Clear();
        }
    }
}
