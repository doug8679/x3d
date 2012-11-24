namespace X3d.Core
{
    using System;
    using System.Xml.Serialization;

    [XmlType(TypeName = "component")]
    public class Component : SceneGraphStructureNodeType
    {
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

        [XmlAttribute(AttributeName = "name")]
        public ComponentNames Name { get; set; }

        [XmlIgnore]
        private SFInt32 level;

        [XmlIgnore]
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
                    throw new ArgumentOutOfRangeException(string.Format("Level can be between 1 and 5. Value = {0}", value));
                }

                this.level = value;
            }
        }

        [XmlAttribute(AttributeName = "level")]
        public string LevelString
        {
            get
            {
                return this.level.ToString();
            }

            set
            {
                
            }
        }
    }
}
