namespace X3d.Core
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [XmlType(TypeName = "IS")]
    public class IS : SceneGraphStructureNodeType
    {
        public List<Connect> Connections { get; set; }
    }

    [XmlType(TypeName = "connect")]
    public class Connect : SceneGraphStructureNodeType
    {
        [XmlAttribute(AttributeName = "nodeField")]
        public NameToken NodeField { get; set; }

        [XmlAttribute(AttributeName = "protoField")]
        public NameToken ProtoField { get; set; }
    }
}
