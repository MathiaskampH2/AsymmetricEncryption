using System.Xml;

namespace AsymmetricEncryption
{
    /// <summary>
    /// XmlReader class
    /// has the purpose of making a xmlReader
    /// That reads the value of a given xml tag on a given xml file
    /// </summary>
    public class XmlReader
    {
        // returns value of an xml tag in a given xml file
        public string GetValueFromXmlFile(string value, string keyPath)
        {
            XmlDocument xml = new XmlDocument();

            xml.Load(keyPath);

            XmlNodeList xmlList = xml.SelectNodes("RSAKeyValue");
            string val = null;
            foreach (XmlNode xmlNode in xmlList)
            {
                val = xmlNode[$"{value}"].InnerText;
            }

            return val;
        }
    }
}