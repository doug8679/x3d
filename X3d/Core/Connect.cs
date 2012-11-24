namespace X3d.Core
{
    using System.Xml.Serialization;

    [XmlType(TypeName = "connect")]
    public class Connect : SceneGraphStructureNodeType
    {
        [XmlAttribute(AttributeName = "nodeField")]
        public NameToken NodeField { get; set; }

        [XmlAttribute(AttributeName = "protoField")]
        public NameToken ProtoField { get; set; }
    }
}
