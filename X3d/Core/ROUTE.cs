namespace X3d.Core
{
    using System.Xml.Serialization;

    [XmlType(TypeName = "ROUTE")]
    public class ROUTE : SceneGraphStructureNodeType, ChildContentModelSceneGraphStructure
    {
        [XmlAttribute(AttributeName = "fromNode")]
        public SFString FromNode { get; set; }

        [XmlAttribute(AttributeName = "fromField")]
        public NameToken FromField { get; set; }

        [XmlAttribute(AttributeName = "toNode")]
        public SFString ToNode { get; set; }

        [XmlAttribute(AttributeName = "toField")]
        public NameToken ToField { get; set; }
    }
}
