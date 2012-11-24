namespace X3d.Core
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    public class Field : SceneGraphStructureNodeType
    {
        [XmlElement(IsNullable = true)]
        public List<SceneGraphFragmentContentModel> ChildInstance { get; set; }

        [XmlAttribute(AttributeName = "name")]
        public NameToken Name { get; set; }

        [XmlAttribute(AttributeName = "type")]
        public AccessTypeNames Type { get; set; }

        [XmlAttribute(AttributeName = "value")]
        public SFString Value { get; set; }

        [XmlAttribute(AttributeName = "appInfo")]
        public SFString AppInfo { get; set; }

        [XmlAttribute(AttributeName = "documentation")]
        public SFString Documentation { get; set; }
    }
}
