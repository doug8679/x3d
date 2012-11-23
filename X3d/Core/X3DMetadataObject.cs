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
    /// <typeparam name="MetadataType">
    /// Metadata Specialization Type
    /// </typeparam>
    public abstract class X3DMetadataObject<MetadataType> : X3DNode
        where MetadataType : new()
    {
        protected X3DMetadataObject()
        {
            this.ContainerField = new SFString("metadata");
            this.Name = string.Empty;
            this.Reference = string.Empty;
            this.Value = new MetadataType();
        }

        [XmlAttribute(AttributeName = "name")]
        public SFString Name { get; set; }

        [XmlAttribute(AttributeName = "reference")]
        public SFString Reference { get; set; }

        [XmlAttribute(AttributeName = "value")]
        public MetadataType Value { get; set; }
    }
}
