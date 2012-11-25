namespace X3d.Core
{
    using System.Xml;

    public class ProtoDeclare : X3DPrototype, ChildContentModelSceneGraphStructure
    {
        public const string ElementName = "ProtoDeclare";

        public const string AppInfoAttributeName = "appinfo";

        public const string DocumentationAttributeName = "documentation";

        public ProtoDeclare()
        {
            this.Interface = null;
            this.Body = null;
            this.AppInfo = null;
            this.Documentation = null;
        }

        public ProtoInterface Interface { get; set; }

        public ProtoBody Body { get; set; }

        public SFString AppInfo { get; set; }

        public SFString Documentation { get; set; }

        public void Write(XmlWriter writer)
        {
            throw new System.NotImplementedException();
        }
    }
}
