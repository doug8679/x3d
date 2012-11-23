namespace X3d.Core
{
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
    public abstract class X3DMetadataObject : X3DNode
    {
        protected X3DMetadataObject()
        {
            this.ContainerField = new SFString("metadata");
            this.Name = string.Empty;
            this.Reference = string.Empty;
        }

        [XmlAttribute(AttributeName = "name")]
        public SFString Name { get; set; }

        [XmlAttribute(AttributeName = "reference")]
        public SFString Reference { get; set; }
    }

    public abstract class X3DMetadataObject<MetadataType> : X3DMetadataObject
        where MetadataType : new()
    {
        protected X3DMetadataObject() : base()
        {
            this.Value = new MetadataType();
        }

        [XmlAttribute(AttributeName = "value")]
        public MetadataType Value { get; set; }
    }
}
