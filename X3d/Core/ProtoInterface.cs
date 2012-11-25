namespace X3d.Core
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    public class ProtoInterface : SceneGraphStructureNodeType
    {
        public const string ElementName = "ProtoInterface";

        public ProtoInterface()
        {
            this.Fields = new List<Field>();    
        }

        private List<Field> fields; 
        public List<Field> Fields
        {
            get
            {
                return this.fields;
            }

            set
            {
                if (value == null)
                {
                    throw new FormatException();
                }

                this.fields = value;
            }
        }

        public void Write(XmlWriter writer)
        {
            writer.WriteStartElement(ElementName);

            foreach (var item in Fields)
            {
                item.Write(writer);
            }

            writer.WriteEndElement();
        }
    }
}
