namespace X3d.Core
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [XmlType(TypeName = "head")]
    public class Head : SceneGraphStructureNodeType
    {
        public Head()
        {
            this.Components = new List<Component>();
            this.Meta = new List<Meta>();
        }

        [XmlElement(ElementName = "component", Order = 0)]
        public List<Component> Components { get; set; }

        [XmlElement(Order = 1)]
        public List<Meta> Meta { get; set; }
    }
}
