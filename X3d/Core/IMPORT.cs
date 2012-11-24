namespace X3d.Core
{
    using System.Xml.Serialization;

    public class IMPORT : SceneGraphStructureNodeType, ChildContentModelSceneGraphStructure
    {
        [XmlElement(IsNullable = false)]
        public SFString InlineDEF { get; set; }

        [XmlElement(IsNullable = false)]
        public NameToken ImportedDEF { get; set; }

        [XmlElement(IsNullable = true)]
        public SFString AS { get; set; }
    }
}
