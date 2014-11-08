using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Granite.Core
{
    internal sealed class ApplicationSynchronizationContext : SynchronizationContext
    {
        private struct QueuedAction
        {
            public SendOrPostCallback Callback;
            public object State;
        }

        private readonly IntPtr m_window;
        private readonly Thread m_thread;
        private readonly Queue<QueuedAction> m_actions;

        public ApplicationSynchronizationContext(IntPtr window)
        {
            m_window = window;
            m_thread = Thread.CurrentThread;
            m_actions = new Queue<QueuedAction>();
        }

        public override void Send(SendOrPostCallback d, object state)
        {
            if (m_thread == Thread.CurrentThread)
            {
                d(state);
            }
            else
            {
                lock (m_actions)
                {
                    m_actions.Enqueue(new QueuedAction() { Callback = d, State = state });
                }

                WinApi.SendMessage(m_window, WinApi.WM_USER, IntPtr.Zero, IntPtr.Zero);
            }
        }

        public override void Post(SendOrPostCallback d, object state)
        {
            if (m_thread == Thread.CurrentThread)
            {
                d(state);
            }
            else
            {
                lock (m_actions)
                {
                    m_actions.Enqueue(new QueuedAction() { Callback = d, State = state });
                }

                WinApi.PostMessage(m_window, WinApi.WM_USER, IntPtr.Zero, IntPtr.Zero);
            }
        }

        public void ExecuteAction()
        {
            lock (m_actions)
            {
                if (m_actions.Count > 0)
                {
                    var action = m_actions.Dequeue();

                    action.Callback(action.State);
                }
            }
        }
    }
}
