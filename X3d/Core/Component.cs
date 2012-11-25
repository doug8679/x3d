namespace X3d.Core
{
    using System;
    using System.Xml;

    public class Component : SceneGraphStructureNodeType
    {
        public const string ElementName = "component";

        public const string NameAttributeName = "name";

        public const string LevelAttributeName = "level";

        public Component()
        {
            this.Name = ComponentNames.Core;
            this.Level = 1;
        }

        public Component(ComponentNames name, SFInt32 level)
        {
            this.Name = name;
            this.Level = level;
        }

        public ComponentNames Name { get; set; }

        private SFInt32 level;

        public SFInt32 Level
        {
            get
            {
                return this.level;
            }

            set
            {
                if (value < 1 || value > 5)
                {
                    throw new FormatException();
                }

                this.level = value;
            }
        }

        public void Write(XmlWriter writer)
        {
            writer.WriteStartElement(ElementName);

            writer.WriteAttributeString(NameAttributeName, ComponentNamesConverter.ToString(this.Name));
            writer.WriteAttributeString(LevelAttributeName, this.Level.ToString());

            writer.WriteEndElement();
        }
    }
}
