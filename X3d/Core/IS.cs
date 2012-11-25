namespace X3d.Core
{
    using System.Collections.Generic;
    using System.Xml;

    public class IS : SceneGraphStructureNodeType
    {
        public const string ElementName = "IS";

        public IS()
        {
            this.Connections = new List<Connect>();    
        }

        public List<Connect> Connections { get; set; }

        public void Write(XmlWriter writer)
        {
            writer.WriteStartElement(ElementName);    

            foreach (var item in this.Connections)
            {
                item.Write(writer);
            }

            writer.WriteEndElement();
        }
    }
}
