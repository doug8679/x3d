namespace X3d.Core
{
    using System.Xml;

    public class EXPORT : SceneGraphStructureNodeType, ChildContentModelSceneGraphStructure
    {
        public SFString LocalDEF { get; set; }

        public SFString AS { get; set; }

        public void Write(XmlWriter writer)
        {
            throw new System.NotImplementedException();
        }
    }
}
