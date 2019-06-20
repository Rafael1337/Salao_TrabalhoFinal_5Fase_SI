using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Rafael.Salao.Infra.Dados.Helper
{
    public static class XmlHelper
    {
        public static XElement FindElement(this XDocument document, string elementName)
        {
            return document.Descendants(document.Root.Name.Namespace + elementName).FirstOrDefault();
        }

        public static IEnumerable<XElement> FindElements(this XDocument document, string elementName)
        {
            return document.Descendants(document.Root.Name.Namespace + elementName);
        }

        public static XAttribute FindAttribute(this XElement element, string attributeName)
        {
            XAttribute att = null;
            try
            {
                att = element.Attribute(element.Document.Root.Name.Namespace + attributeName);
            }
            catch (Exception) { }

            return att ?? (att = element.Attribute(attributeName));
        }
        public static string ValueOrDefault(this XAttribute element)
        {
            if (element == null || element.Value == null)
                return string.Empty;

            return element.Value;
        }
        public static bool HasElement(this XDocument document, string elementName)
        {
            return document.Descendants(document.Root.Name.Namespace + elementName).FirstOrDefault() != null;
        }
        public static bool HasChild(this XElement element, string elementName)
        {
            return element.Descendants(element.Document.Root.Name.Namespace + elementName).FirstOrDefault() != null;
        }

    }
}
