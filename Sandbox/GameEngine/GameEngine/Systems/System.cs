using GameEngine.Components;
using GameEngine.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Systems
{
    public enum SystemType
    {
        MoveSystem = 0,
        SpriteRenderSystem = 1,
        CollisionSystem = 2
    }

    public abstract class System : ISystem, IObservable<System>, IObserver<System>
    {
        protected List<SystemType> m_predecessorDefinition;
        protected Dictionary<SystemType, System> m_predecessor;
        protected List<ComponentType> m_components;
        protected List<IObserver<System>> m_observers;
        protected SystemType m_type;
        protected Dictionary<Guid, GameObject> m_datas;

        public List<SystemType> Predecessors { get { return m_predecessorDefinition; } }
        public List<ComponentType> Components { get { return m_components; } }
        public SystemType Type { get { return m_type; } }

        public System(SystemType type)
        {
            m_predecessorDefinition = new List<SystemType>();
            m_predecessor = new Dictionary<SystemType, System>();
            m_components = new List<ComponentType>();
            m_observers = new List<IObserver<System>>();
            m_type = type;
            m_datas = new Dictionary<Guid, GameObject>();
        }

        public void AddPredecessor(SystemType type)
        {
            if (!m_predecessorDefinition.Contains(type))
            {
                m_predecessor.Add(type, null);
            }
        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(GameObject value)
        {
            if (value != null)
            {
                if (m_datas.ContainsKey(value.GameObjectId))
                {
                    m_datas[value.GameObjectId] = value;
                }
                else
                {
                    m_datas.Add(value.GameObjectId, value);
                }
            }
        }

        public void Update(TimeSpan elapsed)
        {
            
        }

        public IDisposable Subscribe(IObserver<System> observer)
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


        public void OnNext(System value)
        {
            if (value != null)
            {
                //Si tout les predecesseur sont remplit, on fais le update et on vide tout.
                if (!m_predecessor.Any(x => x.Value == null))
                {
                    this.Update(SystemManager.Instance.TimeElapsed);
                    foreach (var key in m_predecessor.Keys)
                    {
                        m_predecessor[key] = null;
                    }
                }

                m_predecessor[value.Type] = value;
            }
        }
    }
}
