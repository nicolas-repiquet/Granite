using GameEngine.Components;
using GameEngine.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameEngine.Entities
{
    public class GameObject
    {
        private Guid m_gameObjectId;
        public Guid GameObjectId { get { return m_gameObjectId; } }

        private List<GameObject> m_children;
        public List<GameObject> Children { get { return m_children; } }
        public bool HasChildren { get { return m_children != null && m_children.Any(); } }

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

                //Parallel.ForEach(SystemManager.Instance.Systems, x =>
                //    {
                //        var hasAll = true;
                //        foreach (var c in x.Value.Components)
                //        {
                //            if (!m_components.ContainsKey(c))
                //            {
                //                hasAll = false;
                //            }
                //        }

                //        if (hasAll)
                //        {
                //            Subscribe(x.Value);
                //        }
                //    });
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

        public void AddChild(GameObject child)
        {
            if (m_children == null)
            {
                m_children = new List<GameObject>();
            }

            m_children.Add(child);
        }

        //public IDisposable Subscribe(IObserver<GameObject> observer)
        //{
        //    if (observer != null)
        //    {
        //        m_observers.Add(observer);
        //        observer.OnNext(this);
        //    }

        //    return null;
        //}

        //public void Notify()
        //{
        //    if (m_observers != null)
        //    {
        //        Parallel.ForEach(m_observers, x => x.OnNext(this));
        //    }
        //}
    }
}
