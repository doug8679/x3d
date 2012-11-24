namespace X3d.Core
{
    using System.Xml;
    using System.Xml.Serialization;

    /// <summary>
    /// This abstract node type is the base type for all nodes in the X3D system.
    /// </summary>
    public abstract class X3DNode
    {
        public const string ISElementName = "IS";

        public const string MetadataElementName = "metadata";

        public const string DEFAttributeName = "DEF";

        public const string USEAttributeName = "USE";

        public const string ContainerNameAttrubuteName = "containerField";
        
        protected X3DNode()
        {
            this.IS = null;
            this.Metadata = null;
            this.DEF = null;
            this.USE = null;
            this.ContainerField = null;
        }

        //[XmlElement(ElementName = "IS", Order = 0)]
        [XmlIgnore]
        public IS IS { get; set; }

        //[XmlElement(ElementName = "metadata", Order = 1)]
        [XmlIgnore]
        public X3DMetadataObject Metadata { get; set; }

        [XmlIgnore]
        public SFString DEF { get; set; }

        [XmlAttribute(AttributeName = DEFAttributeName)]
        public string DEFString
        {
            get
            {
                return this.DEF;
            }

            set
            {
                this.DEF = value;
            }
        }

        [XmlIgnore]
        public SFString USE { get; set; }

        [XmlAttribute(AttributeName = USEAttributeName)]
        public string USEString
        {
            get
            {
                return this.USE;
            }

            set
            {
                this.USE = value;
            }
        }

        [XmlIgnore]
        public SFString ContainerField { get; set; }

        [XmlAttribute(AttributeName = ContainerNameAttrubuteName)]
        public string ContainerFieldString
        {
            get
            {
                return this.ContainerField;
            }

            set
            {
                this.ContainerField = value;
            }
        }

        public virtual void WriteXmlAttributes(XmlWriter writer)
        {
            if (this.DEF != null)
            {
                writer.WriteAttributeString(DEFAttributeName, this.DEFString);
            }

            if (this.USE != null)
            {
                writer.WriteAttributeString(USEAttributeName, this.USEString);
            }

            if (this.ContainerField != null)
            {
                writer.WriteAttributeString(ContainerNameAttrubuteName, this.ContainerFieldString);
            }
        }
    }
}   
