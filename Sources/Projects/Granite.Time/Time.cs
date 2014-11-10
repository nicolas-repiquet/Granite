using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Granite.Time
{
    public class Time
    {
        #region Properties
        private static Time s_instance;

        public static Time Instance
        {
            get
            {
                if (s_instance == null)
                {
                    s_instance = new Time();
                }

                return s_instance;
            }
        }

        private bool m_run;
        private double m_interval;
        private Dictionary<Guid, Action> m_actions;

        private DateTime m_startTime;
        private Thread m_thread;
        #endregion

        #region Constructor
        public Time(double interval = 0.1)
        {
            m_interval = interval;
            m_actions = new Dictionary<Guid, Action>();
        }
        #endregion

        #region Methods
        public void SetInterval(double interval)
        {
            m_interval = interval;
        }

        public void AddAction(Action action)
        {
            if (!m_actions.ContainsKey(action.Id))
            {
                m_actions.Add(action.Id, action);
                action.SetParent(this);
            }
        }

        public void Start()
        {
            m_run = true;

            m_thread = new Thread(new ThreadStart(this.Run));
            m_thread.Start();
        }

        private void Run()
        {
            m_startTime = DateTime.Now;

            while (m_run)
            {
                lock (m_actions)
                {
                    Parallel.ForEach(m_actions.Select(x => x.Value), action =>
                    {
                        if ((DateTime.Now - action.LastExecution).TotalSeconds > action.Interval)
                        {
                            action.Execution();
                        }
                    });
                }

                Thread.Sleep(1);
            }
        }

        public void HasDisposed(Action action)
        {
            if (m_actions.ContainsKey(action.Id))
            {
                lock (m_actions)
                {
                    m_actions.Remove(action.Id);
                }
            }
        }

        public void Stop()
        {
            m_run = false;
            
        }

        public void Pause()
        {
            m_run = false;
        }

        public void Resume()
        {
            m_run = true;

            m_thread = new Thread(new ThreadStart(Run));
        }

        #endregion
    }
}
