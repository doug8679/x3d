namespace X3d.Core
{
    using System.Xml.Serialization;

    /// <summary>
    /// The WorldInfo node contains information about the world. This node is 
    /// strictly for documentation purposes and has no effect on the visual 
    /// appearance or behaviour of the world. The title field is intended to 
    /// store the name or title of the world so that browsers can present this 
    /// to the user (perhaps in the window border). Any other information about 
    /// the world can be stored in the info field, such as author information, 
    /// copyright, and usage instructions.
    /// </summary>
    [XmlType]
    public class WorldInfo : X3DInfoNode
    {
        public WorldInfo()
        {
            this.ContainerField = "children";
            this.Info = new MFString();
            this.Title = string.Empty;
        }

        [XmlAttribute(AttributeName = "info")]
        public MFString Info { get; set; }

        [XmlAttribute(AttributeName = "title")]
        public SFString Title { get; set; }
    }
}
