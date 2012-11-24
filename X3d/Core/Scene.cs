namespace X3d.Core
{
    using System;
    using System.Collections.Generic;
    using System.Xml;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable]
    public class Scene : SceneGraphStructureNodeType, IXmlSerializable
    {
        public Scene()
        {
            this.ChildNodes = new List<SceneChildContentModel>();    
        }

        [XmlIgnore]
        public List<SceneChildContentModel> ChildNodes { get; set; }

        #region XML Serialization Interface

        public void ReadXml(XmlReader reader)
        {
            throw new NotImplementedException();
        }

        public void WriteXml(XmlWriter writer)
        {
            var ns = new XmlSerializerNamespaces();
            ns.Add(string.Empty, string.Empty);

            foreach (var child in ChildNodes)
            {
                Type childType = child.GetType();
                var serializer = new XmlSerializer(childType);
                serializer.Serialize(writer, child, ns);
            }
        }

        public XmlSchema GetSchema()
        {
            return null;
        }

        #endregion
    }
}
