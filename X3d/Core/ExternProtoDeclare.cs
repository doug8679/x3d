namespace X3d.Core
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    public class ExternProtoDeclare : X3DPrototype, ChildContentModelSceneGraphStructure
    {
        public const string ElementName = "ExternProtoDeclare";

        public const string URLAttributeName = "url";

        public const string AppInfoAttributeName = "appinfo";

        public const string DocumentationAttributeName = "documentation";

        public ExternProtoDeclare() : base()
        {
            this.Fields = new List<Field>();
            this.URL = new MFString();
            this.AppInfo = null;
            this.Documentation = null;
        }

        private List<Field> fields;
        public List<Field> Fields
        {
            get
            {
                return this.fields;
            }

            set
            {
                if (value == null)
                {
                    throw new FormatException();
                }

                this.fields = value;
            }
        }

        private MFString url;
        public MFString URL
        {
            get
            {
                return this.url;
            }

            set
            {
                if (value == null)
                {
                    throw new FormatException();
                }

                this.url = value;
            }
        }

        public SFString AppInfo { get; set; }

        public SFString Documentation { get; set; }

        protected override void WriteAttributes(XmlWriter writer)
        {
            base.WriteAttributes(writer);

            writer.WriteAttributeString(URLAttributeName, this.URL.ToString());

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

            foreach (var item in fields)
            {
                item.Write(writer);
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
