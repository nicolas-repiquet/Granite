using GameEngine.Components;
using GameEngine.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Entities
{
    public class GameObject : IObservable<GameObject>
    {
        private Guid m_gameObjectId;
        public Guid GameObjectId { get { return m_gameObjectId; } }

		private Dictionary<ComponentType, Component> m_components;

        private List<IObserver<GameObject>> m_observers;

        public GameObject()
		{
            m_gameObjectId = Guid.NewGuid();
            m_observers = new List<IObserver<GameObject>>();
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

        public IDisposable Subscribe(IObserver<GameObject> observer)
        {
            if (observer != null)
            {
                m_observers.Add(observer);
                observer.OnNext(this);
            }

            return null;
        }

        public void Notify()
        {
            if (m_observers != null)
            {
                Parallel.ForEach(m_observers, x => x.OnNext(this));
            }
        }
    }
}
