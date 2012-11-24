namespace X3d.Core
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    public class ProtoInterface : SceneGraphStructureNodeType
    {
        [XmlElement(IsNullable = true)]
        public List<Field> Fields { get; set; }
    }
}
