namespace X3d.Core
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    public class Field : SceneGraphStructureNodeType
    {
        public const string ElementName = "field";
        public const string NameAttributeName = "name";
        public const string AccessTypeAttributeName = "accessType";
        public const string TypeAttributeName = "type";
        public const string ValueAttributeName = "value";
        public const string AppInfoAttributeName = "appinfo";
        public const string DocumentationAttributeName = "documentation";

        public Field()
        {
            this.ChildNodes = new List<SceneGraphFragmentContentModel>();
            this.Name = string.Empty;
            this.AccessType = AccessTypeNames.InputOutput;
            this.Type = FieldTypeName.SFBool;
            this.Value = null;
            this.AppInfo = null;
            this.Documentation = null;
        }

        private List<SceneGraphFragmentContentModel> childNodes;
        public List<SceneGraphFragmentContentModel> ChildNodes
        {
            get
            {
                return childNodes;
            }

            set
            {
                if (value == null)
                {
                    throw new FormatException();
                }

                this.childNodes = value;
            }
        }

        private string name;
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (value == null)
                {
                    throw new FormatException();
                }

                this.name = value;
            }
        }

        public AccessTypeNames AccessType { get; set; }

        public FieldTypeName Type { get; set; }

        public SFString Value { get; set; }

        public SFString AppInfo { get; set; }

        public SFString Documentation { get; set; }

        public void Write(XmlWriter writer)
        {
            writer.WriteStartElement(ElementName);

            writer.WriteAttributeString(NameAttributeName, this.Name);
            writer.WriteAttributeString(AccessTypeAttributeName, this.AccessType.ToString("g"));
            writer.WriteAttributeString(TypeAttributeName, FieldTypeNameConverter.ToString(this.Type));

            if (this.Value != null)
            {
                writer.WriteAttributeString(ValueAttributeName, this.Value.ToString());
            }

            if (this.AppInfo != null)
            {
                writer.WriteAttributeString(AppInfoAttributeName, this.AppInfo.ToString());
            }

            if (this.Documentation != null)
            {
                writer.WriteAttributeString(DocumentationAttributeName, this.Documentation.ToString());
            }

            foreach (var item in this.ChildNodes)
            {
                ((X3DNode)item).Write(writer);
            }

            writer.WriteEndElement();
        }
    }
}
