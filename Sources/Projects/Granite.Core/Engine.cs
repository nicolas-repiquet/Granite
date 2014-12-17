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

        #region Log

        private static readonly List<ILogAppender> m_logAppenders = new List<ILogAppender>();

        public static void AddLogAppender(ILogAppender appender)
        {
            if (appender != null)
            {
                m_logAppenders.Add(appender);
            }
        }

        public static void RemoveLogAppender(ILogAppender appender)
        {
            if(appender != null)
            {
                m_logAppenders.Remove(appender);
            }
        }

        public static void LogDebug(string message)
        {
            Log(new LogEntry(LogEntryType.Debug, message, null));
        }

        public static void LogDebug(string format, params object[] args)
        {
            Log(new LogEntry(LogEntryType.Debug, string.Format(format, args), null));
        }

        public static void LogInfo(string message)
        {
            Log(new LogEntry(LogEntryType.Info, message, null));
        }

        public static void LogInfo(string format, params object[] args)
        {
            Log(new LogEntry(LogEntryType.Info, string.Format(format, args), null));
        }

        public static void LogWarning(string message)
        {
            Log(new LogEntry(LogEntryType.Warning, message, null));
        }

        public static void LogWarning(string message, Exception exception)
        {
            Log(new LogEntry(LogEntryType.Warning, message, exception));
        }

        public static void LogWarning(string format, params object[] args)
        {
            Log(new LogEntry(LogEntryType.Warning, string.Format(format, args), null));
        }

        public static void LogError(string message)
        {
            Log(new LogEntry(LogEntryType.Warning, message, null));
        }

        public static void LogError(string message, Exception exception)
        {
            Log(new LogEntry(LogEntryType.Error, message, exception));
        }

        public static void LogError(string format, params object[] args)
        {
            Log(new LogEntry(LogEntryType.Warning, string.Format(format, args), null));
        }

        public static void Log(LogEntry entry)
        {
            foreach (var appender in m_logAppenders)
            {
                appender.Append(entry);
            }
        }
        
        #endregion
    }
}
