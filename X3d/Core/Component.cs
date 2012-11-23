namespace X3d.Core
{
    using System;
    using System.Xml.Serialization;

    [XmlType(TypeName = "component")]
    public class Component : SceneGraphStructureNodeType
    {
        [XmlAttribute(AttributeName = "name")]
        public ComponentNames Name { get; set; }

        private SFInt32 level;

        [XmlAttribute(AttributeName = "level")]
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
    }
}
