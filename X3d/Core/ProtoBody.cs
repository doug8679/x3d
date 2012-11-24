namespace X3d.Core
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    public class ProtoBody : SceneGraphStructureNodeType
    {
        [XmlElement(IsNullable = true)]
        public List<SceneGraphFragmentWithPrototypeDeclarationsContentModel> ChildNodes { get; set; }
    }
}
