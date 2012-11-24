namespace X3d.Core
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [XmlType(TypeName = "Scene")]
    public class Scene : SceneGraphStructureNodeType
    {
        [XmlIgnore]
        public List<SceneChildContentModel> ChildNodes { get; set; }
    }
}
