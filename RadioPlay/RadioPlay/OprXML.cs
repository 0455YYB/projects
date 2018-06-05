using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;

namespace RadioPlay
{
    class OprXML
    {
        XmlDocument xmlDoc = new XmlDocument();
       
        public XmlDocument LoadConfig()
        {
            try
            {
                if (System.IO.File.Exists(System.Environment.CurrentDirectory + "\\config1.xml"))
                {
                    xmlDoc.Load(System.Environment.CurrentDirectory + "\\config1.xml");                   
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("缺失配置文件，请联系管理员"); 
                }
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            return xmlDoc;

        }
        public void CreateXML(string fileName)
        {
            try
            {
                bool file = System.IO.File.Exists(System.Environment.CurrentDirectory + "\\config1.xml");

                if (file==false)
                {
                    XmlDocument xmlDocument = new XmlDocument();
                    XmlDeclaration xml = xmlDocument.CreateXmlDeclaration("1.0", "utf-8", string.Empty);
                    xmlDocument.AppendChild(xml);
                    XmlElement rootNoe = xmlDocument.CreateElement("dllCofig");
                    xmlDocument.AppendChild(rootNoe);
                    XmlElement dllName = xmlDocument.CreateElement("dllName");
                    dllName.InnerText = "radioPlay.dll";
                    rootNoe.AppendChild(dllName);
                    xmlDocument.Save("config1.xml");
                    System.Windows.Forms.MessageBox.Show("config1.xml创建成功");
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("文件已经存在");
                    return;
                }
                
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            //xmlDocument.Load(fileName);
            //var root = xmlDocument.DocumentElement;
            //XmlElement personXML = xmlDocument.CreateElement("person");
            //personXML.InnerText = "大家";
            //personXML.SetAttribute("", "");
            //root.AppendChild(personXML);

            //XmlNodeList sd = xmlDocument.GetElementsByTagName("");
        }

        public void CreateXmlNode(XmlNode xn)
        {
            xn.title = "dllClassName";
            xn.text = "CreateMenuStrip";
            XmlDocument xmlDocument = new XmlDocument();
            
        }

        public void UpdateXmlNode(XmlNode xn)
        {

        }

        public void DeleteXmlNode(XmlNode xn)
        {

        }

        public void SelectXmlNode()
        {
            string fileName = System.Environment.CurrentDirectory + "\\config.xml";
            XmlDataDocument config = new XmlDataDocument();
            config.Load(fileName);



        }
            
                               
    }
}
