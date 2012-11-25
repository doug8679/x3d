namespace X3d.Core
{
    using System;
    using System.Xml;

    public class Export : SceneGraphStructureNodeType, ChildContentModelSceneGraphStructure
    {
        public const string ElementName = "IMPORT";

        public const string LocalDEFAttributeName = "localDEF";

        public const string ASAttributeName = "AS";
 
        public Export()
        {
            this.LocalDEF = string.Empty;
            this.AS = null;
        }

        private string localDEF;
        public string LocalDEF 
        {
            get
            {
                return this.localDEF;
            }

            set
            {
                if (value == null)
                {
                    throw new FormatException();
                }

                this.localDEF = value;
            }
        }

        public string AS { get; set; }

        public void Write(XmlWriter writer)
        {
            writer.WriteStartElement(ElementName);

            writer.WriteAttributeString(LocalDEFAttributeName, this.LocalDEF);
            
            if (this.AS != null)
            {
                writer.WriteAttributeString(ASAttributeName, this.AS);
            }

            writer.WriteEndElement();
        }
    }
}
