namespace X3d.Core
{
    using System;
    using System.Xml;

    public class Connect : SceneGraphStructureNodeType
    {
        public const string ElementName = "connect";

        public const string NodeFieldAttributeName = "nodeField";

        public const string ProtoFieldAttributeName = "protoField";

        public Connect()
        {
            this.NodeField = string.Empty;
            this.ProtoField = string.Empty;
        }

        private string nodeField;
        public string NodeField 
        {
            get
            {
                return this.nodeField;
            }

            set
            {
                if (value == null)
                {
                    throw new NullReferenceException();
                }

                this.nodeField = value;
            }
        }

        private string protoField;
        public string ProtoField 
        {
            get
            {
                return this.protoField;
            }

            set
            {
                if (value == null)
                {
                    throw new NullReferenceException();
                }

                this.protoField = value;
            }
        }

        public void Write(XmlWriter writer)
        {
            writer.WriteStartElement(ElementName);

            writer.WriteAttributeString(NodeFieldAttributeName, this.NodeField);
            writer.WriteAttributeString(ProtoFieldAttributeName, this.ProtoField);

            writer.WriteEndElement();
        }
    }
}
