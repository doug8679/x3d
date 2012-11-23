namespace X3d.Core
{
    using System.Xml.Serialization;

    public abstract class X3DMetadataObject<MetadataType> : X3DNode
    {
        protected X3DMetadataObject()
        {
            this.ContainerField = new SFString("metadata");
        }

        [XmlAttribute(AttributeName = "name")]
        public SFString Name { get; set; }

        [XmlAttribute(AttributeName = "reference")]
        public SFString Reference { get; set; }
        [XmlAttribute(AttributeName = "value")]
        public MetadataType Value { get; set; }
    }
}
