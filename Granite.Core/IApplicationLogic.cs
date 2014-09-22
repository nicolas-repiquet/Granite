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
        void Render();
    }

    public abstract class ApplicationLogicBase : IApplicationLogic
    {
        public virtual void Start() { }
        public virtual void Stop() { }
        public virtual void CloseRequest() { Engine.Stop(); }
        public virtual void Render() { }
    }
}
