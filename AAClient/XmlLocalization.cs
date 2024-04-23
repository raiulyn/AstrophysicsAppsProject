using System;
using System.Xml;

// RAYMOND LAI
// STUDENT ID: 30082866
// DATE: 23/04/2024

// Referenced Microsoft's documentation on XML functionality and use cases
// https://learn.microsoft.com/en-us/dotnet/api/system.xml.xmldocument?view=net-8.0
// https://learn.microsoft.com/en-us/dotnet/standard/data/xml/
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/xmldoc/recommended-tags
// https://learn.microsoft.com/en-us/troubleshoot/developer/visualstudio/csharp/language-compilers/read-xml-data-from-url
// https://learn.microsoft.com/en-us/dotnet/standard/serialization/examples-of-xml-serialization

namespace AAClient
{
    internal class XmlLocalization
    {
        public string[] tags;

        /// <summary>
        /// Creates a template XML file at application's directory. 
        /// </summary>
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

        /// <summary>
        /// Loads a localized XML file at application's directory
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="tag"></param>
        /// <returns></returns>
        public static string ReadXML(string fileName, string tag)
        {
            try
            {
                var xml = new XmlDocument();
                xml.Load(fileName);

                XmlNode node = xml.DocumentElement.SelectSingleNode("/localization/" + tag);

                return node.InnerText;
            }
            catch (Exception)
            {
                return "Locale Error";
            }
        }
    }
}
