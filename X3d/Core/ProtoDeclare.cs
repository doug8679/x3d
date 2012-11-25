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

        protected override void WriteAttributes(XmlWriter writer)
        {
            base.WriteAttributes(writer);

            if (this.AppInfo != null)
            {
                writer.WriteAttributeString(AppInfoAttributeName, this.AppInfo.ToString());
            }

            if (this.Documentation != null)
            {
                writer.WriteAttributeString(DocumentationAttributeName, this.Documentation.ToString());
            }
        }

        protected override void WriteChildElements(XmlWriter writer)
        {
            base.WriteChildElements(writer);

            if (this.Interface != null)
            {
                this.Interface.Write(writer);
            }

            if (this.Body != null)
            {
                this.Body.Write(writer);
            }
        }

        public override void Write(XmlWriter writer)
        {
            writer.WriteStartElement(ElementName);

            base.Write(writer);

            writer.WriteEndElement();
        }
    }
}
