using GameEngine.Components;
using GameEngine.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Systems
{
    public class CollisionSystem : System
    {
        public CollisionSystem()
            : base(SystemType.CollisionSystem)
        {
            m_components.Add(ComponentType.Location);
            m_components.Add(ComponentType.Orientation);
            m_components.Add(ComponentType.Speed);

            m_predecessorDefinition.Add(SystemType.MoveSystem);
        }

        public void Update(TimeSpan elapsed)
        {
            Parallel.ForEach(m_datas, x =>
            {
                Execute(elapsed, x.Value);
            });

            Console.WriteLine("[CollisionSystem] Update ended");
        }

        private void Execute(TimeSpan elapsed, GameObject data)
        {
           
            data.Notify();
            Notify();
        }
    }
}
