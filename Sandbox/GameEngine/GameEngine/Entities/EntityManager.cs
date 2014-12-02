using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Entities
{
    public class EntityManager
    {
        private static EntityManager s_instance;
        public static EntityManager Instance
        {
            get
            {
                if (s_instance == null)
                {
                    s_instance = new EntityManager();
                }

                return s_instance;
            }
        }

        private List<Entity> m_entities;

        public bool AddEntity(Entity entity)
        {
            if (m_entities == null)
            {
                m_entities = new List<Entity>();
            }

            
            return false;
        }

        public void RemoveEntity(Entity entity)
        {
            if (m_entities.Contains(entity))
            {
                m_entities.Remove(entity);
            }
        }
    }
}
