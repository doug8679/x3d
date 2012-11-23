namespace X3d.Core
{
    using System.Xml.Serialization;

    public class X3DPrototype : SceneGraphStructureNodeType
    {
        [XmlAttribute(AttributeName = "name")]
        public NameToken Name { get; set; }
    }
}
