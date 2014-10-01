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
        void KeyDown(Key key);
        void KeyUp(Key key);
        void MouseLButtonDown(int x, int y);
    }

    public abstract class ApplicationLogicBase : IApplicationLogic
    {
        public virtual void Start() { }
        public virtual void Stop() { }
        public virtual void CloseRequest() { Engine.Stop(); }
        public virtual void Render() { }
        public virtual void KeyDown(Key key) { }
        public virtual void KeyUp(Key key) { }
        public virtual void MouseLButtonDown(int x, int y) { }
    }
}
