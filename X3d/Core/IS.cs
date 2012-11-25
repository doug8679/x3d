namespace X3d.Core
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [XmlType(TypeName = "IS")]
    public class IS : SceneGraphStructureNodeType
    {
        public IS()
        {
            this.Connections = new List<Connect>();    
        }

        [XmlElement(ElementName = "connect")]
        public List<Connect> Connections { get; set; }
    }
}
