using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AAClient
{
    internal class XmlLocalization
    {
        public string[] tags;

        public XmlLocalization()
        {

        }

        public void CreateXML()
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = ("    ");
            settings.CloseOutput = true;
            settings.OmitXmlDeclaration = true;
            using (XmlWriter writer = XmlWriter.Create("template.xml", settings))
            {
                writer.WriteStartElement("localization");
                foreach (string tag in tags)
                {
                    writer.WriteElementString(tag, "DUMMY");
                }
                writer.WriteEndElement();
                writer.Flush();
            }
        }

        public static string ReadXML(string fileName, string tag)
        {
            var xml = new XmlDocument();
            xml.Load(fileName);

            XmlNode node = xml.DocumentElement.SelectSingleNode("/localization/"+tag);

            return node.InnerText;
        }
    }
}
