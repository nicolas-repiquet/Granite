using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Granite.UI
{
    public class UIContainer : UIVisual
    {
        private readonly UIElementCollection<UIVisual> m_children;

        public UIElementCollection<UIVisual> Children
        {
            get { return m_children; }
        }

        public override IEnumerable<UIElement> GetChildren()
        {
            return m_children;
        }

        public override void Render(Graphics graphics, TimeSpan elapsed)
        {
            throw new NotImplementedException();
        }
    }
}
