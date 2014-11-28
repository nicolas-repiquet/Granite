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
            public SpeedComponent Speed { get; set; }

            public bool IsComplete { get { return Location != null && Orientation != null && Speed != null; } }
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
            data.Speed.Current += data.Speed.Acceleration;
            data.Speed.Acceleration = 0;

            data.Location.X += (float)(data.Speed.Current * data.Orientation.X * elapsed.TotalSeconds);
            data.Location.Y += (float)(data.Speed.Current * data.Orientation.Y * elapsed.TotalSeconds);

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
                    else if (value.ComponentType == ComponentType.Speed)
                    {
                        data.Speed = value as SpeedComponent;
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
                    else if (value.ComponentType == ComponentType.Speed)
                    {
                        data.Speed = value as SpeedComponent;
                    }

                    m_datas.Add(value.ComponentParentId, data);
                }

                
            }
        }
    }
}
