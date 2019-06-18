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
    }
}
