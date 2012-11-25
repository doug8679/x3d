namespace X3d.Core
{
    using System.Xml.Serialization;

    /// <summary>
    /// The WorldInfo node contains information about the world. This node is 
    /// strictly for documentation purposes and has no effect on the visual 
    /// appearance or behavior of the world. The title field is intended to 
    /// store the name or title of the world so that browsers can present this 
    /// to the user (perhaps in the window border). Any other information about 
    /// the world can be stored in the info field, such as author information, 
    /// copyright, and usage instructions.
    /// </summary>
    public class WorldInfo : X3DInfoNode, ChildContentModelInterchange
    {
        public WorldInfo()
        {
            this.ContainerField = null;
            this.Info = new MFString();
            this.Title = string.Empty;
        }

        [XmlIgnore]
        public MFString Info { get; set; }

        [XmlAttribute(AttributeName = "info")]
        public string InfoString
        {
            get
            {
                return this.Info;
            }

            set
            {
                this.Info = value;
            }
        }

        [XmlIgnore]
        public SFString Title { get; set; }

        [XmlAttribute(AttributeName = "title")]
        public string TitleString
        {
            get
            {
                return this.Title;
            }

            set
            {
                this.Title = value;
            }
        }
    }
}
