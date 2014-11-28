using GameEngine.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Systems
{
    public class MoveSystem : ISystem, IUpdateSystem
    {
        private class MoveData
        {
            public LocationComponent Location { get; set; }
            public LocationComponent PreviousLocation { get; set; }
            public OrientationComponent Orientation { get; set; }

            public bool IsComplete { get { return Location != null && Orientation != null; } }
        }

        private Dictionary<Guid, MoveData> m_datas;

        public MoveSystem()
        {
            m_datas = new Dictionary<Guid, MoveData>();
        }

        public void Update(TimeSpan elapsed)
        {
            Parallel.ForEach(m_datas.Where(x => x.Value.IsComplete), x =>
            {
                Execute(elapsed, x.Value);
            });
        }

        private void Execute(TimeSpan elapsed, MoveData data)
        {
            var speed = 10; //En attendant d'avoir le composant speed

            data.Location.X += (float)(speed * data.Orientation.X * elapsed.TotalSeconds);
            data.Location.Y += (float)(speed * data.Orientation.Y * elapsed.TotalSeconds);

            data.Location.Notify();
        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(Component value)
        {
            if (value != null)
            {
                MoveData data = null;

                if (m_datas.ContainsKey(value.ComponentParentId))
                {
                    data = m_datas[value.ComponentParentId];

                    if (value.ComponentType == ComponentType.Location)
                    {
                        data.PreviousLocation = data.Location;
                        data.Location = value as LocationComponent;
                    }
                    else if (value.ComponentType == ComponentType.Orientation)
                    {
                        data.Orientation = value as OrientationComponent;
                    }
                }
                else
                {
                    data = new MoveData();

                    if (value.ComponentType == ComponentType.Location)
                    {
                        data.Location = value as LocationComponent;
                    }
                    else if (value.ComponentType == ComponentType.Orientation)
                    {
                        data.Orientation = value as OrientationComponent;
                    }

                    m_datas.Add(value.ComponentParentId, data);
                }

                
            }
        }
    }
}
