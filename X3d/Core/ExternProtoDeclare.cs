namespace X3d.Core
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    public class ExternProtoDeclare : X3DPrototype, ChildContentModelSceneGraphStructure
    {
        [XmlElement(IsNullable = true)]
        public List<Field> Fields { get; set; }

        [XmlAttribute(AttributeName = "url")]
        public MFString URL { get; set; }

        [XmlAttribute(AttributeName = "appinfo")]
        public SFString AppInfo { get; set; }

        [XmlAttribute(AttributeName = "documentation")]
        public SFString Documentation { get; set; }
    }
}
