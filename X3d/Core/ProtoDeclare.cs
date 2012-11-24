namespace X3d.Core
{
    using System.Xml.Serialization;

    public class ProtoDeclare : X3DPrototype, ChildContentModelSceneGraphStructure
    {
        [XmlElement(IsNullable = true, Order = 0)]
        public ProtoInterface Interface { get; set; }

        [XmlElement(Order = 1)]
        public ProtoBody Body { get; set; }

        [XmlAttribute(AttributeName = "appInfo")]
        public SFString AppInfo { get; set; }

        [XmlAttribute(AttributeName = "documentation")]
        public SFString Documentation { get; set; }
    }
}
