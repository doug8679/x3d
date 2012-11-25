namespace X3d.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Xml;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    public sealed class X3DSerializable<TNodeObject> : IXmlSerializable
    {
        public X3DSerializable()
        {
            //this.NodeObject = null;
        }

        public X3DSerializable(TNodeObject obj)
        {
            this.NodeObject = obj;
        }

        public TNodeObject NodeObject {get; set;}


        public void ReadXml(XmlReader reader)
        {
            if (!reader.HasAttributes)
            {
                throw new FormatException("expected a type attribute!");
            }

            string type = reader.GetAttribute("type");

            reader.Read(); // consume the value

            if (type == "null")
            {
                return; // leave T at default value
            }
                
            var serializer = new XmlSerializer(Type.GetType(type));

            this.NodeObject = (TNodeObject)serializer.Deserialize(reader);
            reader.ReadEndElement();
        }

        public void WriteXml(XmlWriter writer)
        {
            if (this.NodeObject == null)
            {
                writer.WriteAttributeString("type", "null");
                return;
            }

            var type = this.NodeObject.GetType();

            var serializer = new XmlSerializer(type);
            var ns = new XmlSerializerNamespaces();
            ns.Add(string.Empty, string.Empty);

            if (type.AssemblyQualifiedName != null)
            {
                writer.WriteAttributeString("type", type.AssemblyQualifiedName);

                serializer.Serialize(writer, this.NodeObject, ns);
            }
            else
            {
                throw new InvalidOperationException(string.Format("Not an assembly qualified name [{0}]", this.NodeObject.GetType().Name));
            }
        }

        public XmlSchema GetSchema()
        {
            return null;
        }
    }
}
