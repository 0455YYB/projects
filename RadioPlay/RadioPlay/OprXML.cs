using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace RadioPlay
{
    class OprXML
    {
        public void CreateXML(string fileName)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(fileName);
            var root = xmlDocument.DocumentElement;

        }

        public void CreateXmlNode(XmlNode xn)
        {

        }

        public void UpdateXmlNode(XmlNode xn)
        {

        }

        public void DeleteXmlNode(XmlNode xn)
        {

        }
    }
}
