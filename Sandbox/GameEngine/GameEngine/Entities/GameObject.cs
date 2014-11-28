using GameEngine.Components;
using GameEngine.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Entities
{
    public class GameObject
    {
        private Guid m_gameObjectId;
        public Guid GameObjectId { get { return m_gameObjectId; } }

		private Dictionary<ComponentType, Component> m_components;

        public GameObject()
		{
            m_gameObjectId = Guid.NewGuid();
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
                component.SetParent(this.m_gameObjectId);

                foreach (var observer in SystemManager.Instance.Systems)
                {
                    component.Subscribe(observer);
                }
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
    }
}
