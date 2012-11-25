namespace X3d.Core
{
    using System;
    using System.Xml;

    public class Import : SceneGraphStructureNodeType, ChildContentModelSceneGraphStructure
    {
        public const string ElementName = "IMPORT";

        public const string InlineDEFAttributeName = "inlineDEF";

        public const string ImportedDEFAttributeName = "importedDEF";

        public const string ASAttributeName = "AS";
 
        public Import()
        {
            this.InlineDEF = string.Empty;
            this.ImportedDEF = string.Empty;
            this.AS = null;
        }

        private string inlineDEF;
        public string InlineDEF 
        {
            get
            {
                return this.inlineDEF;
            }

            set
            {
                if (value == null)
                {
                    throw new FormatException();
                }

                this.inlineDEF = value;
            }
        }

        private string importedDEF;
        public string ImportedDEF
        {
            get
            {
                return this.importedDEF;
            }

            set
            {
                if (value == null)
                {
                    throw new FormatException();
                }

                this.importedDEF = value;
            }
        }

        public string AS { get; set; }

        public void Write(XmlWriter writer)
        {
            writer.WriteStartElement(ElementName);

            writer.WriteAttributeString(InlineDEFAttributeName, this.InlineDEF);
            writer.WriteAttributeString(ImportedDEFAttributeName, this.ImportedDEF);
            
            if (this.AS != null)
            {
                writer.WriteAttributeString(ASAttributeName, this.AS);
            }

            writer.WriteEndElement();
        }
    }
}
