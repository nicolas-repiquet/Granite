using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multithread
{
    public class ThreadMove
    {
        public volatile SphereState[] States;
        public volatile int IndexStart;
        public volatile int IndexEnd;

        private Thread m_thread;

        public ThreadMove()
        {

        }

        public void Start()
        {
            m_thread = new Thread(Move);
            m_thread.Start();
            //var t = Task.Factory.StartNew(Run);
            
        }

        public void Move()
        {
            if (States != null)
            {
                for (var i = IndexStart; i < IndexEnd; i++)
                {
                    var state = States[i];
                    state.Sphere.Location.Position =
                    new Vector3(
                        state.Sphere.Location.Position.X + 10,
                        state.Sphere.Location.Position.Y,
                        state.Sphere.Location.Position.Z
                        );

                    state.HasMoved = true;

                    States[i] = state;
                }
            }
        }
    }
}
