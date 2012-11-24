namespace X3d.Core
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [XmlType(TypeName = "IS")]
    public class IS : SceneGraphStructureNodeType
    {
        public List<Connect> Connections { get; set; }
    }
}
