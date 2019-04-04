using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Runtime.Remoting;

namespace BatchStoreEmailTool
{
    public delegate void MessageLoggedEventHandler(object source, MyEventArgs e);

    public enum EventLoggingLevel
    {
        LOGGING_LEVEL_NONE = 0,
        LOGGING_LEVEL_ERROR_MESSAGES = 1,
        LOGGING_LEVEL_MAJOR_ACTIVITY = 2,
        LOGGING_LEVEL_ALL = 3
    }

    public class MyEventArgs : EventArgs
    {
        private string EventInfo;

        public MyEventArgs(string Text)
        {
            EventInfo = Text;
        }
        public string GetInfo()
        {
            return EventInfo;
        }
    }

    public class AddinTraceListener : System.Diagnostics.TraceListener
    {
        private EventLogTraceListener innerEventLog = null;
        private readonly string defaultApplicationName = "CRG Batch Store Email AddIn for Outlook";

        public string ApplicationName { get; set; }
        public EventLoggingLevel LoggingLevel { get; set; }

        public event MessageLoggedEventHandler MessageLogged;

        public AddinTraceListener()
        {
            this.ApplicationName = defaultApplicationName;
            InitializeEventLog(this.ApplicationName);
            this.innerEventLog = new EventLogTraceListener("Application");
            LoggingLevel = EventLoggingLevel.LOGGING_LEVEL_ERROR_MESSAGES;
        }

        public AddinTraceListener(EventLogTraceListener innerLog)
        {
            this.ApplicationName = defaultApplicationName;
            InitializeEventLog(this.ApplicationName);
            this.innerEventLog = innerLog;
            LoggingLevel = EventLoggingLevel.LOGGING_LEVEL_ERROR_MESSAGES;
        }

        private void InitializeEventLog(string SourceName)
        {
            if (!System.Diagnostics.EventLog.SourceExists(SourceName))
            {
                System.Diagnostics.EventLog.CreateEventSource(SourceName, "Application");
            }
        }

        public override void Close()
        {
            base.Close();
        }
        
        public override void Fail(string message)
        {
            base.Fail(message);
        }

        public override void Fail(string message, string detailMessage)
        {
            base.Fail(message, detailMessage);
        }

        public override void TraceData(TraceEventCache eventCache, string source, TraceEventType eventType, int id, object data)
        {
            base.TraceData(eventCache, source, eventType, id, data);
        }

        public override void TraceData(TraceEventCache eventCache, string source, TraceEventType eventType, int id, params object[] data)
        {
            base.TraceData(eventCache, source, eventType, id, data);
        }

        public override void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id)
        {
            base.TraceEvent(eventCache, source, eventType, id);
        }

        public override void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id, string message)
        {
            base.TraceEvent(eventCache, source, eventType, id, message);
        }

        public override void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id, string format, params object[] args)
        {
            base.TraceEvent(eventCache, source, eventType, id, format, args);
        }

        public override void TraceTransfer(TraceEventCache eventCache, string source, int id, string message, Guid relatedActivityId)
        {
            base.TraceTransfer(eventCache, source, id, message, relatedActivityId);
        }

        public override void Write(string message)
        {
            if(LoggingLevel >= EventLoggingLevel.LOGGING_LEVEL_ERROR_MESSAGES)
            {
                innerEventLog.Write(message);
            }

            if (MessageLogged != null)
            {
                MessageLogged(this, new MyEventArgs(message));
            }
        }

        public override void Write(object o)
        {
            base.Write(o);
        }

        public override void Write(string message, string category)
        {
            base.Write(message, category);
        }

        public override void Write(object o, string category)
        {
            base.Write(o, category);
        }

        public override void WriteLine(string message)
        {
            throw new NotImplementedException();
        }

        public override void WriteLine(object o)
        {
            base.WriteLine(o);
        }

        public override void WriteLine(string message, string category)
        {
            base.WriteLine(message, category);
        }

        public override void WriteLine(object o, string category)
        {
            base.WriteLine(o, category);
        }

    }
}
