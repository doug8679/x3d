namespace X3d.Core
{
    using System.Xml.Serialization;

    /// <summary>
    /// This abstract node type is the base type for all nodes in the X3D system.
    /// </summary>
    [XmlInclude(typeof(MetadataDouble))]
    [XmlInclude(typeof(MetadataFloat))]
    [XmlInclude(typeof(MetadataInteger))]
    [XmlInclude(typeof(MetadataSet))]
    [XmlInclude(typeof(MetadataString))]
    public abstract class X3DNode
    {
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

        //[XmlAttribute]
        [XmlIgnore]
        public SFString DEF { get; set; }

        //[XmlAttribute]
        [XmlIgnore]
        public SFString USE { get; set; }

        //[XmlAttribute(AttributeName = "containerField")]
        [XmlIgnore]
        public SFString ContainerField { get; set; }
    }

    
}   
