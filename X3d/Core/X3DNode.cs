namespace X3d.Core
{
    using System.Xml.Serialization;

    /// <summary>
    /// This abstract node type is the base type for all nodes in the X3D system.
    /// </summary>
    public abstract class X3DNode
    {
        [XmlElement(ElementName = "IS", IsNullable = true, Order = 0)]
        public IS IS { get; set; }

        [XmlElement(ElementName = "metadata", IsNullable = true, Order = 1)]
        public ChildContentModelCore Metadata { get; set; }

        [XmlAttribute]
        public NameToken DEF { get; set; }

        [XmlAttribute]
        public NameToken USE { get; set; }

        [XmlAttribute(AttributeName = "containerField")]
        public SFString ContainerField { get; set; }
    }

    
}   
