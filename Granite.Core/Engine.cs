using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace Granite.Core
{
    public static class Engine
    {
        private static Application m_currentApplication;

        public static bool IsRunning { get { return m_currentApplication != null; } }

        public static void Run(IApplicationLogic logic, ApplicationSettings settings)
        {
            if (m_currentApplication == null)
            {
                if (logic == null) throw new ArgumentException("logic");
                if (settings == null) throw new ArgumentException("settings");

                try
                {
                    using (m_currentApplication = new Application(logic, settings))
                    {
                        m_currentApplication.Run();
                    }
                }
                finally
                {
                    m_currentApplication = null;
                }
            }
        }

        public static void Stop()
        {
            if (m_currentApplication != null)
            {
                m_currentApplication.Stop();
            }
        }

        public static void ExecuteAction(Action action)
        {
            if (m_currentApplication != null)
            {
                m_currentApplication.ExecuteAction(action);
            }
        }

        public static IDisplay Display { get { return m_currentApplication == null ? null : m_currentApplication.Display; } }
        public static IKeyboard Keyboard { get { return m_currentApplication; } }
    }
}
