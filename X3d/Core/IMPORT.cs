namespace X3d.Core
{
    using System.Xml;

    public class IMPORT : SceneGraphStructureNodeType, ChildContentModelSceneGraphStructure
    {
        public SFString InlineDEF { get; set; }

        public NameToken ImportedDEF { get; set; }

        public SFString AS { get; set; }

        public void Write(XmlWriter writer)
        {
            throw new System.NotImplementedException();
        }
    }
}
