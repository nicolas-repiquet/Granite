using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml;
using System.Xml.Linq;


namespace Granite.UI
{
    public abstract class UITemplate
    {
        private const string ClrNamespacePrefix = "clr-namespace:";
        private const string ClrNamespaceAssemblyPrefix = ";assembly=";
        private const string Xmlns = "xmlns";

        private static Exception CreateXNodeException(XNode node, string message)
        {
            var info = node as IXmlLineInfo;

            if (info != null)
            {
                return new Exception(string.Format("{0} at line {1}, position {2}", message, info.LineNumber, info.LinePosition));
            }
            else
            {
                return new Exception(message);
            }
        }

        private static readonly Dictionary<string, Assembly>
            s_assembliesByName = new Dictionary<string, Assembly>();

        private static readonly Dictionary<string, Type>
            s_typesByKey = new Dictionary<string, Type>();

        private static readonly Dictionary<Type, UIElementDescriptor>
            s_elementDescriptorsByType = new Dictionary<Type, UIElementDescriptor>();

        private static Type GetElementType(XElement element, Type modelType)
        {
            var ns = element.GetDefaultNamespace();

            if (ns == null ||
                string.IsNullOrEmpty(ns.NamespaceName) ||
                !ns.NamespaceName.StartsWith(ClrNamespacePrefix))
            {
                throw CreateXNodeException(element, "Invalid namespace");
            }
            else
            {
                Type type;
                var typeKey = ns.NamespaceName + "#" + element.Name;

                if (!s_typesByKey.TryGetValue(typeKey, out type))
                {
                    var clrNamespaceValue = ns.NamespaceName.Substring(ClrNamespacePrefix.Length);
                    Assembly clrAssembly;
                    string clrNamespace;

                    var clrAssemblyNameIndex = clrNamespaceValue.IndexOf(ClrNamespaceAssemblyPrefix);

                    // Specified assembly
                    if (clrAssemblyNameIndex >= 0)
                    {
                        clrNamespace = clrNamespaceValue.Substring(0, clrAssemblyNameIndex);

                        var clrAssemblyName = clrNamespaceValue.Substring(clrAssemblyNameIndex + ClrNamespaceAssemblyPrefix.Length);

                        if (!s_assembliesByName.TryGetValue(clrAssemblyName, out clrAssembly))
                        {
                            foreach (var a in AppDomain.CurrentDomain.GetAssemblies())
                            {
                                if (a.GetName().Name == clrAssemblyName)
                                {
                                    clrAssembly = a;
                                    break;
                                }
                            }

                            if (clrAssembly == null)
                            {
                                throw CreateXNodeException(element, string.Format("Invalid namespace assembly {0}", clrAssemblyName));
                            }
                            else
                            {
                                s_assembliesByName.Add(clrAssemblyName, clrAssembly);
                            }
                        }
                    }
                    // Default assembly
                    else
                    {
                        clrNamespace = clrNamespaceValue;
                        clrAssembly = modelType.Assembly;
                    }

                    var typeName = string.IsNullOrEmpty(clrNamespace) ?
                        element.Name.LocalName :
                        clrNamespace + "." + element.Name.LocalName;

                    type = clrAssembly.GetType(typeName);

                    if (type == null)
                    {
                        throw CreateXNodeException(element, string.Format("Can't fint type {0} in assembly {1}", typeName, clrAssembly.GetName().Name));
                    }
                    else
                    {
                        s_typesByKey.Add(typeKey, type);
                    }
                }

                return type;
            }
        }

        private static UIElementDescriptor GetElementDescriptor(Type elementType)
        {
            UIElementDescriptor descriptor;

            if (!s_elementDescriptorsByType.TryGetValue(elementType, out descriptor))
            {
                var events = elementType.GetEvents();
            }

            return descriptor;
        }

        protected static UIElementFactory GetElementFactory(XElement element, Type modelType)
        {
            var elementType = GetElementType(element, modelType);
            var elementDescriptor = GetElementDescriptor(elementType);

            if (element.HasAttributes)
            {
                var attribute = element.FirstAttribute;

                while (attribute != null)
                {
                    if (attribute.Name.LocalName != Xmlns && attribute.Name.Namespace != XNamespace.Xmlns)
                    {
                        var dotIndex = attribute.Name.LocalName.IndexOf('.');

                        if (dotIndex >= 0)
                        {
                            // Attached Property
                            var elementNamespace = attribute.Name.NamespaceName;
                            var elementName = attribute.Name.LocalName.Substring(0, dotIndex);
                            var propertyName = attribute.Name.LocalName.Substring(dotIndex + 1);


                        }
                        else
                        {
                            // Local Property = Property
                            var propertyName = attribute.Name.LocalName;

                            var node = Granite.UI.ExpressionParser.Parser.Parse(attribute.Value);
                        }
                    }

                    attribute = attribute.NextAttribute;
                }
            }

            if (element.HasElements)
            {
                var node = element.FirstNode;

                while (node != null)
                {
                    var child = node as XElement;

                    if (child != null)
                    {
                        var dotIndex = child.Name.LocalName.IndexOf('.');

                        if (dotIndex >= 0)
                        {
                            var elementNamespace = child.Name.NamespaceName;
                            var elementName = child.Name.LocalName.Substring(0, dotIndex);
                            var propertyName = child.Name.LocalName.Substring(dotIndex + 1);

                            // Local property
                            if (elementName == element.Name.LocalName)
                            {

                            }
                            // Attached property
                            else
                            {

                            }
                        }
                        else
                        {
                            // Content
                            var childFactory = GetElementFactory(child, modelType);

                        }
                    }

                    node = node.NextNode;
                }
            }

            return new UIElementFactory();
        }

        #region TemplateContent
        protected class UIElementDescriptor
        {

        }

        protected class UIElementFactory
        {

        }

        #endregion

        #region Create

        private readonly UIElementFactory m_factory;

        protected UITemplate(UIElementFactory factory)
        {
            m_factory = factory;
        }

        protected UIElement Create(object model)
        {
            // return m_factory.Create(model);
            return null;
        }
        #endregion
    }

    public sealed class UITemplate<TModel> : UITemplate
    {
        public static UITemplate<TModel> Load(string template)
        {
            var document = XDocument.Load(new StringReader(template), LoadOptions.SetLineInfo);
            return new UITemplate<TModel>(GetElementFactory(document.FirstNode as XElement, typeof(TModel)));
        }

        public static UITemplate<TModel> Load(Stream template)
        {
            var document = XDocument.Load(template, LoadOptions.SetLineInfo);
            return new UITemplate<TModel>(GetElementFactory(document.FirstNode as XElement, typeof(TModel)));
        }

        private UITemplate(UIElementFactory factory)
            : base(factory)
        {

        }

        public UIElement Create(TModel model)
        {
            return base.Create(model);
        }
    }
}