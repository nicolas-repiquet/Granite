using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Granite.UI
{
    public sealed class UIElementCollection<T> : ICollection<T> where T : UIElement
    {
        private readonly UIElement m_parent;
        private readonly List<T> m_elements;

        public UIElementCollection(UIElement parent)
        {
            m_parent = parent;
            m_elements = new List<T>();
        }

        public void Add(T item)
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

        public bool Contains(T item)
        {
            return m_elements.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
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

        public bool Remove(T item)
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

        public IEnumerator<T> GetEnumerator()
        {
            return m_elements.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return ((System.Collections.IEnumerable)m_elements).GetEnumerator();
        }
    }
}
