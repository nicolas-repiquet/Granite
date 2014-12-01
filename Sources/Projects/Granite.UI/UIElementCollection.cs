using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Granite.UI
{
    public sealed class UIElementCollection : ICollection<UIElement>
    {
        private readonly UIElement m_parent;
        private readonly List<UIElement> m_elements;

        public UIElementCollection(UIElement parent)
        {
            m_parent = parent;
            m_elements = new List<UIElement>();
        }

        public void Add(UIElement item)
        {
            if (item != null)
            {
                item.Parent = m_parent;
                m_elements.Add(item);
            }
        }

        public void Clear()
        {
            m_elements.Clear();
        }

        public bool Contains(UIElement item)
        {
            return m_elements.Contains(item);
        }

        public void CopyTo(UIElement[] array, int arrayIndex)
        {
            m_elements.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get { return m_elements.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(UIElement item)
        {
            if (item != null && m_elements.Remove(item))
            {
                item.Parent = null;
                return true;
            }
            else
            {
                return false;
            }
        }

        public IEnumerator<UIElement> GetEnumerator()
        {
            return m_elements.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return ((System.Collections.IEnumerable)m_elements).GetEnumerator();
        }
    }
}
