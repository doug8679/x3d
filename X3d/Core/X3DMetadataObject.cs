namespace X3d.Core
{
    using System.Xml;
    using System.Xml.Serialization;

    /// <summary>
    /// This abstract interface is the basis for all metadata nodes. The 
    /// interface is inherited by all metadata nodes. The specification 
    /// of the reference field is optional. If provided, it identifies 
    /// the metadata standard or other specification that defines the name 
    /// field. If the reference field is not provided or is empty, the 
    /// meaning of the name field is considered implicit to the characters 
    /// in the string.
    /// </summary>
    [XmlInclude(typeof(MetadataDouble))]
    public abstract class X3DMetadataObject : X3DNode, ChildContentModelCore
    {
        public const string NameAttributeName = "name";

        public const string ReferenceAttributeName = "reference";

        protected X3DMetadataObject()
        {
            this.ContainerField = new SFString("metadata");
            this.Name = null;
            this.Reference = null;
        }

        [XmlIgnore]
        public SFString Name { get; set; }

        [XmlAttribute(AttributeName = NameAttributeName)]
        public string NameString
        {
            get
            {
                return this.Name;
            }

            set
            {
                this.Name = value;
            }
        }

        [XmlIgnore]
        public SFString Reference { get; set; }

        [XmlAttribute(AttributeName = ReferenceAttributeName)]
        public string ReferenceString
        {
            get
            {
                return this.Reference;
            }

            set
            {
                this.Reference = value;
            }
        }

        public override void WriteXmlAttributes(XmlWriter writer)
        {
            base.WriteXmlAttributes(writer);
            
            if (this.Name != null)
            {
                writer.WriteAttributeString(NameAttributeName, this.NameString);
            }

            if (this.Reference != null)
            {
                writer.WriteAttributeString(ReferenceAttributeName, this.ReferenceString);
            }
        }
    }

    
    public abstract class X3DMetadataObject<MetadataType> : X3DMetadataObject
        where MetadataType : new()
    {
        public const string ValueAttributeName = "value";

        protected X3DMetadataObject() : base()
        {
            this.Value = new MetadataType();
        }

        [XmlIgnore]
        public MetadataType Value { get; set; }
    }
}
