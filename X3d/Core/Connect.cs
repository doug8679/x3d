namespace X3d.Core
{
    using System.Xml.Serialization;

    [XmlType(TypeName = "connect")]
    public class Connect : SceneGraphStructureNodeType
    {
        public Connect()
        {
            this.NodeField = string.Empty;
            this.ProtoField = string.Empty;
        }

        [XmlAttribute(AttributeName = "nodeField")]
        public string NodeField { get; set; }

        [XmlAttribute(AttributeName = "protoField")]
        public string ProtoField { get; set; }
    }
}
