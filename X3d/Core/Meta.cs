namespace X3d.Core
{
    using System.Xml.Serialization;

    [XmlType(TypeName = "meta")]
    public class Meta : SceneGraphStructureNodeType
    {
        [XmlAttribute(AttributeName = "name")]
        public SFString Name { get; set; }

        [XmlAttribute(AttributeName = "content")]
        public SFString Content { get; set; }

        [XmlAttribute(AttributeName = "dir")]
        public MetaDirectionValues Direction { get; set; }

        [XmlAttribute(AttributeName = "http-equiv")]
        public SFString HttpEquivalant { get; set; }

        [XmlAttribute(AttributeName = "lang")]
        public SFString Language { get; set; }

        [XmlAttribute(AttributeName = "scheme")]
        public SFString Scheme { get; set; }
    }
}
