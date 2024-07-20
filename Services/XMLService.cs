using System.Xml;

namespace FileHandler.Services
{
    internal class XMLService
    {
        private string XmlPath;
        //base directory path
        private string _baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
        private XmlDocument activeDoc;

        public XMLService(params string[] xmlPath)
        {
            XmlPath = BuildPath(xmlPath);
            activeDoc = ReadXML()!;
        }

        private string BuildPath(params string[] xmlPath)
        {
            // Create an array that includes the base directory and the xmlPath elements
            string[] fullPath = new string[xmlPath.Length + 1];
            fullPath[0] = _baseDirectory;
            Array.Copy(xmlPath, 0, fullPath, 1, xmlPath.Length);

            // Combine all the elements into a single path
            return Path.Combine(fullPath);
        }

        public XmlNode? GetNodeByName(string nodePath)
        {
            // Replace dot notation with XPath separator
            string xPath = "//" + nodePath.Replace('.', '/');

            // Query the XML document using the constructed XPath
            return activeDoc.SelectSingleNode(xPath);
        }

        public XmlNode? GetNodeByName(XmlNode rootNode, string nodePath)
        {
            // Replace dot notation with XPath separator
            string xPath = ".//" + nodePath.Replace('.', '/');

            // Query the provided root node using the constructed XPath
            return rootNode.SelectSingleNode(xPath);
        }

        public List<T> GetOptions<T>(string nodeName, Func<string, T> transform)
        {
            var node = GetNodeByName(nodeName);
            if (node == null) throw new Exception($"Node '{nodeName}' not found.");

            return node.ChildNodes.Cast<XmlNode>()
                .Select(childNode => transform(childNode.InnerText))
                .ToList();
        }

        public List<TModel> ToModel<TModel>(string nodeName, Func<XmlNode, TModel> transform)
        {
            XmlNode? parentNode = GetNodeByName(nodeName);

            if (parentNode == null)
                throw new Exception($"Node '{nodeName}' not found.");

            return parentNode.ChildNodes.Cast<XmlNode>()
                .Select(transform)
                .ToList();
        }

        public void CreateXML()
        {
            if (!File.Exists(XmlPath))
            {
                XmlWriterSettings xmlWriterSettings = new XmlWriterSettings
                {
                    Indent = true
                };

                using (XmlWriter xmlWriter = XmlWriter.Create(XmlPath, xmlWriterSettings))
                {
                    xmlWriter.WriteStartDocument();
                    xmlWriter.WriteStartElement("Drinks");
                    xmlWriter.WriteEndElement();
                    xmlWriter.WriteEndDocument();
                }
            }
        }

        //read xml file
        public XmlDocument? ReadXML()
        {
            XmlDocument xmlDoc = new XmlDocument();

            using (FileStream fileStream = new FileStream(XmlPath, FileMode.Open, FileAccess.Read))
            {
                xmlDoc.Load(fileStream);
            }
            return xmlDoc;
        }
    }
}
