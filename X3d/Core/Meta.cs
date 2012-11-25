namespace X3d.Core
{
    using System;
    using System.Xml;

    public class Meta : SceneGraphStructureNodeType
    {
        public const string ElementName = "meta";

        public const string NameAttributeName = "name";

        public const string ContentAttributeName = "content";

        public const string DirectionAttributeName = "dir";

        public const string HttpEquivalantAttributeName = "http-equiv";

        public const string LanguageAttributeName = "lang";

        public const string SchemeAttributeName = "scheme";

        public Meta()
        {
            this.Name = null;
            this.Content = string.Empty;
            this.Direction = null;
            this.HttpEquivalant = null;
            this.Language = null;
            this.Scheme = null;
        }

        public SFString Name { get; set; }

        private SFString content;
        public SFString Content
        {
            get
            {
                return content;
            }

            set
            {
                if (value == null)
                {
                    throw new NullReferenceException();
                }

                this.content = value;
            }
        }

        public MetaDirectionValues? Direction { get; set; }

        public SFString HttpEquivalant { get; set; }

        public SFString Language { get; set; }

        public SFString Scheme { get; set; }

        public void Write(XmlWriter writer)
        {
            writer.WriteStartElement(ElementName);

            if (this.Name != null)
            {
                writer.WriteAttributeString(NameAttributeName, this.Name);
            }

            writer.WriteAttributeString(ContentAttributeName, this.Content);

            if (this.Direction != null)
            {
                writer.WriteAttributeString(DirectionAttributeName, MetaDirectionValuesConverter.ToString(this.Direction));
            }

            if (this.HttpEquivalant != null)
            {
                writer.WriteAttributeString(HttpEquivalantAttributeName, this.HttpEquivalant);
            }

            if (this.Language != null)
            {
                writer.WriteAttributeString(LanguageAttributeName, this.Language);    
            }

            if (this.Scheme != null)
            {
                writer.WriteAttributeString(SchemeAttributeName, this.Scheme);    
            }

            writer.WriteEndElement();
        }
    }
}
