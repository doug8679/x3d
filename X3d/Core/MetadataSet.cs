namespace X3d.Core
{
    using System;
    using System.Collections.Generic;
    using System.Xml;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    /// <summary>
    /// The metadata provided by this node is contained in the metadata nodes of 
    /// the value field.
    /// </summary>
    public class MetadataSet : X3DMetadataObject<List<ChildContentModelCore>>, ChildContentModelCore, IXmlSerializable
    {
        public void ReadXml(XmlReader reader)
        {
            throw new System.NotImplementedException();
        }

        public void WriteXml(XmlWriter writer)
        {
            var ns = new XmlSerializerNamespaces();
            ns.Add(string.Empty, string.Empty);
            
            this.WriteXmlAttributes(writer);

            foreach (var child in this.Value)
            {
                Type childType = child.GetType();
                var serializer = new XmlSerializer(childType);
                serializer.Serialize(writer, child, ns);
            }
        }

        public XmlSchema GetSchema()
        {
            throw new System.NotImplementedException();
        }
    }
}
