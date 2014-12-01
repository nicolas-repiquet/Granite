using GameEngine.Components;
using GameEngine.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Systems
{
    public class MoveSystem : System
    {
        public MoveSystem()
            :base(SystemType.MoveSystem)
        {
            m_components.Add(ComponentType.Location);
            m_components.Add(ComponentType.Orientation);
            m_components.Add(ComponentType.Speed);
        }

        public void Update(TimeSpan elapsed)
        {
            Parallel.ForEach(m_datas, x =>
            {
                Execute(elapsed, x.Value);
            });
        }

        private void Execute(TimeSpan elapsed, GameObject data)
        {
            var speed = data.GetComponent(ComponentType.Speed) as SpeedComponent;
            speed.Current += speed.Acceleration;
            speed.Acceleration = 0;

            var orientation = data.GetComponent(ComponentType.Orientation) as OrientationComponent;

            var location = data.GetComponent(ComponentType.Location) as LocationComponent;
            location.X += (float)(speed.Current * orientation.X * elapsed.TotalSeconds);
            location.Y += (float)(speed.Current * orientation.Y * elapsed.TotalSeconds);

            data.Notify();
            Notify();
        }
    }
}
