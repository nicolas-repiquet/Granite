using Granite.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;

namespace Granite.UI
{
    public abstract class UIElement
    {
        public Box2 Bounds { get; set; }
        public UIElement Parent { get; internal set; }
        public abstract IEnumerable<UIElement> GetChildren();
        public abstract void Render(Graphics graphics, TimeSpan elapsed);

        #region UIElementProperties

        private readonly Dictionary<UIElementProperty, object> m_values = new Dictionary<UIElementProperty, object>();

        public T GetValue<T>(UIElementProperty<T> property)
        {
            Contract.Requires<ArgumentNullException>(property != null, "property");

            object value;

            if (!m_values.TryGetValue(property, out value))
            {
                if (property.IsInherited && Parent != null)
                {
                    return Parent.GetValue(property);
                }
                else
                {
                    return property.DefaultValue;
                }
            }
            else
            {
                return (T)value;
            }
        }

        public void SetValue<T>(UIElementProperty<T> property, T value)
        {
            Contract.Requires<ArgumentNullException>(property != null, "property");

            m_values[property] = value;
        }

        public void ClearValue<T>(UIElementProperty<T> property)
        {
            Contract.Requires<ArgumentNullException>(property != null, "property");

            m_values.Remove(property);
        }

        #endregion
    }
}
