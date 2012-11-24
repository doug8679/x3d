namespace X3d.Core
{
    using System.Xml.Serialization;

    public class EXPORT : SceneGraphStructureNodeType, ChildContentModelSceneGraphStructure
    {
        [XmlElement(IsNullable = false)]
        public SFString LocalDEF { get; set; }

        [XmlElement(IsNullable = true)]
        public SFString AS { get; set; }
    }
}
