namespace X3d.Core
{
    using System;
    using System.Xml;

    public class ROUTE : SceneGraphStructureNodeType, ChildContentModelSceneGraphStructure
    {
        public ROUTE()
        {
        }

        public const string ElementName = "ROUTE";
        public const string FromNodeAttributeName = "fromNode";
        public const string FromFieldAttributeName = "fromField";
        public const string ToNodeAttributeName = "toNode";
        public const string ToFieldAttributeName = "toField";

        private string fromNode;
        public string FromNode
        {
            get
            {
                return this.fromNode;
            }
            
            set
            {
                if (this.fromNode == null)
                {
                    throw new FormatException();
                }

                this.fromNode = value;
            }
        }

        private string fromField;
        public string FromField
        {
            get
            {
                return this.fromField;
            }

            set
            {
                if (this.fromField == null)
                {
                    throw new FormatException();
                }

                this.fromField = value;
            }
        }

        private string toNode;
        public string ToNode
        {
            get
            {
                return this.toNode;
            }

            set
            {
                if (this.toNode == null)
                {
                    throw new FormatException();
                }

                this.toNode = value;
            }
        }

        private string toField;
        public string ToField
        {
            get
            {
                return this.toField;
            }

            set
            {
                if (this.toField == null)
                {
                    throw new FormatException();
                }

                this.toField = value;
            }
        }

        public void Write(XmlWriter writer)
        {
            writer.WriteStartElement(ElementName);

            writer.WriteAttributeString(FromNodeAttributeName, this.FromNode);
            writer.WriteAttributeString(FromFieldAttributeName, this.FromField);
            writer.WriteAttributeString(ToNodeAttributeName, this.ToNode);
            writer.WriteAttributeString(ToFieldAttributeName, this.ToField);

            writer.WriteEndElement();
        }
    }
}
