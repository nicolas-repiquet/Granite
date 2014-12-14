using GameEngine.Components;
using GameEngine.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameEngine.Entities
{
    public class Entity
    {
        private Guid m_entityId;
        public Guid EntityId { get { return m_entityId; } }

        private List<Entity> m_children;
        public List<Entity> Children { get { return m_children; } }
        public bool HasChildren { get { return m_children != null && m_children.Any(); } }

		private Dictionary<ComponentType, Component> m_components;

        public Entity()
		{
            m_entityId = Guid.NewGuid();
		}

        public void AddComponent(ComponentType type, Component component)
        {
            if (m_components == null)
            {
                m_components = new Dictionary<ComponentType, Component>();
            }

            if (!m_components.ContainsKey(type))
            {
                m_components.Add(type, component);
                component.SetParent(this.m_entityId);
            }
        }

        public Component GetComponent(ComponentType type)
        {
            if (m_components != null && m_components.ContainsKey(type))
            {
                return m_components[type];
            }

            return null;
        }

        public void AddChild(Entity child)
        {
            if (m_children == null)
            {
                m_children = new List<Entity>();
            }

            m_children.Add(child);
        }
    }
}
