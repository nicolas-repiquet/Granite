using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Granite.UI
{
    public class UIElementProperty
    {
        private static int s_nextPropertyId;

        private readonly int m_id;
        private readonly string m_name;

        internal UIElementProperty(string name)
        {
            m_id = s_nextPropertyId++;
            m_name = name;
        }

        public int Id { get { return m_id; } }
        public string Name { get { return m_name; } }
        public bool IsInherited { get; set; }
    }

    public class UIElementProperty<T> : UIElementProperty
    {
        public T DefaultValue { get; set; }

        public UIElementProperty(string name)
            : base(name)
        {

        }
    }
}
