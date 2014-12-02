using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Granite.Core
{
    public sealed class LogEntry
    {
        public LogEntryType Type { get; private set; }
        public string Message { get; private set; }
        public Exception Exception { get; private set; }

        public LogEntry(LogEntryType type, string message, Exception exception)
        {
            Type = type;
            Message = message;
            Exception = exception;
        }
    }

    [Flags]
    public enum LogEntryType
    {
        Debug = 1,
        Info = 2,
        Warning = 4,
        Error = 8
    }

    public interface ILogAppender
    {
        void Append(LogEntry entry);
    }

    public sealed class ConsoleLogAppender : ILogAppender
    {
        public LogEntryType Mask { get; set; }

        public ConsoleLogAppender()
        {
            Mask = LogEntryType.Debug | LogEntryType.Info | LogEntryType.Warning | LogEntryType.Error;
        }

        public void Append(LogEntry entry)
        {
            if ((entry.Type & Mask) != 0)
            {
                var oldColor = Console.ForegroundColor;

                switch (entry.Type)
                {
                    case LogEntryType.Debug:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;

                    case LogEntryType.Info:
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;

                    case LogEntryType.Warning:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;

                    case LogEntryType.Error:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                }

                Console.WriteLine(entry.Message);

                if (entry.Exception != null)
                {
                    Console.WriteLine(entry.Exception);
                }

                Console.ForegroundColor = oldColor;
            }
        }
    }
}
