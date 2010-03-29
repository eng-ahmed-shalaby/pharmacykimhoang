using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace Pharmacy.DLL
{
    class UTLXML
    {
        private string strFilePath;
        private XmlDocument xdoc;


        public string FilePath
        {
            set
            {
                this.strFilePath = value;
            }
        }

        public UTLXML()
        {
            xdoc = new XmlDocument();
        }

        public UTLXML(string path)
        {
            this.strFilePath = path;
            this.xdoc = new XmlDocument();

        }

        public bool CreateEmptyXMLDocument()
        {
            try
            {
                XmlDeclaration xmldeclaration = xdoc.CreateXmlDeclaration("1.0", "", "yes");
                xdoc.PrependChild(xmldeclaration);
                XmlElement root = xdoc.CreateElement("root");
                xdoc.AppendChild(root);
                xdoc.Save(this.strFilePath);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        //tao moi 1 tag vao file xml
        public bool AddTag(string tagname, string text)
        {
            try
            {

                xdoc.Load(strFilePath);
                XmlElement root = xdoc.DocumentElement;//lay nut goc
                XmlElement nodeElem = xdoc.CreateElement(tagname);//tao node
                nodeElem.Value = text;
                root.AppendChild(nodeElem);
                xdoc.Save(strFilePath);
                xdoc = null;
                return true;
            }
            catch
            {
                return false;
            }
        }
        //lay thong tin cua 1 tag
        public string ReadTagInfor(string tagname)
        {

            xdoc.Load(strFilePath);
            XmlNode root = xdoc.DocumentElement;

            foreach (XmlNode node in root.FirstChild.ChildNodes)
            {
                if (node.Name.Equals("#comment"))
                {
                    continue;
                }
                if (node.Attributes["key"].Value == tagname)
                    return node.Attributes["value"].Value;
            }
            return "";
        }
        //cap nhat thong tin cua 1 tag
        public bool UpdateTag(string tagname, string innerText)
        {
            try
            {
                xdoc.Load(strFilePath);
                XmlNode root = xdoc.DocumentElement;
                foreach (XmlNode node in root.FirstChild.ChildNodes)
                {
                    if (node.Name.Equals("#comment"))
                    {
                        continue;
                    }
                    if (node.Attributes["key"].Value == tagname)
                    {
                        node.Attributes["value"].Value = innerText;
                        xdoc.Save(strFilePath);
                        break;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }


        }
    }
}
