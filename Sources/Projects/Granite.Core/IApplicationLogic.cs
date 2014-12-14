using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Granite.Core
{
    public interface IApplicationLogic
    {
        void Start();
        void Stop();
        void CloseRequest();
        void Render(TimeSpan elapsed);
        void InputEvent(InputEventArgs e);
        void UnhandledException(Exception ex);
    }

    public abstract class ApplicationLogicBase : IApplicationLogic
    {
        public virtual void Start() { }
        public virtual void Stop() { }
        public virtual void CloseRequest() { Engine.Stop(); }
        public virtual void Render(TimeSpan elapsed) { }
        public virtual void InputEvent(InputEventArgs e) { }
        public virtual void UnhandledException(Exception ex) { }
    }
}
