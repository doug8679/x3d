namespace X3d.Core
{
    using System;
    using System.Xml.Serialization;

    [XmlType(TypeName = "meta")]
    public class Meta : SceneGraphStructureNodeType
    {
        public Meta()
        {
            this.Name = null;
            this.Content = string.Empty;
            this.Direction = null;
            this.HttpEquivalant = null;
            this.Language = null;
            this.Scheme = null;
        }

        [XmlIgnore]
        public SFString Name { get; set; }

        [XmlAttribute(AttributeName = "name")]
        public string NameString
        {
            get
            {
                return this.Name;
            }

            set
            {
                this.Name = value;
            }
        }

        [XmlIgnore]
        public SFString Content { get; set; }

        [XmlAttribute(AttributeName = "content")]
        public string ContentString
        {
            get
            {
                return this.Content;
            }

            set
            {
                this.Content = value;
            }
        }

        [XmlIgnore]
        public MetaDirectionValues? Direction { get; set; }

        [XmlAttribute(AttributeName = "dir")]
        public string DirectionString
        {
            get
            {
                return MetaDirectionValuesConverter.ToString(this.Direction);
            }

            set
            {
                this.Direction = MetaDirectionValuesConverter.FromString(value);
            }
        }

        [XmlIgnore]
        public SFString HttpEquivalant { get; set; }

        [XmlAttribute(AttributeName = "http-equiv")]
        public string HttpEquivalantString
        {
            get
            {
                return this.HttpEquivalant;
            }

            set
            {
                this.HttpEquivalant = value;
            }
        }

        [XmlIgnore]
        public SFString Language { get; set; }

        [XmlAttribute(AttributeName = "lang")]
        public string LanguageString
        {
            get
            {
                return this.Language;
            }

            set
            {
                this.Language = value;
            }
        }

        [XmlIgnore]
        public SFString Scheme { get; set; }

        [XmlAttribute(AttributeName = "scheme")]
        public string SchemeString
        {
            get
            {
                return this.Scheme;
            }

            set
            {
                this.Scheme = value;
            }
        }
    }
}
