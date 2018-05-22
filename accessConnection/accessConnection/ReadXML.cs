using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Windows.Forms;

namespace accessConnection
{
    class ReadXML
    {
        public string dataBaseName;
        public string personName;
        public string age;
        public string email;
        public void getXML()
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(System.Environment.CurrentDirectory+"\\config.xml");
            XmlElement xmlElement = xmlDocument.DocumentElement;
            XmlNodeList xmlNodeList = xmlElement.GetElementsByTagName("person");
            personName = xmlElement.GetAttribute("name");
            age = xmlElement.GetAttribute("age");
            email = xmlElement.GetAttribute("email");
            Console.WriteLine("姓名"+personName+"年龄"+age+"邮箱"+email);
           
        }
    }
}
