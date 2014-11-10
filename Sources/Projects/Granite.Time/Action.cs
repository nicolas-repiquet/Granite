using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granite.Time
{
    public class Action
    {
        private Guid m_id;
        private Time m_parent;
        private DateTime m_lastExecution;
        private double m_interval;
        private Function m_function;
        public delegate void Function(double interval);

        public double Interval
        {
            get
            {
                return m_interval;
            }
        }

        public DateTime LastExecution
        {
            get
            {
                return m_lastExecution;
            }
        }

        public Guid Id
        {
            get
            {
                return m_id;
            }
        }

        public Action(Function del, double interval)
        {
            m_id = Guid.NewGuid();
            m_function = del;
            m_interval = interval;
        }

        public void SetInterval(double interval)
        {
            m_interval = interval;
        }

        public void SetParent(Time parent)
        {
            m_parent = parent;
        }

        public void Execution()
        {
            m_lastExecution = DateTime.Now;

            m_function(m_interval);
        }

        public void Dispose()
        {
            if (m_parent != null)
            {
                m_parent.HasDisposed(this);
            }
        }
    }
}
